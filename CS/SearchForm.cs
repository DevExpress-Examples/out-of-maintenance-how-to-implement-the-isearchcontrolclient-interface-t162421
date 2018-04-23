using DevExpress.Data.Filtering;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dxExample
{
    public partial class SearchForm : Form, ISearchControlClient
    {
        public SearchForm() {
            InitializeComponent();
            searchControl1.Client = this;
            gridControl1.DataSource = GetData(10);
        }
        
        #region ISearchControlClient implementation
        public void ApplyFindFilter(SearchInfoBase searchInfo) {
            ResetPrevControls();
            if (searchInfo == null || searchInfo.SearchText == string.Empty) return;
            List<Control> matchedControls = new List<Control>();
            FormSearchInfo info = searchInfo as FormSearchInfo;
            FindControls(this, matchedControls, info.SearchText, info.FilterCondition);
            foreach (Control control in matchedControls) {
                control.Paint -= control_Paint;
                control.Paint += control_Paint;
                control.Invalidate();
            }
            prevControls = matchedControls;
        }

        public SearchControlProviderBase CreateSearchProvider() {
            return new FormSearchProvider();
        }

        public bool IsAttachedToSearchControl {
            get { return srchControl != null; }
        }

        public void SetSearchControl(ISearchControl searchControl) {
            if (srchControl == searchControl) return;
            srchControl = searchControl;
            ApplyFindFilter(null);
        }
        #endregion

        ISearchControl srchControl;
        List<Control> prevControls;
        void ResetPrevControls() {
            if (prevControls != null)
                foreach (Control control in prevControls) {
                    control.Paint -= control_Paint;
                    control.Invalidate();
                }
        }

        bool CheckControlName(string controlName, string searchString, FilterCondition condition) {
            switch (condition) {
                case FilterCondition.Contains:
                    return controlName.Contains(searchString);
                case FilterCondition.StartsWith:
                    return controlName.StartsWith(searchString);
                case FilterCondition.Like:
                    return controlName.Contains(searchString);
                case FilterCondition.Default:
                    return controlName.Contains(searchString);
                case FilterCondition.Equals:
                    return controlName == searchString;
                default: return false;
            }
        }

        public void FindControls(Control owner, List<Control> list, string name, FilterCondition condition) {
            foreach (Control c in owner.Controls) {
                if (CheckControlName(c.Name.ToLower(), name.ToLower(), condition)) {
                    list.Add(c);
                }
                if (c.HasChildren) FindControls(c, list, name, condition);
            }
        }

        void control_Paint(object sender, PaintEventArgs e) {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(55, 255, 0, 0))) {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (radioGroup1.SelectedIndex) {
                case 2: searchControl1.Properties.FilterCondition = FilterCondition.Equals; break;
                case 4: searchControl1.Properties.FilterCondition = FilterCondition.StartsWith; break;
                default: searchControl1.Properties.FilterCondition = FilterCondition.Contains; break;
            }
        }

        DataTable GetData(int rows) {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Info", typeof(string));
            for (int i = 0; i < rows; i++)
                dt.Rows.Add(i, "Info" + i);
            return dt;
        }
    }
}

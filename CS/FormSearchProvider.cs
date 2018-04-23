using DevExpress.Data.Filtering;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dxExample
{
    public class FormSearchProvider : SearchControlProviderBase
    {
        public  FormSearchProvider() {
        }
        protected override void DisposeCore() {
        }
        protected override SearchInfoBase GetCriteriaInfoCore(SearchControlQueryParamsEventArgs args){
            return new FormSearchInfo(args.SearchText, args.FilterCondition);
        }
    }

    public class FormSearchInfo : SearchInfoBase
    {
        string text;
        public FormSearchInfo(string t, FilterCondition condition) {
            text = t;
            FilterCondition = condition;
        }
        public override string SearchText {
            get { return text; }
        }
        public FilterCondition FilterCondition {
            get;
            set;
        }
    }
}

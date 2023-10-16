// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QuerySbjRuleResponseBody : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("SbjRuleList")]
        [Validation(Required=false)]
        public QuerySbjRuleResponseBodySbjRuleList SbjRuleList { get; set; }
        public class QuerySbjRuleResponseBodySbjRuleList : TeaModel {
            [NameInMap("SbjRuleItem")]
            [Validation(Required=false)]
            public List<QuerySbjRuleResponseBodySbjRuleListSbjRuleItem> SbjRuleItem { get; set; }
            public class QuerySbjRuleResponseBodySbjRuleListSbjRuleItem : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("EspExtFieldName")]
                [Validation(Required=false)]
                public string EspExtFieldName { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("FrontendOptions")]
                [Validation(Required=false)]
                public QuerySbjRuleResponseBodySbjRuleListSbjRuleItemFrontendOptions FrontendOptions { get; set; }
                public class QuerySbjRuleResponseBodySbjRuleListSbjRuleItemFrontendOptions : TeaModel {
                    [NameInMap("FrontendOption")]
                    [Validation(Required=false)]
                    public List<QuerySbjRuleResponseBodySbjRuleListSbjRuleItemFrontendOptionsFrontendOption> FrontendOption { get; set; }
                    public class QuerySbjRuleResponseBodySbjRuleListSbjRuleItemFrontendOptionsFrontendOption : TeaModel {
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("FrontendType")]
                [Validation(Required=false)]
                public string FrontendType { get; set; }

                [NameInMap("RequiredExpression")]
                [Validation(Required=false)]
                public string RequiredExpression { get; set; }

                [NameInMap("SbjFieldId")]
                [Validation(Required=false)]
                public string SbjFieldId { get; set; }

                [NameInMap("ShowExpression")]
                [Validation(Required=false)]
                public string ShowExpression { get; set; }

                [NameInMap("TrademarkServiceExpression")]
                [Validation(Required=false)]
                public string TrademarkServiceExpression { get; set; }

                [NameInMap("ValidateRegularExpression")]
                [Validation(Required=false)]
                public string ValidateRegularExpression { get; set; }

            }

        }

    }

}

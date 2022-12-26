// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionRulePageResponseBody : TeaModel {
        [NameInMap("InterceptionRuleList")]
        [Validation(Required=false)]
        public List<ListInterceptionRulePageResponseBodyInterceptionRuleList> InterceptionRuleList { get; set; }
        public class ListInterceptionRulePageResponseBodyInterceptionRuleList : TeaModel {
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget DstTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListDstTarget : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public List<string> Ports { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("InterceptType")]
            [Validation(Required=false)]
            public long? InterceptType { get; set; }

            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public long? OrderIndex { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("SrcTarget")]
            [Validation(Required=false)]
            public ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget SrcTarget { get; set; }
            public class ListInterceptionRulePageResponseBodyInterceptionRuleListSrcTarget : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ImageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<string> TagList { get; set; }

                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public int? TargetId { get; set; }

                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListInterceptionRulePageResponseBodyPageInfo PageInfo { get; set; }
        public class ListInterceptionRulePageResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetInterceptionRuleDetailResponseBody : TeaModel {
        [NameInMap("InterceptionRuleDetail")]
        [Validation(Required=false)]
        public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail InterceptionRuleDetail { get; set; }
        public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetail : TeaModel {
            [NameInMap("DstTarget")]
            [Validation(Required=false)]
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget DstTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailDstTarget : TeaModel {
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
            public GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget SrcTarget { get; set; }
            public class GetInterceptionRuleDetailResponseBodyInterceptionRuleDetailSrcTarget : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

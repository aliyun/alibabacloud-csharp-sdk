// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSensitiveDefineRuleConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSensitiveDefineRuleConfigResponseBodyData Data { get; set; }
        public class GetSensitiveDefineRuleConfigResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            [NameInMap("RuleTree")]
            [Validation(Required=false)]
            public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTree> RuleTree { get; set; }
            public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTree : TeaModel {
                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

                [NameInMap("ClassName")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList> RuleList { get; set; }
                public class GetSensitiveDefineRuleConfigResponseBodyDataRuleTreeRuleList : TeaModel {
                    [NameInMap("RuleKey")]
                    [Validation(Required=false)]
                    public string RuleKey { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            [NameInMap("SelectedCount")]
            [Validation(Required=false)]
            public int? SelectedCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

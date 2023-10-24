// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetContainerDefenseRuleDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContainerDefenseRuleDetailResponseBodyData Data { get; set; }
        public class GetContainerDefenseRuleDetailResponseBodyData : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleSwitch")]
            [Validation(Required=false)]
            public int? RuleSwitch { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<GetContainerDefenseRuleDetailResponseBodyDataScope> Scope { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataScope : TeaModel {
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Namespaces")]
                [Validation(Required=false)]
                public List<string> Namespaces { get; set; }

            }

            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public GetContainerDefenseRuleDetailResponseBodyDataWhitelist Whitelist { get; set; }
            public class GetContainerDefenseRuleDetailResponseBodyDataWhitelist : TeaModel {
                [NameInMap("Hash")]
                [Validation(Required=false)]
                public List<string> Hash { get; set; }

                [NameInMap("Image")]
                [Validation(Required=false)]
                public List<string> Image { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public List<string> Path { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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

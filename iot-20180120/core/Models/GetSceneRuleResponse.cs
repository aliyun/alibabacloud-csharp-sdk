// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetSceneRuleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetSceneRuleResponseData Data { get; set; }
        public class GetSceneRuleResponseData : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public long? GmtModified { get; set; }
            [NameInMap("RuleName")]
            [Validation(Required=true)]
            public string RuleName { get; set; }
            [NameInMap("RuleContent")]
            [Validation(Required=true)]
            public string RuleContent { get; set; }
            [NameInMap("RuleDescription")]
            [Validation(Required=true)]
            public string RuleDescription { get; set; }
            [NameInMap("RuleStatus")]
            [Validation(Required=true)]
            public int? RuleStatus { get; set; }
        };

    }

}

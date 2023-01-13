// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetRuleActionResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("RuleActionInfo")]
        [Validation(Required=true)]
        public GetRuleActionResponseRuleActionInfo RuleActionInfo { get; set; }
        public class GetRuleActionResponseRuleActionInfo : TeaModel {
            [NameInMap("Configuration")]
            [Validation(Required=true)]
            public string Configuration { get; set; }

            [NameInMap("ErrorActionFlag")]
            [Validation(Required=true)]
            public bool? ErrorActionFlag { get; set; }

            [NameInMap("Id")]
            [Validation(Required=true)]
            public long? Id { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=true)]
            public long? RuleId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }

        }

    }

}

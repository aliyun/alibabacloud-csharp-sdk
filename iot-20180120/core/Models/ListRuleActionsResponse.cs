// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleActionsResponse : TeaModel {
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

        [NameInMap("RuleActionList")]
        [Validation(Required=true)]
        public ListRuleActionsResponseRuleActionList RuleActionList { get; set; }
        public class ListRuleActionsResponseRuleActionList : TeaModel {
            [NameInMap("RuleActionInfo")]
            [Validation(Required=true)]
            public List<ListRuleActionsResponseRuleActionListRuleActionInfo> RuleActionInfo { get; set; }
            public class ListRuleActionsResponseRuleActionListRuleActionInfo : TeaModel {
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

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=true)]
                public string Type { get; set; }

            }

        }

    }

}

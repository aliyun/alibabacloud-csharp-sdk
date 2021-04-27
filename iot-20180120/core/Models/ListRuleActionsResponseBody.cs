// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListRuleActionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RuleActionList")]
        [Validation(Required=false)]
        public ListRuleActionsResponseBodyRuleActionList RuleActionList { get; set; }
        public class ListRuleActionsResponseBodyRuleActionList : TeaModel {
            [NameInMap("RuleActionInfo")]
            [Validation(Required=false)]
            public List<ListRuleActionsResponseBodyRuleActionListRuleActionInfo> RuleActionInfo { get; set; }
            public class ListRuleActionsResponseBodyRuleActionListRuleActionInfo : TeaModel {
                public long? Id { get; set; }
                public long? RuleId { get; set; }
                public string Type { get; set; }
                public string Configuration { get; set; }
                public bool? ErrorActionFlag { get; set; }
            }
        };

    }

}

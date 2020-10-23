// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ActiveConfigRulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("OperateRuleResult")]
        [Validation(Required=true)]
        public ActiveConfigRulesResponseOperateRuleResult OperateRuleResult { get; set; }
        public class ActiveConfigRulesResponseOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=true)]
            public List<ActiveConfigRulesResponseOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class ActiveConfigRulesResponseOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}

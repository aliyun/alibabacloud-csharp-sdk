// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class StopConfigRulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("OperateRuleResult")]
        [Validation(Required=true)]
        public StopConfigRulesResponseOperateRuleResult OperateRuleResult { get; set; }
        public class StopConfigRulesResponseOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=true)]
            public List<StopConfigRulesResponseOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class StopConfigRulesResponseOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}

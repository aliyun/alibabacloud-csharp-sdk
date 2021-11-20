// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class StopConfigRulesResponseBody : TeaModel {
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public StopConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class StopConfigRulesResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<StopConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class StopConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

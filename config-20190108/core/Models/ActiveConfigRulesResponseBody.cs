// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class ActiveConfigRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public ActiveConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class ActiveConfigRulesResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<ActiveConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class ActiveConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                public string ConfigRuleId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}

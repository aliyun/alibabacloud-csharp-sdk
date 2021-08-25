// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeactiveAggregateConfigRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DeactiveAggregateConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DeactiveAggregateConfigRulesResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DeactiveAggregateConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DeactiveAggregateConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
                public string ConfigRuleId { get; set; }
            }
        };

    }

}

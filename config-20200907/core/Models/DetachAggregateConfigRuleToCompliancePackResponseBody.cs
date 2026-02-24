// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DetachAggregateConfigRuleToCompliancePackResponseBody : TeaModel {
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult : TeaModel {
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

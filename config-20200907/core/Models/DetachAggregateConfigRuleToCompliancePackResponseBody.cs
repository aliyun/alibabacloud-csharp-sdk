// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DetachAggregateConfigRuleToCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// The results of the operations to remove one or more rules.
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// The result of the operation to remove the rule.
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DetachAggregateConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The error code.
                /// 
                /// *   This parameter is empty if the rule is removed from the compliance package.
                /// *   An error code is returned if the rule fails to be removed from the compliance package. For more information about error codes, see [Error codes](https://error-center.alibabacloud.com/status/product/Config).
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the request was successful. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeactiveAggregateConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DeactiveAggregateConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DeactiveAggregateConfigRulesResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// The returned result.
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DeactiveAggregateConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DeactiveAggregateConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The error code returned.
                /// 
                /// *   If the rule is disabled, no error code is returned.
                /// *   If the rule fails to be disabled, an error code is returned. For more information about error codes, see [Error codes](https://error-center.alibabacloud.com/status/product/Config).
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the request was successful. Valid values:
                /// 
                /// *   true: The request was successful.
                /// *   false: The request failed.
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

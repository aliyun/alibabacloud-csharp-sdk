// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class AttachConfigRuleToCompliancePackResponseBody : TeaModel {
        /// <summary>
        /// The results of the operations to add one or more rules.
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public AttachConfigRuleToCompliancePackResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class AttachConfigRuleToCompliancePackResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// The result of the operation to add the rule.
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<AttachConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class AttachConfigRuleToCompliancePackResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The error code returned.
                /// 
                /// *   This parameter is empty if the rule is added to the compliance package.
                /// *   An error code is returned if the rule fails to be added to the compliance package. For more information about error codes, see [Error codes](https://error-center.alibabacloud.com/status/product/Config).
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

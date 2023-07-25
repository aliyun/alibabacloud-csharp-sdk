// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteConfigRulesResponseBody : TeaModel {
        /// <summary>
        /// The results of the delete operations.
        /// </summary>
        [NameInMap("OperateRuleResult")]
        [Validation(Required=false)]
        public DeleteConfigRulesResponseBodyOperateRuleResult OperateRuleResult { get; set; }
        public class DeleteConfigRulesResponseBodyOperateRuleResult : TeaModel {
            /// <summary>
            /// The result of the delete operation.
            /// </summary>
            [NameInMap("OperateRuleItemList")]
            [Validation(Required=false)]
            public List<DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList> OperateRuleItemList { get; set; }
            public class DeleteConfigRulesResponseBodyOperateRuleResultOperateRuleItemList : TeaModel {
                /// <summary>
                /// The rule ID.
                /// </summary>
                [NameInMap("ConfigRuleId")]
                [Validation(Required=false)]
                public string ConfigRuleId { get; set; }

                /// <summary>
                /// The error code returned if the request failed.
                /// 
                /// *   If the rule is deleted, no error code is returned.
                /// *   If the rule fails to be deleted, an error code is returned. For more information about error codes, see [Error codes](https://api.aliyun.com/document/Config/2020-09-07/errorCode).
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

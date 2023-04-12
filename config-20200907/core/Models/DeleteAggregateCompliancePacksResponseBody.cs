// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateCompliancePacksResponseBody : TeaModel {
        /// <summary>
        /// The results of the delete operations.
        /// </summary>
        [NameInMap("OperateCompliancePacksResult")]
        [Validation(Required=false)]
        public DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult OperateCompliancePacksResult { get; set; }
        public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult : TeaModel {
            /// <summary>
            /// The result of the delete operation.
            /// </summary>
            [NameInMap("OperateCompliancePacks")]
            [Validation(Required=false)]
            public List<DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks> OperateCompliancePacks { get; set; }
            public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks : TeaModel {
                /// <summary>
                /// The ID of the compliance package.
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// The error code.
                /// 
                /// *   If the compliance package is deleted, no error code is returned.
                /// *   If the compliance package fails to be deleted, an error code is returned. For more information about error codes, visit the [API Error Center](https://error-center.alibabacloud.com/status/product/Config).
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the operation is successful. Valid values:
                /// 
                /// *   true: The operation is successful.
                /// *   false: The operation fails.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

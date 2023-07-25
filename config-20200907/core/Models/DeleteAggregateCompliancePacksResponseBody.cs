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
            /// An array that contains the deleted compliance packages.
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
                /// The error code returned.
                /// 
                /// *   If the compliance package is deleted, no error code is returned.
                /// *   If the compliance package fails to be deleted, an error code is returned. For more information about error codes, see [Error codes](https://error-center.alibabacloud.com/status/product/Config).
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

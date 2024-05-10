// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupOperationResultsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the results of the operation.
        /// </summary>
        [NameInMap("StackGroupOperationResults")]
        [Validation(Required=false)]
        public List<ListStackGroupOperationResultsResponseBodyStackGroupOperationResults> StackGroupOperationResults { get; set; }
        public class ListStackGroupOperationResultsResponseBodyStackGroupOperationResults : TeaModel {
            /// <summary>
            /// The ID of the account to which the stack instance belongs.
            /// 
            /// *   If the stack group has self-managed permissions, the stack instance belongs to an Alibaba Cloud account.
            /// *   If the stack group has service-managed permissions, the stack instance belongs to a member account in the resource directory.
            /// 
            /// >  For more information about the account, see [Overview](https://help.aliyun.com/document_detail/154578.html).
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The folder ID of the resource directory.
            /// 
            /// >  This parameter is returned only when the stack group is granted service-managed permissions.
            /// </summary>
            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }

            /// <summary>
            /// The region ID of the stack instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the operation.
            /// 
            /// Valid values:
            /// 
            /// *   RUNNING: The operation is being performed.
            /// *   SUCCEEDED: The operation succeeded.
            /// *   FAILED: The operation failed.
            /// *   STOPPING: The operation is being stopped.
            /// *   STOPPED: The operation is stopped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the operation is in a specific state.
            /// 
            /// >  This parameter is returned only when stack instances are in the OUTDATED state.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// The total number of results.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

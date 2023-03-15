// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupOperationsResponseBody : TeaModel {
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
        /// The list of stack group operations.
        /// </summary>
        [NameInMap("StackGroupOperations")]
        [Validation(Required=false)]
        public List<ListStackGroupOperationsResponseBodyStackGroupOperations> StackGroupOperations { get; set; }
        public class ListStackGroupOperationsResponseBodyStackGroupOperations : TeaModel {
            /// <summary>
            /// The operation that was performed.
            /// 
            /// Valid values:
            /// 
            /// *   CREATE
            /// *   UPDATE
            /// *   DELETE
            /// *   DETECT_DRIFT
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The time when the operation was initiated.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the operation ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The description of the operation.
            /// </summary>
            [NameInMap("OperationDescription")]
            [Validation(Required=false)]
            public string OperationDescription { get; set; }

            /// <summary>
            /// The ID of the operation.
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// The ID of the stack group.
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// The name of the stack group.
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// The status of the operation.
            /// 
            /// Valid values:
            /// 
            /// *   RUNNING
            /// *   SUCCEEDED
            /// *   FAILED
            /// *   STOPPING
            /// *   STOPPED
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of stack group operations.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

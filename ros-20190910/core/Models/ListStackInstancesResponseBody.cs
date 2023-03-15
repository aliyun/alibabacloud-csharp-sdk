// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackInstancesResponseBody : TeaModel {
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
        /// Details of the stacks.
        /// </summary>
        [NameInMap("StackInstances")]
        [Validation(Required=false)]
        public List<ListStackInstancesResponseBodyStackInstances> StackInstances { get; set; }
        public class ListStackInstancesResponseBodyStackInstances : TeaModel {
            /// <summary>
            /// The ID of the account to which the stack belongs.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The time when the last successful drift detection was performed on the stack.
            /// 
            /// >  This parameter is returned only if drift detection is performed on the stack group.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The ID of the folder in the resource directory.
            /// 
            /// >  This parameter is returned only if the stack group is granted service-managed permissions.
            /// </summary>
            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }

            /// <summary>
            /// The ID of the region to which the stack belongs.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The state of the stack when the last successful drift detection was performed on the stack group.
            /// 
            /// Valid values:
            /// 
            /// *   DRIFTED: The stack has drifted.
            /// *   NOT_CHECKED: No successful drift detection is performed on the stack.
            /// *   IN_SYNC: The stack is being synchronized.
            /// 
            /// >  This parameter is returned only if drift detection is performed on the stack group.
            /// </summary>
            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

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
            /// The ID of the stack.
            /// 
            /// >  This parameter is returned only if the stack is in the CURRENT state.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The state of the stack.
            /// 
            /// Valid values:
            /// 
            /// *   CURRENT: The stack is up to date with the stack group.
            /// 
            /// *   OUTDATED: The stack is not up to date with the stack group. Stacks are in the OUTDATED state due to the following possible reasons:
            /// 
            ///     *   When the CreateStackInstances operation is called to create stacks, the stacks fail to be created.
            ///     *   When the UpdateStackInstances or UpdateStackGroup operation is called to update stacks, the stacks fail to be updated, or only specific stacks are updated.
            ///     *   The creation or update operation is not completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the stack is in the OUTDATED state.
            /// 
            /// >  This parameter is returned only if the stack is in the OUTDATED state.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// The total number of stacks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

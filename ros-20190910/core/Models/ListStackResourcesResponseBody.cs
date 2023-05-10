// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourcesResponseBody : TeaModel {
        /// <summary>
        /// The status of the resource. Valid values:
        /// 
        /// *   INIT_COMPLETE: The resource is in the pending creation state.
        /// *   CREATE_COMPLETE: The resource is created.
        /// *   CREATE_FAILED: The resource fails to be created.
        /// *   CREATE_IN_PROGRESS: The resource is being created.
        /// *   UPDATE_IN_PROGRESS: The resource is being updated.
        /// *   UPDATE_FAILED: The resource fails to be updated.
        /// *   UPDATE_COMPLETE: The resource is updated.
        /// *   DELETE_IN_PROGRESS: The resource is being deleted.
        /// *   DELETE_FAILED: The resource fails to be deleted.
        /// *   DELETE_COMPLETE: The resource is deleted.
        /// *   CHECK_IN_PROGRESS: The resource is being validated.
        /// *   CHECK_FAILED: The resource fails to be validated.
        /// *   CHECK_COMPLETE: The resource is validated.
        /// *   IMPORT_IN_PROGRESS: The resource is being imported.
        /// *   IMPORT_FAILED: The resource fails to be imported.
        /// *   IMPORT_COMPLETE: The resource is imported.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The logical ID of the resource. The logical ID is the resource name that is defined in the template.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListStackResourcesResponseBodyResources> Resources { get; set; }
        public class ListStackResourcesResponseBodyResources : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The drift status of the resource in the most recent successful drift detection. Valid values:
            /// 
            /// *   DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.
            /// *   MODIFIED: The actual configuration of the resource differs from its expected template configuration.
            /// *   NOT_CHECKED: ROS did not check whether the actual configuration of the resource differs from its expected template configuration.
            /// *   IN_SYNC: The actual configuration of the resource matches its expected template configuration.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The ID of the stack.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourcesResponseBodyResourcesModuleInfo ModuleInfo { get; set; }
            public class ListStackResourcesResponseBodyResourcesModuleInfo : TeaModel {
                [NameInMap("LogicalIdHierarchy")]
                [Validation(Required=false)]
                public string LogicalIdHierarchy { get; set; }

                [NameInMap("TypeHierarchy")]
                [Validation(Required=false)]
                public string TypeHierarchy { get; set; }

            }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// The time when the resource was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            /// <summary>
            /// The reason why the resource is in a specific state.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The most recent point in time when a successful drift detection operation was performed.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// The time when the resource was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the stack.
            /// 
            /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (\_). The name must start with a digit or letter.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The physical ID of the resource.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourcesResponseBody : TeaModel {
        /// <summary>
        /// Details about resources.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListStackResourcesResponseBodyResources> Resources { get; set; }
        public class ListStackResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// The time when the resource was created. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the most recent successful drift detection was performed on the stack.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The logical ID of the resource. The logical ID is the resource name that is defined in the template.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The information about the modules from which the resource is created. This parameter is returned only if the resource is created from modules.
            /// </summary>
            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourcesResponseBodyResourcesModuleInfo ModuleInfo { get; set; }
            public class ListStackResourcesResponseBodyResourcesModuleInfo : TeaModel {
                /// <summary>
                /// The concatenated logical IDs of one or more modules that contain the resource. The modules are listed from the outermost layer and separated by forward slashes (`/`).
                /// 
                /// In the following example, the resource is created from Module B nested within Parent Module A:
                /// 
                /// `moduleA/moduleB`
                /// </summary>
                [NameInMap("LogicalIdHierarchy")]
                [Validation(Required=false)]
                public string LogicalIdHierarchy { get; set; }

                /// <summary>
                /// The concatenated types of one or more modules that contain the resource. The module types are listed from the outermost layer and separated by forward slashes (`/`).
                /// 
                /// In the following example, the resource is created from a module of the `MODULE::ROS::Child::Example` type that is nested within a parent module of the `MODULE::ROS::Parent::Example` type:
                /// 
                /// `MODULE::ROS::Parent::Example/MODULE::ROS::Child::Example`
                /// </summary>
                [NameInMap("TypeHierarchy")]
                [Validation(Required=false)]
                public string TypeHierarchy { get; set; }

            }

            /// <summary>
            /// The physical ID of the resource.
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// The drift state of the resource in the most recent successful drift detection. Valid values:
            /// 
            /// *   DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.
            /// *   MODIFIED: The actual configuration of the resource differs from its expected template configuration.
            /// *   NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the actual configuration of the resource differs from its expected template configuration.
            /// *   IN_SYNC: The actual configuration of the resource matches its expected template configuration.
            /// </summary>
            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The stack ID.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// The stack name.\\
            /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// The state of the resource. Valid values:
            /// 
            /// *   INIT_COMPLETE: The resource is pending to be created.
            /// *   CREATE_COMPLETE: The resource is created.
            /// *   CREATE_FAILED: The resource failed to be created.
            /// *   CREATE_IN_PROGRESS: The resource is being created.
            /// *   UPDATE_IN_PROGRESS: The resource is being updated.
            /// *   UPDATE_FAILED: The resource failed to be updated.
            /// *   UPDATE_COMPLETE: The resource is updated.
            /// *   DELETE_IN_PROGRESS: The resource is being deleted.
            /// *   DELETE_FAILED: The resource failed to be deleted.
            /// *   DELETE_COMPLETE: The resource is deleted.
            /// *   CHECK_IN_PROGRESS: The resource is being validated.
            /// *   CHECK_FAILED: The resource failed to be validated.
            /// *   CHECK_COMPLETE: The resource is validated.
            /// *   IMPORT_IN_PROGRESS: The resource is being imported.
            /// *   IMPORT_FAILED: The resource failed to be imported.
            /// *   IMPORT_COMPLETE: The resource is imported.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The reason why the resource is in its current state.
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// The time when the resource was updated. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourceDriftsResponseBody : TeaModel {
        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource drifts.
        /// </summary>
        [NameInMap("ResourceDrifts")]
        [Validation(Required=false)]
        public List<ListStackResourceDriftsResponseBodyResourceDrifts> ResourceDrifts { get; set; }
        public class ListStackResourceDriftsResponseBodyResourceDrifts : TeaModel {
            /// <summary>
            /// The actual JSON-formatted resource properties.
            /// </summary>
            [NameInMap("ActualProperties")]
            [Validation(Required=false)]
            public string ActualProperties { get; set; }

            /// <summary>
            /// The time when the drift detection operation was performed on the resource.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The JSON-formatted resource properties that are defined in the template.
            /// </summary>
            [NameInMap("ExpectedProperties")]
            [Validation(Required=false)]
            public string ExpectedProperties { get; set; }

            /// <summary>
            /// The logical ID of the resource. The logical ID indicates the name of the resource that is defined in the template.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// The information about the modules from which the resource was created. This parameter is returned only if the resource is created from modules.
            /// </summary>
            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo ModuleInfo { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo : TeaModel {
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
            /// The property drifts of the resource.
            /// </summary>
            [NameInMap("PropertyDifferences")]
            [Validation(Required=false)]
            public List<ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences> PropertyDifferences { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences : TeaModel {
                /// <summary>
                /// The actual value of the resource property.
                /// </summary>
                [NameInMap("ActualValue")]
                [Validation(Required=false)]
                public string ActualValue { get; set; }

                /// <summary>
                /// The drift type of the resource property. Valid values:
                /// 
                /// *   ADD: The value is added to a resource property whose data type is Array or List.
                /// *   REMOVE: The property is deleted from the current resource configuration.
                /// *   NOT_EQUAL: The current property value differs from the expected value that is defined in the stack template.
                /// </summary>
                [NameInMap("DifferenceType")]
                [Validation(Required=false)]
                public string DifferenceType { get; set; }

                /// <summary>
                /// The expected value of the resource property that is defined in the template.
                /// </summary>
                [NameInMap("ExpectedValue")]
                [Validation(Required=false)]
                public string ExpectedValue { get; set; }

                /// <summary>
                /// The path of the resource property.
                /// </summary>
                [NameInMap("PropertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

            }

            /// <summary>
            /// The drift state of the resource. Valid values:
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

        }

    }

}

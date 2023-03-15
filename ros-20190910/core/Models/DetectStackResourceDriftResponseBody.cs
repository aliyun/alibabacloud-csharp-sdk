// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackResourceDriftResponseBody : TeaModel {
        /// <summary>
        /// The actual resource properties in JSON format.
        /// </summary>
        [NameInMap("ActualProperties")]
        [Validation(Required=false)]
        public string ActualProperties { get; set; }

        /// <summary>
        /// The time at which the resource drift detection operation was initiated.
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// The resource properties as defined in the template, in JSON format.
        /// </summary>
        [NameInMap("ExpectedProperties")]
        [Validation(Required=false)]
        public string ExpectedProperties { get; set; }

        /// <summary>
        /// The logical ID of the resource as defined in the template.
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// The physical ID of the resource.
        /// </summary>
        [NameInMap("PhysicalResourceId")]
        [Validation(Required=false)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// The property differences of the resource.
        /// </summary>
        [NameInMap("PropertyDifferences")]
        [Validation(Required=false)]
        public List<DetectStackResourceDriftResponseBodyPropertyDifferences> PropertyDifferences { get; set; }
        public class DetectStackResourceDriftResponseBodyPropertyDifferences : TeaModel {
            /// <summary>
            /// The actual value of the resource property.
            /// </summary>
            [NameInMap("ActualValue")]
            [Validation(Required=false)]
            public string ActualValue { get; set; }

            /// <summary>
            /// The drift type of the resource property. Valid values:
            /// 
            /// *   ADD: The value has been added to a resource property whose data type is Array or List.
            /// *   REMOVE: The property has been deleted from the current resource configuration.
            /// *   NOT_EQUAL: The current property value differs from the expected value defined in the stack template.
            /// </summary>
            [NameInMap("DifferenceType")]
            [Validation(Required=false)]
            public string DifferenceType { get; set; }

            /// <summary>
            /// The expected value of the resource property as defined in the template.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource drift status. Valid values:
        /// 
        /// *   DELETED: The actual configuration of the resource differs from its expected template configuration because the resource has been deleted.
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
        /// The ID of the stack.
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}

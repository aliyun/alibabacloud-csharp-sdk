// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourceDriftsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The property differences of the resource.
        /// </summary>
        [NameInMap("ResourceDrifts")]
        [Validation(Required=false)]
        public List<ListStackResourceDriftsResponseBodyResourceDrifts> ResourceDrifts { get; set; }
        public class ListStackResourceDriftsResponseBodyResourceDrifts : TeaModel {
            [NameInMap("ActualProperties")]
            [Validation(Required=false)]
            public string ActualProperties { get; set; }

            /// <summary>
            /// The expected value of the resource property as defined in the template.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The query token value returned in this call.
            /// </summary>
            [NameInMap("ExpectedProperties")]
            [Validation(Required=false)]
            public string ExpectedProperties { get; set; }

            /// <summary>
            /// The actual value of the resource property.
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo ModuleInfo { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo : TeaModel {
                [NameInMap("LogicalIdHierarchy")]
                [Validation(Required=false)]
                public string LogicalIdHierarchy { get; set; }

                [NameInMap("TypeHierarchy")]
                [Validation(Required=false)]
                public string TypeHierarchy { get; set; }

            }

            /// <summary>
            /// The path of the resource property.
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// http://ros.aliyun-inc.com:8080/V2/ListStackResourceDrifts
            /// </summary>
            [NameInMap("PropertyDifferences")]
            [Validation(Required=false)]
            public List<ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences> PropertyDifferences { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences : TeaModel {
                /// <summary>
                /// __null__
                /// </summary>
                [NameInMap("ActualValue")]
                [Validation(Required=false)]
                public string ActualValue { get; set; }

                /// <summary>
                /// __null__
                /// </summary>
                [NameInMap("DifferenceType")]
                [Validation(Required=false)]
                public string DifferenceType { get; set; }

                /// <summary>
                /// ListStackResourceDrifts
                /// </summary>
                [NameInMap("ExpectedValue")]
                [Validation(Required=false)]
                public string ExpectedValue { get; set; }

                /// <summary>
                /// __null__
                /// </summary>
                [NameInMap("PropertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

            }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            /// <summary>
            /// The actual resource properties in JSON format.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The drift type of the resource property. Valid values:
            /// 
            /// *   ADD: The value has been added to a resource property whose data type was Array or List.
            /// *   REMOVE: The property has been deleted from the current resource configuration.
            /// *   NOT_EQUAL: The current property value differs from the expected value defined in the stack template.
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

        }

    }

}

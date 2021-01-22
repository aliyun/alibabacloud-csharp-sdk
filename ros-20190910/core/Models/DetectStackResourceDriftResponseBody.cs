// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackResourceDriftResponseBody : TeaModel {
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        [NameInMap("ResourceDriftStatus")]
        [Validation(Required=false)]
        public string ResourceDriftStatus { get; set; }

        [NameInMap("PropertyDifferences")]
        [Validation(Required=false)]
        public List<DetectStackResourceDriftResponseBodyPropertyDifferences> PropertyDifferences { get; set; }
        public class DetectStackResourceDriftResponseBodyPropertyDifferences : TeaModel {
            [NameInMap("ActualValue")]
            [Validation(Required=false)]
            public string ActualValue { get; set; }

            [NameInMap("DifferenceType")]
            [Validation(Required=false)]
            public string DifferenceType { get; set; }

            [NameInMap("PropertyPath")]
            [Validation(Required=false)]
            public string PropertyPath { get; set; }

            [NameInMap("ExpectedValue")]
            [Validation(Required=false)]
            public string ExpectedValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhysicalResourceId")]
        [Validation(Required=false)]
        public string PhysicalResourceId { get; set; }

        [NameInMap("ExpectedProperties")]
        [Validation(Required=false)]
        public string ExpectedProperties { get; set; }

        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ActualProperties")]
        [Validation(Required=false)]
        public string ActualProperties { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}

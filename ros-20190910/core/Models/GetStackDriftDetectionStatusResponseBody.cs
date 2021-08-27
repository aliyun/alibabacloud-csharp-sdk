// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackDriftDetectionStatusResponseBody : TeaModel {
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        [NameInMap("StackDriftStatus")]
        [Validation(Required=false)]
        public string StackDriftStatus { get; set; }

        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        [NameInMap("DriftDetectionStatus")]
        [Validation(Required=false)]
        public string DriftDetectionStatus { get; set; }

        [NameInMap("DriftedStackResourceCount")]
        [Validation(Required=false)]
        public int? DriftedStackResourceCount { get; set; }

        [NameInMap("DriftDetectionStatusReason")]
        [Validation(Required=false)]
        public string DriftDetectionStatusReason { get; set; }

    }

}

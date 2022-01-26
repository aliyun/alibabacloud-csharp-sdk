// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class DescribeComputeTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeComputeTasksResponseBodyData> Data { get; set; }
        public class DescribeComputeTasksResponseBodyData : TeaModel {
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            [NameInMap("DeviceNum")]
            [Validation(Required=false)]
            public int? DeviceNum { get; set; }

            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public float? ImageSize { get; set; }

            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            [NameInMap("StructuredSize")]
            [Validation(Required=false)]
            public float? StructuredSize { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("VectorSize")]
            [Validation(Required=false)]
            public float? VectorSize { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

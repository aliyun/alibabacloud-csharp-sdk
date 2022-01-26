// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class DescribeProjectsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeProjectsResponseBodyData> Data { get; set; }
        public class DescribeProjectsResponseBodyData : TeaModel {
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            [NameInMap("GbId")]
            [Validation(Required=false)]
            public string GbId { get; set; }

            [NameInMap("GbIp")]
            [Validation(Required=false)]
            public string GbIp { get; set; }

            [NameInMap("GbPort")]
            [Validation(Required=false)]
            public string GbPort { get; set; }

            [NameInMap("ImageSize")]
            [Validation(Required=false)]
            public float? ImageSize { get; set; }

            [NameInMap("PackagePattern")]
            [Validation(Required=false)]
            public string PackagePattern { get; set; }

            [NameInMap("ProjectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StructuredSize")]
            [Validation(Required=false)]
            public float? StructuredSize { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineInstanceInfoResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetPipelineInstanceInfoResponseBodyObject Object { get; set; }
        public class GetPipelineInstanceInfoResponseBodyObject : TeaModel {
            [NameInMap("EmployeeId")]
            [Validation(Required=false)]
            public string EmployeeId { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public string Sources { get; set; }
            [NameInMap("DockerImages")]
            [Validation(Required=false)]
            public List<string> DockerImages { get; set; }
            [NameInMap("PackageDownloadUrls")]
            [Validation(Required=false)]
            public List<string> PackageDownloadUrls { get; set; }
        };

    }

}

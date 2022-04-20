// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVersionManagementResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionDetails")]
        [Validation(Required=false)]
        public List<DescribeVersionManagementResponseBodyVersionDetails> VersionDetails { get; set; }
        public class DescribeVersionManagementResponseBodyVersionDetails : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeploymentName")]
            [Validation(Required=false)]
            public string DeploymentName { get; set; }

            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("Inject")]
            [Validation(Required=false)]
            public bool? Inject { get; set; }

            [NameInMap("PodInstances")]
            [Validation(Required=false)]
            public List<DescribeVersionManagementResponseBodyVersionDetailsPodInstances> PodInstances { get; set; }
            public class DescribeVersionManagementResponseBodyVersionDetailsPodInstances : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NodeIp")]
                [Validation(Required=false)]
                public string NodeIp { get; set; }

                [NameInMap("PodIP")]
                [Validation(Required=false)]
                public string PodIP { get; set; }

                [NameInMap("PodName")]
                [Validation(Required=false)]
                public string PodName { get; set; }

                [NameInMap("RestartTime")]
                [Validation(Required=false)]
                public int? RestartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("ReadyReplicas")]
            [Validation(Required=false)]
            public int? ReadyReplicas { get; set; }

            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeVersionManagementResponseBodyVersionDetailsResource Resource { get; set; }
            public class DescribeVersionManagementResponseBodyVersionDetailsResource : TeaModel {
                [NameInMap("CPULimit")]
                [Validation(Required=false)]
                public string CPULimit { get; set; }
                [NameInMap("CPURequest")]
                [Validation(Required=false)]
                public string CPURequest { get; set; }
                [NameInMap("MemoryLimit")]
                [Validation(Required=false)]
                public string MemoryLimit { get; set; }
                [NameInMap("MemoryRequest")]
                [Validation(Required=false)]
                public string MemoryRequest { get; set; }
            };

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

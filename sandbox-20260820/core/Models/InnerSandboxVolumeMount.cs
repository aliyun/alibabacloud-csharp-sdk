// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerSandboxVolumeMount : TeaModel {
        [NameInMap("agenticFs")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMountAgenticFs AgenticFs { get; set; }
        public class InnerSandboxVolumeMountAgenticFs : TeaModel {
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountAgenticFsMountPoints : TeaModel {
                [NameInMap("accessPointID")]
                [Validation(Required=false)]
                public string AccessPointID { get; set; }

                [NameInMap("agenticSpaceID")]
                [Validation(Required=false)]
                public string AgenticSpaceID { get; set; }

                [NameInMap("fileSystemID")]
                [Validation(Required=false)]
                public string FileSystemID { get; set; }

                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                [NameInMap("serverAddr")]
                [Validation(Required=false)]
                public string ServerAddr { get; set; }

            }

            [NameInMap("userID")]
            [Validation(Required=false)]
            public int? UserID { get; set; }

        }

        [NameInMap("named")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMountNamed Named { get; set; }
        public class InnerSandboxVolumeMountNamed : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountNamedMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountNamedMountPoints : TeaModel {
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                [NameInMap("volumeName")]
                [Validation(Required=false)]
                public string VolumeName { get; set; }

            }

        }

        [NameInMap("oss")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMountOss Oss { get; set; }
        public class InnerSandboxVolumeMountOss : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountOssMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountOssMountPoints : TeaModel {
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

        }

    }

}

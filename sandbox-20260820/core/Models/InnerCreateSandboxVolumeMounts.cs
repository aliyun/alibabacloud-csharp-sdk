// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerCreateSandboxVolumeMounts : TeaModel {
        [NameInMap("agenticFs")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMountsAgenticFs AgenticFs { get; set; }
        public class InnerCreateSandboxVolumeMountsAgenticFs : TeaModel {
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsAgenticFsMountPoints : TeaModel {
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
        public InnerCreateSandboxVolumeMountsNamed Named { get; set; }
        public class InnerCreateSandboxVolumeMountsNamed : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsNamedMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsNamedMountPoints : TeaModel {
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
        public InnerCreateSandboxVolumeMountsOss Oss { get; set; }
        public class InnerCreateSandboxVolumeMountsOss : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsOssMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsOssMountPoints : TeaModel {
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

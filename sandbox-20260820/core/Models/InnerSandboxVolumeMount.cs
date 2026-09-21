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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountAgenticFsMountPoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-xxxx</para>
                /// </summary>
                [NameInMap("accessPointID")]
                [Validation(Required=false)]
                public string AccessPointID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agentic-xxxx</para>
                /// </summary>
                [NameInMap("agenticSpaceID")]
                [Validation(Required=false)]
                public string AgenticSpaceID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>03204sl2qjiax4oxxxx</para>
                /// </summary>
                [NameInMap("fileSystemID")]
                [Validation(Required=false)]
                public string FileSystemID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-xxxx.xxxx-ljs60.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("serverAddr")]
                [Validation(Required=false)]
                public string ServerAddr { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/named</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>workspace</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-bucket-test</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss-cn-shenzhen-internal.aliyuncs.com</para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/oss</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

        }

    }

}

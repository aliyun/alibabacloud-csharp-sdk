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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsAgenticFsMountPoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-xxxx.03204sl2qjiax4ocdt2-ljs60.cn-shanghai.nas.aliyuncs.com</para>
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
        public InnerCreateSandboxVolumeMountsNamed Named { get; set; }
        public class InnerCreateSandboxVolumeMountsNamed : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsNamedMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsNamedMountPoints : TeaModel {
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
        public InnerCreateSandboxVolumeMountsOss Oss { get; set; }
        public class InnerCreateSandboxVolumeMountsOss : TeaModel {
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsOssMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsOssMountPoints : TeaModel {
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
                /// <para><a href="https://oss-cn-shenzhen-internal.aliyuncs.com">https://oss-cn-shenzhen-internal.aliyuncs.com</a></para>
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

        }

    }

}

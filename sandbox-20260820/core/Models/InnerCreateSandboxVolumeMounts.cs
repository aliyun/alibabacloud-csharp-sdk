// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerCreateSandboxVolumeMounts : TeaModel {
        /// <summary>
        /// <para>The AgenticFS mount configuration.</para>
        /// </summary>
        [NameInMap("agenticFs")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMountsAgenticFs AgenticFs { get; set; }
        public class InnerCreateSandboxVolumeMountsAgenticFs : TeaModel {
            /// <summary>
            /// <para>The group ID for the local mount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            /// <summary>
            /// <para>The mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsAgenticFsMountPoints : TeaModel {
                /// <summary>
                /// <para>The local mount directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <para>The AgenticFS access point address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-xxxx.03204sl2qjiax4ocdt2-ljs60.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("serverAddr")]
                [Validation(Required=false)]
                public string ServerAddr { get; set; }

            }

            /// <summary>
            /// <para>The user ID for the local mount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("userID")]
            [Validation(Required=false)]
            public int? UserID { get; set; }

        }

        /// <summary>
        /// <para>The predefined volume mount configuration.</para>
        /// </summary>
        [NameInMap("named")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMountsNamed Named { get; set; }
        public class InnerCreateSandboxVolumeMountsNamed : TeaModel {
            /// <summary>
            /// <para>The mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsNamedMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsNamedMountPoints : TeaModel {
                /// <summary>
                /// <para>The local mount directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/named</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <para>The volume name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace</para>
                /// </summary>
                [NameInMap("volumeName")]
                [Validation(Required=false)]
                public string VolumeName { get; set; }

            }

        }

        /// <summary>
        /// <para>The OSS mount configuration.</para>
        /// </summary>
        [NameInMap("oss")]
        [Validation(Required=false)]
        public InnerCreateSandboxVolumeMountsOss Oss { get; set; }
        public class InnerCreateSandboxVolumeMountsOss : TeaModel {
            /// <summary>
            /// <para>The mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerCreateSandboxVolumeMountsOssMountPoints> MountPoints { get; set; }
            public class InnerCreateSandboxVolumeMountsOssMountPoints : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-bucket-test</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The OSS bucket path to mount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("bucketPath")]
                [Validation(Required=false)]
                public string BucketPath { get; set; }

                /// <summary>
                /// <para>The endpoint URL of OSS.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oss-cn-shenzhen-internal.aliyuncs.com">https://oss-cn-shenzhen-internal.aliyuncs.com</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The local mount directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss</para>
                /// </summary>
                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Read-only.</description></item>
                /// <item><description>false: Read and write.</description></item>
                /// </list>
                /// 
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

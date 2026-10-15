// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class InnerSandboxVolumeMount : TeaModel {
        /// <summary>
        /// <para>The AgenticFS mount configuration.</para>
        /// </summary>
        [NameInMap("agenticFs")]
        [Validation(Required=false)]
        public InnerSandboxVolumeMountAgenticFs AgenticFs { get; set; }
        public class InnerSandboxVolumeMountAgenticFs : TeaModel {
            /// <summary>
            /// <para>The local mount group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            /// <summary>
            /// <para>The AgenticFS mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountAgenticFsMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountAgenticFsMountPoints : TeaModel {
                /// <summary>
                /// <para>The access point ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-xxxx</para>
                /// </summary>
                [NameInMap("accessPointID")]
                [Validation(Required=false)]
                public string AccessPointID { get; set; }

                /// <summary>
                /// <para>The AgenticSpace workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentic-xxxx</para>
                /// </summary>
                [NameInMap("agenticSpaceID")]
                [Validation(Required=false)]
                public string AgenticSpaceID { get; set; }

                /// <summary>
                /// <para>The file system ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>03204sl2qjiax4oxxxx</para>
                /// </summary>
                [NameInMap("fileSystemID")]
                [Validation(Required=false)]
                public string FileSystemID { get; set; }

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
                /// <para>The access point mount address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-xxxx.xxxx-ljs60.cn-shanghai.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("serverAddr")]
                [Validation(Required=false)]
                public string ServerAddr { get; set; }

            }

            /// <summary>
            /// <para>The local mount user ID.</para>
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
        public InnerSandboxVolumeMountNamed Named { get; set; }
        public class InnerSandboxVolumeMountNamed : TeaModel {
            /// <summary>
            /// <para>The mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountNamedMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountNamedMountPoints : TeaModel {
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
        public InnerSandboxVolumeMountOss Oss { get; set; }
        public class InnerSandboxVolumeMountOss : TeaModel {
            /// <summary>
            /// <para>The mount point configuration.</para>
            /// </summary>
            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<InnerSandboxVolumeMountOssMountPoints> MountPoints { get; set; }
            public class InnerSandboxVolumeMountOssMountPoints : TeaModel {
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
                /// <para>The OSS endpoint address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-shenzhen-internal.aliyuncs.com</para>
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
                /// <item><description><para><b>true</b>: Read-only.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Not read-only.</para>
                /// </description></item>
                /// </list>
                /// 
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

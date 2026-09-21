// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateVolumeInput : TeaModel {
        /// <summary>
        /// <para>The AgenticBucket Volume configuration.</para>
        /// </summary>
        [NameInMap("agenticBucketVolumeConfig")]
        [Validation(Required=false)]
        public AgenticBucketVolumeConfig AgenticBucketVolumeConfig { get; set; }

        /// <summary>
        /// <para>The AgenticFS Volume configuration.</para>
        /// </summary>
        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public CreateVolumeInputAgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }
        public class CreateVolumeInputAgenticFSVolumeConfig : TeaModel {
            /// <summary>
            /// <para>The groupID of the local directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            /// <summary>
            /// <para>The Access Point endpoint address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-xxxx.xxxx-jnk89.cn-hangzhou.nas.aliyuncs.com:/</para>
            /// </summary>
            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

            /// <summary>
            /// <para>The userID of the local directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("userID")]
            [Validation(Required=false)]
            public int? UserID { get; set; }

        }

        /// <summary>
        /// <para>The JuiceFS Volume configuration.</para>
        /// </summary>
        [NameInMap("juiceFSVolumeConfig")]
        [Validation(Required=false)]
        public JuiceFSVolumeConfig JuiceFSVolumeConfig { get; set; }

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public CreateVolumeInputMountConfig MountConfig { get; set; }
        public class CreateVolumeInputMountConfig : TeaModel {
            /// <summary>
            /// <para>The permission role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1118555931230119:role/aliyunfcdefaultrole</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The VPC configuration.</para>
            /// </summary>
            [NameInMap("vpcConfig")]
            [Validation(Required=false)]
            public CreateVolumeInputMountConfigVpcConfig VpcConfig { get; set; }
            public class CreateVolumeInputMountConfigVpcConfig : TeaModel {
                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch IDs.</para>
                /// </summary>
                [NameInMap("vSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-****</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The OSS Volume configuration.</para>
        /// </summary>
        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37ddc466-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The name, which must be unique within the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace</para>
        /// </summary>
        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}

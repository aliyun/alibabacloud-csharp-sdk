// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateVolumeInput : TeaModel {
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
        public UpdateVolumeInputAgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }
        public class UpdateVolumeInputAgenticFSVolumeConfig : TeaModel {
            /// <summary>
            /// <para>The group ID of the local directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            /// <summary>
            /// <para>The access point address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-xxx.xxx-jnk89.cn-hangzhou.nas.aliyuncs.com:/</para>
            /// </summary>
            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

            /// <summary>
            /// <para>The user ID of the local directory.</para>
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
        public UpdateVolumeInputMountConfig MountConfig { get; set; }
        public class UpdateVolumeInputMountConfig : TeaModel {
            /// <summary>
            /// <para>The permission role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1338904783509062:role/aliyunfcdefaultrole</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The VPC configuration.</para>
            /// </summary>
            [NameInMap("vpcConfig")]
            [Validation(Required=false)]
            public UpdateVolumeInputMountConfigVpcConfig VpcConfig { get; set; }
            public class UpdateVolumeInputMountConfigVpcConfig : TeaModel {
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
                /// <para>vpc-xxxx</para>
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

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateVolumeInput : TeaModel {
        /// <summary>
        /// <para>The AgenticFS configuration.</para>
        /// </summary>
        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public AgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }

        /// <summary>
        /// <para>The mount configuration.</para>
        /// </summary>
        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public CreateVolumeInputMountConfig MountConfig { get; set; }
        public class CreateVolumeInputMountConfig : TeaModel {
            /// <summary>
            /// <para>The RAM role that the user grants to the cloud sandbox. After this role is set, the cloud sandbox assumes the role to generate temporary access credentials. You can use the temporary access credentials of this role to mount storage in the cloud sandbox, such as OSS and AgenticFS.</para>
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
            public CreateVolumeInputMountConfigVpcConfig VpcConfig { get; set; }
            public class CreateVolumeInputMountConfigVpcConfig : TeaModel {
                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The list of vSwitches.</para>
                /// </summary>
                [NameInMap("vSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-8vbq8hbepimf6lr7uyqub</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The OSS configuration.</para>
        /// </summary>
        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0383-58d8-97ac-5336eb91abcd</para>
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

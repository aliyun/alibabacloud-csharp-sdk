// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateVolumeInput : TeaModel {
        [NameInMap("agenticBucketVolumeConfig")]
        [Validation(Required=false)]
        public AgenticBucketVolumeConfig AgenticBucketVolumeConfig { get; set; }

        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public UpdateVolumeInputAgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }
        public class UpdateVolumeInputAgenticFSVolumeConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ap-xxx.xxx-jnk89.cn-hangzhou.nas.aliyuncs.com:/</para>
            /// </summary>
            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("userID")]
            [Validation(Required=false)]
            public int? UserID { get; set; }

        }

        [NameInMap("juiceFSVolumeConfig")]
        [Validation(Required=false)]
        public JuiceFSVolumeConfig JuiceFSVolumeConfig { get; set; }

        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public UpdateVolumeInputMountConfig MountConfig { get; set; }
        public class UpdateVolumeInputMountConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::1338904783509062:role/aliyunfcdefaultrole</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("vpcConfig")]
            [Validation(Required=false)]
            public UpdateVolumeInputMountConfigVpcConfig VpcConfig { get; set; }
            public class UpdateVolumeInputMountConfigVpcConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-xxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("vSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-xxxx</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

    }

}

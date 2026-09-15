// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateVolumeInput : TeaModel {
        [NameInMap("agenticBucketVolumeConfig")]
        [Validation(Required=false)]
        public AgenticBucketVolumeConfig AgenticBucketVolumeConfig { get; set; }

        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public CreateVolumeInputAgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }
        public class CreateVolumeInputAgenticFSVolumeConfig : TeaModel {
            [NameInMap("groupID")]
            [Validation(Required=false)]
            public int? GroupID { get; set; }

            [NameInMap("serverAddr")]
            [Validation(Required=false)]
            public string ServerAddr { get; set; }

            [NameInMap("userID")]
            [Validation(Required=false)]
            public int? UserID { get; set; }

        }

        [NameInMap("juiceFSVolumeConfig")]
        [Validation(Required=false)]
        public JuiceFSVolumeConfig JuiceFSVolumeConfig { get; set; }

        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public CreateVolumeInputMountConfig MountConfig { get; set; }
        public class CreateVolumeInputMountConfig : TeaModel {
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("vpcConfig")]
            [Validation(Required=false)]
            public CreateVolumeInputMountConfigVpcConfig VpcConfig { get; set; }
            public class CreateVolumeInputMountConfigVpcConfig : TeaModel {
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("vSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}

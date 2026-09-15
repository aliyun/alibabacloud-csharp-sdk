// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BVolume : TeaModel {
        [NameInMap("agenticBucketVolumeConfig")]
        [Validation(Required=false)]
        public AgenticBucketVolumeConfig AgenticBucketVolumeConfig { get; set; }

        [NameInMap("agenticFSVolumeConfig")]
        [Validation(Required=false)]
        public AgenticFSVolumeConfig AgenticFSVolumeConfig { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("juiceFSVolumeConfig")]
        [Validation(Required=false)]
        public JuiceFSVolumeConfig JuiceFSVolumeConfig { get; set; }

        [NameInMap("mountConfig")]
        [Validation(Required=false)]
        public VolumeMountConfig MountConfig { get; set; }

        [NameInMap("ossVolumeConfig")]
        [Validation(Required=false)]
        public OSSVolumeConfig OssVolumeConfig { get; set; }

        [NameInMap("resourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("storageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

        [NameInMap("volumeID")]
        [Validation(Required=false)]
        public string VolumeID { get; set; }

        [NameInMap("volumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}

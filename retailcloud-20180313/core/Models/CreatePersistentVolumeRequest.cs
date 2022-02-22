// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreatePersistentVolumeRequest : TeaModel {
        [NameInMap("AccessModes")]
        [Validation(Required=false)]
        public string AccessModes { get; set; }

        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        [NameInMap("ClusterInstanceId")]
        [Validation(Required=false)]
        public string ClusterInstanceId { get; set; }

        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("MountTargetDomain")]
        [Validation(Required=false)]
        public string MountTargetDomain { get; set; }

        [NameInMap("NFSVersion")]
        [Validation(Required=false)]
        public string NFSVersion { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ReclaimPolicy")]
        [Validation(Required=false)]
        public string ReclaimPolicy { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}

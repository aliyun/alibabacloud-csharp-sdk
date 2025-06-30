// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceInfos : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("GpuCardType")]
        [Validation(Required=false)]
        public string GpuCardType { get; set; }

        [NameInMap("MachineModel")]
        [Validation(Required=false)]
        public string MachineModel { get; set; }

        [NameInMap("MaxQuota")]
        [Validation(Required=false)]
        public long? MaxQuota { get; set; }

        [NameInMap("NetworkPodId")]
        [Validation(Required=false)]
        public string NetworkPodId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

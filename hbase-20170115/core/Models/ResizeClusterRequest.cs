// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class ResizeClusterRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CloudType")]
        [Validation(Required=false)]
        public string CloudType { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ColdStorageSize")]
        [Validation(Required=false)]
        public string ColdStorageSize { get; set; }

        [NameInMap("CoreDiskQuantity")]
        [Validation(Required=false)]
        public string CoreDiskQuantity { get; set; }

        [NameInMap("CoreDiskSize")]
        [Validation(Required=false)]
        public string CoreDiskSize { get; set; }

        [NameInMap("CoreDiskType")]
        [Validation(Required=false)]
        public string CoreDiskType { get; set; }

        [NameInMap("CoreInstanceQuantity")]
        [Validation(Required=false)]
        public string CoreInstanceQuantity { get; set; }

        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("IsColdStorage")]
        [Validation(Required=false)]
        public string IsColdStorage { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

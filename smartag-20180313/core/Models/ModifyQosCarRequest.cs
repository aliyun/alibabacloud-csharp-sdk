// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyQosCarRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        [NameInMap("QosCarId")]
        [Validation(Required=false)]
        public string QosCarId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("LimitType")]
        [Validation(Required=false)]
        public string LimitType { get; set; }

        [NameInMap("MinBandwidthAbs")]
        [Validation(Required=false)]
        public int? MinBandwidthAbs { get; set; }

        [NameInMap("MaxBandwidthAbs")]
        [Validation(Required=false)]
        public int? MaxBandwidthAbs { get; set; }

        [NameInMap("MinBandwidthPercent")]
        [Validation(Required=false)]
        public int? MinBandwidthPercent { get; set; }

        [NameInMap("MaxBandwidthPercent")]
        [Validation(Required=false)]
        public int? MaxBandwidthPercent { get; set; }

        [NameInMap("PercentSourceType")]
        [Validation(Required=false)]
        public string PercentSourceType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}

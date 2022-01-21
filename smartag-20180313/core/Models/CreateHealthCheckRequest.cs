// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateHealthCheckRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DstIpAddr")]
        [Validation(Required=false)]
        public string DstIpAddr { get; set; }

        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        [NameInMap("FailCountThreshold")]
        [Validation(Required=false)]
        public int? FailCountThreshold { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProbeCount")]
        [Validation(Required=false)]
        public int? ProbeCount { get; set; }

        [NameInMap("ProbeInterval")]
        [Validation(Required=false)]
        public int? ProbeInterval { get; set; }

        [NameInMap("ProbeTimeout")]
        [Validation(Required=false)]
        public int? ProbeTimeout { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RttFailThreshold")]
        [Validation(Required=false)]
        public int? RttFailThreshold { get; set; }

        [NameInMap("RttThreshold")]
        [Validation(Required=false)]
        public int? RttThreshold { get; set; }

        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        [NameInMap("SrcIpAddr")]
        [Validation(Required=false)]
        public string SrcIpAddr { get; set; }

        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

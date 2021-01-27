// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateIpSetsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateIpSetsRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateIpSetsRequestAccelerateRegion : TeaModel {
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

        }

    }

}

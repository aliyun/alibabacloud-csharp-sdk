// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ReplaceBandwidthPackageRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        [NameInMap("TargetBandwidthPackageId")]
        [Validation(Required=false)]
        public string TargetBandwidthPackageId { get; set; }

    }

}

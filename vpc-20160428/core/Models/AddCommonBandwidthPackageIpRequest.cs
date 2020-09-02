// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddCommonBandwidthPackageIpRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("BandwidthPackageId")]
        [Validation(Required=true)]
        public string BandwidthPackageId { get; set; }

        [NameInMap("IpInstanceId")]
        [Validation(Required=true)]
        public string IpInstanceId { get; set; }

        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

    }

}

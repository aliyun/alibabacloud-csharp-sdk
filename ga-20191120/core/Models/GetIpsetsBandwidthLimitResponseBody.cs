// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetIpsetsBandwidthLimitResponseBody : TeaModel {
        [NameInMap("BandwidthAllocationType")]
        [Validation(Required=false)]
        public string BandwidthAllocationType { get; set; }

        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public long? BandwidthLimit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

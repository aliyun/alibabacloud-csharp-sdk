// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        [NameInMap("IntranetBandwidth")]
        [Validation(Required=false)]
        public int? IntranetBandwidth { get; set; }

        [NameInMap("BandwidthExpireTime")]
        [Validation(Required=false)]
        public string BandwidthExpireTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

    }

}

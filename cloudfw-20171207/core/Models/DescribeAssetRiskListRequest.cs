// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetRiskListRequest : TeaModel {
        [NameInMap("IpAddrList")]
        [Validation(Required=false)]
        public List<string> IpAddrList { get; set; }

        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public int? IpVersion { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}

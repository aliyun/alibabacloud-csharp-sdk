// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoRequest : TeaModel {
        [NameInMap("AssetIP")]
        [Validation(Required=false)]
        public string AssetIP { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("TrafficTime")]
        [Validation(Required=false)]
        public string TrafficTime { get; set; }

    }

}

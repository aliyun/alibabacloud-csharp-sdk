// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRegionBlockResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeNetworkRegionBlockResponseBodyConfig Config { get; set; }
        public class DescribeNetworkRegionBlockResponseBodyConfig : TeaModel {
            [NameInMap("RegionBlockSwitch")]
            [Validation(Required=false)]
            public string RegionBlockSwitch { get; set; }
            [NameInMap("Provinces")]
            [Validation(Required=false)]
            public List<string> Provinces { get; set; }
            [NameInMap("Countries")]
            [Validation(Required=false)]
            public List<string> Countries { get; set; }
        };

    }

}

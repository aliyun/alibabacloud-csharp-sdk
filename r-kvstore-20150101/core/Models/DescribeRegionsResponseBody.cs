// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeRegionsResponseBodyRegionIds : TeaModel {
            [NameInMap("KVStoreRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionIdsKVStoreRegion> KVStoreRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionIdsKVStoreRegion : TeaModel {
                public string RegionId { get; set; }
                public string ZoneIds { get; set; }
                public string LocalName { get; set; }
                public string RegionEndpoint { get; set; }
                public DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList ZoneIdList { get; set; }
                public class DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList : TeaModel {
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public List<string> ZoneId { get; set; }

                }
            }
        };

    }

}

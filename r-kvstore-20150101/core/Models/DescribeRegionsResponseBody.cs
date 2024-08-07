// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The **region IDs**.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeRegionsResponseBodyRegionIds : TeaModel {
            [NameInMap("KVStoreRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionIdsKVStoreRegion> KVStoreRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionIdsKVStoreRegion : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The endpoint of the region.
                /// </summary>
                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The zone IDs.
                /// </summary>
                [NameInMap("ZoneIdList")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList ZoneIdList { get; set; }
                public class DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList : TeaModel {
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public List<string> ZoneId { get; set; }

                }

                /// <summary>
                /// The IDs of the zones in the region.
                /// </summary>
                [NameInMap("ZoneIds")]
                [Validation(Required=false)]
                public string ZoneIds { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

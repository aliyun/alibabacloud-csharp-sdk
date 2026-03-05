// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeRegionsResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeRegionsResponseBodyRegionIds : TeaModel {
            [NameInMap("KVStoreRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionIdsKVStoreRegion> KVStoreRegion { get; set; }
            public class DescribeRegionsResponseBodyRegionIdsKVStoreRegion : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("RegionEndpoint")]
                [Validation(Required=false)]
                public string RegionEndpoint { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ZoneIdList")]
                [Validation(Required=false)]
                public DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList ZoneIdList { get; set; }
                public class DescribeRegionsResponseBodyRegionIdsKVStoreRegionZoneIdList : TeaModel {
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public List<string> ZoneId { get; set; }

                }

                [NameInMap("ZoneIds")]
                [Validation(Required=false)]
                public string ZoneIds { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD425AD3-CC7B-4EE2-A5CB-2F61BA73****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

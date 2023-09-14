// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionInfosResponseBody : TeaModel {
        /// <summary>
        /// A list of regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionInfosResponseBodyRegions Regions { get; set; }
        public class DescribeRegionInfosResponseBodyRegions : TeaModel {
            [NameInMap("RDSRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionInfosResponseBodyRegionsRDSRegion> RDSRegion { get; set; }
            public class DescribeRegionInfosResponseBodyRegionsRDSRegion : TeaModel {
                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

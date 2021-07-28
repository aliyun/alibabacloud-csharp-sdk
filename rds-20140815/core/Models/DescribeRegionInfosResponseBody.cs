// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRegionInfosResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeRegionInfosResponseBodyRegions Regions { get; set; }
        public class DescribeRegionInfosResponseBodyRegions : TeaModel {
            [NameInMap("RDSRegion")]
            [Validation(Required=false)]
            public List<DescribeRegionInfosResponseBodyRegionsRDSRegion> RDSRegion { get; set; }
            public class DescribeRegionInfosResponseBodyRegionsRDSRegion : TeaModel {
                public string CnLocalName { get; set; }
                public string RegionName { get; set; }
                public string Avz { get; set; }
                public string AvzStatus { get; set; }
                public string RegionEndpoint { get; set; }
                public string Category { get; set; }
                public string EnLocalName { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}

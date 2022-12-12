// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeRegionsResponseBodyRegionsZones> Zones { get; set; }
            public class DescribeRegionsResponseBodyRegionsZones : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("ResourceTypes")]
                [Validation(Required=false)]
                public List<string> ResourceTypes { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

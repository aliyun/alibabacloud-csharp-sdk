// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DescribeRegionsOutput : TeaModel {
        [NameInMap("regions")]
        [Validation(Required=false)]
        public DescribeRegionsOutputRegions Regions { get; set; }
        public class DescribeRegionsOutputRegions : TeaModel {
            [NameInMap("region")]
            [Validation(Required=false)]
            public List<DescribeRegionsOutputRegionsRegion> Region { get; set; }
            public class DescribeRegionsOutputRegionsRegion : TeaModel {
                [NameInMap("localName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}

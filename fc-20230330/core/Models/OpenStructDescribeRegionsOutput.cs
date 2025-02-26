// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OpenStructDescribeRegionsOutput : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public OpenStructDescribeRegionsOutputRegions Regions { get; set; }
        public class OpenStructDescribeRegionsOutputRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<OpenStructDescribeRegionsOutputRegionsRegion> Region { get; set; }
            public class OpenStructDescribeRegionsOutputRegionsRegion : TeaModel {
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}

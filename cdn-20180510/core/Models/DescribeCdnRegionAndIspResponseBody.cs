// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnRegionAndIspResponseBody : TeaModel {
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public DescribeCdnRegionAndIspResponseBodyIsps Isps { get; set; }
        public class DescribeCdnRegionAndIspResponseBodyIsps : TeaModel {
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public List<DescribeCdnRegionAndIspResponseBodyIspsIsp> Isp { get; set; }
            public class DescribeCdnRegionAndIspResponseBodyIspsIsp : TeaModel {
                public string NameEn { get; set; }
                public string NameZh { get; set; }
            }
        };

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeCdnRegionAndIspResponseBodyRegions Regions { get; set; }
        public class DescribeCdnRegionAndIspResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeCdnRegionAndIspResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeCdnRegionAndIspResponseBodyRegionsRegion : TeaModel {
                public string NameEn { get; set; }
                public string NameZh { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

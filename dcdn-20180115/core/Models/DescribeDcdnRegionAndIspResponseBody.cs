// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRegionAndIspResponseBody : TeaModel {
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public DescribeDcdnRegionAndIspResponseBodyIsps Isps { get; set; }
        public class DescribeDcdnRegionAndIspResponseBodyIsps : TeaModel {
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public List<DescribeDcdnRegionAndIspResponseBodyIspsIsp> Isp { get; set; }
            public class DescribeDcdnRegionAndIspResponseBodyIspsIsp : TeaModel {
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

            }

        }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeDcdnRegionAndIspResponseBodyRegions Regions { get; set; }
        public class DescribeDcdnRegionAndIspResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeDcdnRegionAndIspResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeDcdnRegionAndIspResponseBodyRegionsRegion : TeaModel {
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

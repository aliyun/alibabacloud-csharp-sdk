// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnRegionAndIspResponseBody : TeaModel {
        /// <summary>
        /// The list of ISPs.
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public DescribeCdnRegionAndIspResponseBodyIsps Isps { get; set; }
        public class DescribeCdnRegionAndIspResponseBodyIsps : TeaModel {
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public List<DescribeCdnRegionAndIspResponseBodyIspsIsp> Isp { get; set; }
            public class DescribeCdnRegionAndIspResponseBodyIspsIsp : TeaModel {
                /// <summary>
                /// The English name of the ISP.
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// The Chinese name of the ISP.
                /// </summary>
                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

            }

        }

        /// <summary>
        /// The list of regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeCdnRegionAndIspResponseBodyRegions Regions { get; set; }
        public class DescribeCdnRegionAndIspResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeCdnRegionAndIspResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeCdnRegionAndIspResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// The English name of the region.
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// The Chinese name of the region.
                /// </summary>
                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

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

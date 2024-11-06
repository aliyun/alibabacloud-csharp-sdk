// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRegionAndIspResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ISPs.</para>
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public DescribeDcdnRegionAndIspResponseBodyIsps Isps { get; set; }
        public class DescribeDcdnRegionAndIspResponseBodyIsps : TeaModel {
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public List<DescribeDcdnRegionAndIspResponseBodyIspsIsp> Isp { get; set; }
            public class DescribeDcdnRegionAndIspResponseBodyIspsIsp : TeaModel {
                /// <summary>
                /// <para>The English name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unicom</para>
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// <para>The Chinese name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>联通</para>
                /// </summary>
                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeDcdnRegionAndIspResponseBodyRegions Regions { get; set; }
        public class DescribeDcdnRegionAndIspResponseBodyRegions : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public List<DescribeDcdnRegionAndIspResponseBodyRegionsRegion> Region { get; set; }
            public class DescribeDcdnRegionAndIspResponseBodyRegionsRegion : TeaModel {
                /// <summary>
                /// <para>The English name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liaoning</para>
                /// </summary>
                [NameInMap("NameEn")]
                [Validation(Required=false)]
                public string NameEn { get; set; }

                /// <summary>
                /// <para>The Chinese name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>辽宁省</para>
                /// </summary>
                [NameInMap("NameZh")]
                [Validation(Required=false)]
                public string NameZh { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2387C335-932C-4E1E-862C-1C4363B6DE72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

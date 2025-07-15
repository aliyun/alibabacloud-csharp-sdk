// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePrivateLineAreasResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the regions.</para>
        /// </summary>
        [NameInMap("LiveAreasList")]
        [Validation(Required=false)]
        public DescribeLivePrivateLineAreasResponseBodyLiveAreasList LiveAreasList { get; set; }
        public class DescribeLivePrivateLineAreasResponseBodyLiveAreasList : TeaModel {
            [NameInMap("LiveArea")]
            [Validation(Required=false)]
            public List<DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveArea> LiveArea { get; set; }
            public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveArea : TeaModel {
                /// <summary>
                /// <para>The region type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>domestic: in the Chinese mainland</description></item>
                /// <item><description>overseas: outside the Chinese mainland</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>domestic</para>
                /// </summary>
                [NameInMap("RegionType")]
                [Validation(Required=false)]
                public string RegionType { get; set; }

                /// <summary>
                /// <para>The regions.</para>
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegions Regions { get; set; }
                public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegions : TeaModel {
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public List<DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegionsRegion> Region { get; set; }
                    public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegionsRegion : TeaModel {
                        /// <summary>
                        /// <para>The region name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shenzhen</para>
                        /// </summary>
                        [NameInMap("LocalName")]
                        [Validation(Required=false)]
                        public string LocalName { get; set; }

                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-shenzhen</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4865B85-664B-19D3-BB16-C62FB83C8226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

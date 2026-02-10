// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePrivateLineAreasResponseBody : TeaModel {
        [NameInMap("LiveAreasList")]
        [Validation(Required=false)]
        public DescribeLivePrivateLineAreasResponseBodyLiveAreasList LiveAreasList { get; set; }
        public class DescribeLivePrivateLineAreasResponseBodyLiveAreasList : TeaModel {
            [NameInMap("LiveArea")]
            [Validation(Required=false)]
            public List<DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveArea> LiveArea { get; set; }
            public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveArea : TeaModel {
                [NameInMap("RegionType")]
                [Validation(Required=false)]
                public string RegionType { get; set; }

                [NameInMap("Regions")]
                [Validation(Required=false)]
                public DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegions Regions { get; set; }
                public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegions : TeaModel {
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public List<DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegionsRegion> Region { get; set; }
                    public class DescribeLivePrivateLineAreasResponseBodyLiveAreasListLiveAreaRegionsRegion : TeaModel {
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

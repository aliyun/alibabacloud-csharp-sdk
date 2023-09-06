// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListRegionsResponseBody : TeaModel {
        /// <summary>
        /// The list of regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public ListRegionsResponseBodyRegions Regions { get; set; }
        public class ListRegionsResponseBodyRegions : TeaModel {
            [NameInMap("RegionInfo")]
            [Validation(Required=false)]
            public List<ListRegionsResponseBodyRegionsRegionInfo> RegionInfo { get; set; }
            public class ListRegionsResponseBodyRegionsRegionInfo : TeaModel {
                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

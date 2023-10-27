// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableBusiRegionsResponseBody : TeaModel {
        /// <summary>
        /// The information about the regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListAvailableBusiRegionsResponseBodyRegions> Regions { get; set; }
        public class ListAvailableBusiRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// Indicates whether the region is in the Chinese mainland. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ChinaMainland")]
            [Validation(Required=false)]
            public bool? ChinaMainland { get; set; }

            /// <summary>
            /// The region name.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// Indicates whether the region is a point of presence (PoP) of Alibaba Cloud. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Pop")]
            [Validation(Required=false)]
            public bool? Pop { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

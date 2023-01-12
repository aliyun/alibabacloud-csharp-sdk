// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableBusiRegionsResponseBody : TeaModel {
        /// <summary>
        /// Information about the region.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListAvailableBusiRegionsResponseBodyRegions> Regions { get; set; }
        public class ListAvailableBusiRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// Indicates whether it is a point of presence (PoP). Valid values:
            /// 
            /// *   **true**: It is a PoP.
            /// *   **false**: It is not a PoP.
            /// </summary>
            [NameInMap("Pop")]
            [Validation(Required=false)]
            public bool? Pop { get; set; }

            /// <summary>
            /// The ID of the region.
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

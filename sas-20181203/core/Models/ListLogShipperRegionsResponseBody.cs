// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListLogShipperRegionsResponseBody : TeaModel {
        /// <summary>
        /// The regions supported by the log delivery feature.
        /// </summary>
        [NameInMap("LogShipperRegionList")]
        [Validation(Required=false)]
        public List<ListLogShipperRegionsResponseBodyLogShipperRegionList> LogShipperRegionList { get; set; }
        public class ListLogShipperRegionsResponseBodyLogShipperRegionList : TeaModel {
            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

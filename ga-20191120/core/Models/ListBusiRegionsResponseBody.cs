// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBusiRegionsResponseBody : TeaModel {
        /// <summary>
        /// The information about the acceleration regions that are supported by GA.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListBusiRegionsResponseBodyRegions> Regions { get; set; }
        public class ListBusiRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

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

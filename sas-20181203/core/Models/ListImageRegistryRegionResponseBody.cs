// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRegistryRegionResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListImageRegistryRegionResponseBodyRegions> Regions { get; set; }
        public class ListImageRegistryRegionResponseBodyRegions : TeaModel {
            /// <summary>
            /// The region ID of the image.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

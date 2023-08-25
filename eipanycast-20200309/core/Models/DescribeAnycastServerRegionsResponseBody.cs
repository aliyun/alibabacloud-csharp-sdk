// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastServerRegionsResponseBody : TeaModel {
        /// <summary>
        /// The list of regions where you can associate Anycast EIPs with backend servers.
        /// </summary>
        [NameInMap("AnycastServerRegionList")]
        [Validation(Required=false)]
        public List<DescribeAnycastServerRegionsResponseBodyAnycastServerRegionList> AnycastServerRegionList { get; set; }
        public class DescribeAnycastServerRegionsResponseBodyAnycastServerRegionList : TeaModel {
            /// <summary>
            /// The ID of the region.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

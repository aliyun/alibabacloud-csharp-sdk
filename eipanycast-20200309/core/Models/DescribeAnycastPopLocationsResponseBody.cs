// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastPopLocationsResponseBody : TeaModel {
        /// <summary>
        /// The list of access points in the specified access area.
        /// </summary>
        [NameInMap("AnycastPopLocationList")]
        [Validation(Required=false)]
        public List<DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList> AnycastPopLocationList { get; set; }
        public class DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList : TeaModel {
            /// <summary>
            /// The ID of the region where the access point is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region where the access point is deployed.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// The number of access points.
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

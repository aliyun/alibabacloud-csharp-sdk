// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRegionBlockResponseBody : TeaModel {
        /// <summary>
        /// The configuration of blocked locations.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeNetworkRegionBlockResponseBodyConfig Config { get; set; }
        public class DescribeNetworkRegionBlockResponseBodyConfig : TeaModel {
            /// <summary>
            /// An array consisting of the codes of the countries or areas from which the requests are blocked.
            /// </summary>
            [NameInMap("Countries")]
            [Validation(Required=false)]
            public List<string> Countries { get; set; }

            /// <summary>
            /// An array consisting of the codes of the administrative regions in China from which the requests are blocked.
            /// </summary>
            [NameInMap("Provinces")]
            [Validation(Required=false)]
            public List<string> Provinces { get; set; }

            /// <summary>
            /// The status of the Location Blacklist policy. Valid values:
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// </summary>
            [NameInMap("RegionBlockSwitch")]
            [Validation(Required=false)]
            public string RegionBlockSwitch { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

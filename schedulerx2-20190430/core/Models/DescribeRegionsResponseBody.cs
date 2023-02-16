// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message that is returned only if the error occurs.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The list of regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// The displayed name of the region, which varies based on the current language.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The endpoint of the region.
            /// </summary>
            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

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

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   **true**: The call is successful.
        /// *   **false**: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

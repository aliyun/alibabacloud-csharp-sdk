// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterVulStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistics of the vulnerabilities.
        /// </summary>
        [NameInMap("VulStat")]
        [Validation(Required=false)]
        public DescribeClusterVulStatisticsResponseBodyVulStat VulStat { get; set; }
        public class DescribeClusterVulStatisticsResponseBodyVulStat : TeaModel {
            /// <summary>
            /// The number of high-risk vulnerabilities.
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public string AsapCount { get; set; }

            /// <summary>
            /// The number of medium-risk vulnerabilities.
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public string LaterCount { get; set; }

            /// <summary>
            /// The number of low-risk vulnerabilities.
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public string NntfCount { get; set; }

        }

    }

}

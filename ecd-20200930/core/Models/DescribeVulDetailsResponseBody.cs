// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeVulDetailsResponseBody : TeaModel {
        /// <summary>
        /// Details about the vulnerability.
        /// </summary>
        [NameInMap("Cves")]
        [Validation(Required=false)]
        public List<DescribeVulDetailsResponseBodyCves> Cves { get; set; }
        public class DescribeVulDetailsResponseBodyCves : TeaModel {
            /// <summary>
            /// The ID of the vulnerability.
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// The Common Vulnerability Scoring System (CVSS) score of the vulnerability, which indicates the severity of the vulnerability. A larger value indicates a higher severity. Valid values: 0 to 10.
            /// </summary>
            [NameInMap("CvssScore")]
            [Validation(Required=false)]
            public string CvssScore { get; set; }

            /// <summary>
            /// The description of the vulnerability.
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// The name of the vulnerability.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

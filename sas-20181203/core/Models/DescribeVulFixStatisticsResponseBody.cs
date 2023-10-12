// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulFixStatisticsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the statistics of vulnerability fixes by vulnerability type.
        /// </summary>
        [NameInMap("FixStat")]
        [Validation(Required=false)]
        public List<DescribeVulFixStatisticsResponseBodyFixStat> FixStat { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixStat : TeaModel {
            /// <summary>
            /// The number of vulnerabilities that are fixed on the current day.
            /// </summary>
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            /// <summary>
            /// The total number of fixed vulnerabilities.
            /// </summary>
            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            /// <summary>
            /// The number of vulnerabilities that are being fixed.
            /// </summary>
            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            /// <summary>
            /// The number of unfixed vulnerabilities.
            /// </summary>
            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

            /// <summary>
            /// The type of the vulnerability. Valid values:
            /// 
            /// *   **cve**: Linux software vulnerability
            /// *   **sys**: Windows system vulnerability
            /// *   **cms**: Web-CMS vulnerability
            /// *   **app**: application vulnerability
            /// *   **emg**: urgent vulnerability
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The total statistics of vulnerability fixes.
        /// </summary>
        [NameInMap("FixTotal")]
        [Validation(Required=false)]
        public DescribeVulFixStatisticsResponseBodyFixTotal FixTotal { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixTotal : TeaModel {
            /// <summary>
            /// The number of vulnerabilities that are fixed on the current day.
            /// </summary>
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            /// <summary>
            /// The total number of fixed vulnerabilities.
            /// </summary>
            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            /// <summary>
            /// The number of vulnerabilities that are being fixed.
            /// </summary>
            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            /// <summary>
            /// The number of unfixed vulnerabilities.
            /// </summary>
            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

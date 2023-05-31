// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityStatInfoResponseBody : TeaModel {
        /// <summary>
        /// The detailed statistics of attacks.
        /// </summary>
        [NameInMap("AttackEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyAttackEvent AttackEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodyAttackEvent : TeaModel {
            /// <summary>
            /// The points in time when the number of attacks is collected in the trend chart.
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// The total number of attacks on the current day.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The numbers of attacks at all points in time.
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// The detailed statistics of baseline risk items.
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyHealthCheck HealthCheck { get; set; }
        public class DescribeSecurityStatInfoResponseBodyHealthCheck : TeaModel {
            /// <summary>
            /// The points in time when data of baseline risk items is collected in the trend chart.
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// The number of baseline risk items that have the high-risk level on the current day.
            /// </summary>
            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public int? HighCount { get; set; }

            /// <summary>
            /// The numbers of baseline risk items that have the high-risk level at all points in time.
            /// </summary>
            [NameInMap("HighList")]
            [Validation(Required=false)]
            public List<string> HighList { get; set; }

            /// <summary>
            /// The risk levels of baseline risk items.
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// The number of baseline risk items that have the low-risk level on the current day.
            /// </summary>
            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public int? LowCount { get; set; }

            /// <summary>
            /// The numbers of baseline risk items that have the low-risk level at all points in time.
            /// </summary>
            [NameInMap("LowList")]
            [Validation(Required=false)]
            public List<string> LowList { get; set; }

            /// <summary>
            /// The number of baseline risk items that have the medium-risk level on the current day.
            /// </summary>
            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public int? MediumCount { get; set; }

            /// <summary>
            /// The numbers of baseline risk items that have the medium-risk level at all points in time.
            /// </summary>
            [NameInMap("MediumList")]
            [Validation(Required=false)]
            public List<string> MediumList { get; set; }

            /// <summary>
            /// The time periods during which data of baseline risk items is collected.
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// The total number of baseline risk items on the current day.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The total number of baseline risk items at all points in time.
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed statistics of unhandled alerts.
        /// </summary>
        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodySecurityEvent SecurityEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodySecurityEvent : TeaModel {
            /// <summary>
            /// The points in time when data of unhandled alerts is collected in the trend chart.
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// The risk levels of unhandled alerts.
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// The number of **remind** alerts on the current day.
            /// </summary>
            [NameInMap("RemindCount")]
            [Validation(Required=false)]
            public int? RemindCount { get; set; }

            /// <summary>
            /// The numbers of remind alerts at all points in time.
            /// </summary>
            [NameInMap("RemindList")]
            [Validation(Required=false)]
            public List<string> RemindList { get; set; }

            /// <summary>
            /// The number of **serious** alerts on the current day.
            /// </summary>
            [NameInMap("SeriousCount")]
            [Validation(Required=false)]
            public int? SeriousCount { get; set; }

            /// <summary>
            /// The numbers of serious alerts at all points in time.
            /// </summary>
            [NameInMap("SeriousList")]
            [Validation(Required=false)]
            public List<string> SeriousList { get; set; }

            /// <summary>
            /// The number of **suspicious** alerts on the current day.
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// The numbers of suspicious alerts at all points in time.
            /// </summary>
            [NameInMap("SuspiciousList")]
            [Validation(Required=false)]
            public List<string> SuspiciousList { get; set; }

            /// <summary>
            /// The time periods during which data of the same alert is collected.
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// The total number of unhandled alerts on the current day.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The numbers of unhandled alerts at all points in time.
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The detailed statistics of unfixed vulnerabilities.
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyVulnerability Vulnerability { get; set; }
        public class DescribeSecurityStatInfoResponseBodyVulnerability : TeaModel {
            /// <summary>
            /// The number of **high-risk** unfixed vulnerabilities on the current day.
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// The numbers of high-risk unfixed vulnerabilities at all points in time.
            /// </summary>
            [NameInMap("AsapList")]
            [Validation(Required=false)]
            public List<string> AsapList { get; set; }

            /// <summary>
            /// The points in time when data of unfixed vulnerabilities is collected in the trend chart.
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// The number of **medium-risk** unfixed vulnerabilities on the current day.
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// The numbers of medium-risk unfixed vulnerabilities at all points in time.
            /// </summary>
            [NameInMap("LaterList")]
            [Validation(Required=false)]
            public List<string> LaterList { get; set; }

            /// <summary>
            /// The risk levels of unfixed vulnerabilities.
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// The number of **low-risk** unfixed vulnerabilities on the current day.
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// The numbers of low-risk unfixed vulnerabilities at all points in time.
            /// </summary>
            [NameInMap("NntfList")]
            [Validation(Required=false)]
            public List<string> NntfList { get; set; }

            /// <summary>
            /// The time periods during which data of unfixed vulnerabilities is collected.
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// The total number of unfixed vulnerabilities on the current day.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The numbers of unfixed vulnerabilities at all points in time.
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityStatInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of attack events.</para>
        /// </summary>
        [NameInMap("AttackEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyAttackEvent AttackEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodyAttackEvent : TeaModel {
            /// <summary>
            /// <para>The collection of statistical time points in the attack count trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The number of attacks on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1096</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The collection of attack counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>The statistics of baseline issues.</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyHealthCheck HealthCheck { get; set; }
        public class DescribeSecurityStatInfoResponseBodyHealthCheck : TeaModel {
            /// <summary>
            /// <para>The collection of statistical time points in the baseline issue trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The number of high-risk baseline issues on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public int? HighCount { get; set; }

            /// <summary>
            /// <para>The collection of high-risk baseline counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("HighList")]
            [Validation(Required=false)]
            public List<string> HighList { get; set; }

            /// <summary>
            /// <para>The collection of baseline risk levels included in the statistics.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of low-risk baseline issues on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public int? LowCount { get; set; }

            /// <summary>
            /// <para>The collection of low-risk baseline issue counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("LowList")]
            [Validation(Required=false)]
            public List<string> LowList { get; set; }

            /// <summary>
            /// <para>The number of medium-risk baseline issues on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public int? MediumCount { get; set; }

            /// <summary>
            /// <para>The collection of medium-risk baseline issue counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("MediumList")]
            [Validation(Required=false)]
            public List<string> MediumList { get; set; }

            /// <summary>
            /// <para>The collection of statistical time periods for baselines.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The total number of baseline issues on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The collection of total baseline counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3E61730-85E2-4789-8017-B9B1B70F0568</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics of pending security alerts.</para>
        /// </summary>
        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodySecurityEvent SecurityEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodySecurityEvent : TeaModel {
            /// <summary>
            /// <para>The collection of statistical time points in the pending alert trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The collection of alert severity levels included in the statistics for pending alerts.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of alerts with the <b>Reminder</b> severity level detected on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemindCount")]
            [Validation(Required=false)]
            public int? RemindCount { get; set; }

            /// <summary>
            /// <para>The collection of Reminder-level alert counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("RemindList")]
            [Validation(Required=false)]
            public List<string> RemindList { get; set; }

            /// <summary>
            /// <para>The number of alerts with the <b>Urgent</b> severity level on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("SeriousCount")]
            [Validation(Required=false)]
            public int? SeriousCount { get; set; }

            /// <summary>
            /// <para>The collection of Urgent-level alert counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("SeriousList")]
            [Validation(Required=false)]
            public List<string> SeriousList { get; set; }

            /// <summary>
            /// <para>The number of alerts with the <b>Suspicious</b> severity level on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>148</para>
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// <para>The collection of Suspicious-level alert counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("SuspiciousList")]
            [Validation(Required=false)]
            public List<string> SuspiciousList { get; set; }

            /// <summary>
            /// <para>The collection of statistical time periods for alerts.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The total number of pending alerts on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>552</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The collection of pending alert counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the query is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The statistics information of unfixed vulnerabilities.</para>
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyVulnerability Vulnerability { get; set; }
        public class DescribeSecurityStatInfoResponseBodyVulnerability : TeaModel {
            /// <summary>
            /// <para>The number of unfixed vulnerabilities with <b>high</b> priority on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>109</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>The collection of high-priority unfixed vulnerability counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("AsapList")]
            [Validation(Required=false)]
            public List<string> AsapList { get; set; }

            /// <summary>
            /// <para>The collection of statistical time points in the unfixed vulnerability trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities with <b>medium</b> priority on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>275</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>The collection of medium-priority unfixed vulnerability counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("LaterList")]
            [Validation(Required=false)]
            public List<string> LaterList { get; set; }

            /// <summary>
            /// <para>The collection of vulnerability priority levels included in the statistics for unfixed vulnerabilities.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities with <b>low</b> priority on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>The collection of low-priority unfixed vulnerability counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("NntfList")]
            [Validation(Required=false)]
            public List<string> NntfList { get; set; }

            /// <summary>
            /// <para>The collection of statistical time periods for unfixed vulnerabilities.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The number of unfixed vulnerabilities on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>384</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The collection of unfixed vulnerability counts at each statistical time point.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

    }

}

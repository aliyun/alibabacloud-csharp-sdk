// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSecurityStatInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed statistics of attacks.</para>
        /// </summary>
        [NameInMap("AttackEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyAttackEvent AttackEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodyAttackEvent : TeaModel {
            /// <summary>
            /// <para>The points in time when the number of attacks is collected in the trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The total number of attacks on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1096</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The numbers of attacks at all points in time.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>The detailed statistics of baseline risk items.</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyHealthCheck HealthCheck { get; set; }
        public class DescribeSecurityStatInfoResponseBodyHealthCheck : TeaModel {
            /// <summary>
            /// <para>The points in time when data of baseline risk items is collected in the trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The number of baseline risk items that have the high-risk level on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public int? HighCount { get; set; }

            /// <summary>
            /// <para>The numbers of baseline risk items that have the high-risk level at all points in time.</para>
            /// </summary>
            [NameInMap("HighList")]
            [Validation(Required=false)]
            public List<string> HighList { get; set; }

            /// <summary>
            /// <para>The risk levels of baseline risk items.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of baseline risk items that have the low-risk level on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public int? LowCount { get; set; }

            /// <summary>
            /// <para>The numbers of baseline risk items that have the low-risk level at all points in time.</para>
            /// </summary>
            [NameInMap("LowList")]
            [Validation(Required=false)]
            public List<string> LowList { get; set; }

            /// <summary>
            /// <para>The number of baseline risk items that have the medium-risk level on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public int? MediumCount { get; set; }

            /// <summary>
            /// <para>The numbers of baseline risk items that have the medium-risk level at all points in time.</para>
            /// </summary>
            [NameInMap("MediumList")]
            [Validation(Required=false)]
            public List<string> MediumList { get; set; }

            /// <summary>
            /// <para>The time periods during which data of baseline risk items is collected.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The total number of baseline risk items on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of baseline risk items at all points in time.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3E61730-85E2-4789-8017-B9B1B70F0568</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed statistics of unhandled alerts.</para>
        /// </summary>
        [NameInMap("SecurityEvent")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodySecurityEvent SecurityEvent { get; set; }
        public class DescribeSecurityStatInfoResponseBodySecurityEvent : TeaModel {
            /// <summary>
            /// <para>The points in time when data of unhandled alerts is collected in the trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The risk levels of unhandled alerts.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of <b>remind</b> alerts on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemindCount")]
            [Validation(Required=false)]
            public int? RemindCount { get; set; }

            /// <summary>
            /// <para>The numbers of remind alerts at all points in time.</para>
            /// </summary>
            [NameInMap("RemindList")]
            [Validation(Required=false)]
            public List<string> RemindList { get; set; }

            /// <summary>
            /// <para>The number of <b>serious</b> alerts on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("SeriousCount")]
            [Validation(Required=false)]
            public int? SeriousCount { get; set; }

            /// <summary>
            /// <para>The numbers of serious alerts at all points in time.</para>
            /// </summary>
            [NameInMap("SeriousList")]
            [Validation(Required=false)]
            public List<string> SeriousList { get; set; }

            /// <summary>
            /// <para>The number of <b>suspicious</b> alerts on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>148</para>
            /// </summary>
            [NameInMap("SuspiciousCount")]
            [Validation(Required=false)]
            public int? SuspiciousCount { get; set; }

            /// <summary>
            /// <para>The numbers of suspicious alerts at all points in time.</para>
            /// </summary>
            [NameInMap("SuspiciousList")]
            [Validation(Required=false)]
            public List<string> SuspiciousList { get; set; }

            /// <summary>
            /// <para>The time periods during which data of the same alert is collected.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The total number of unhandled alerts on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>552</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The numbers of unhandled alerts at all points in time.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The detailed statistics of unfixed vulnerabilities.</para>
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public DescribeSecurityStatInfoResponseBodyVulnerability Vulnerability { get; set; }
        public class DescribeSecurityStatInfoResponseBodyVulnerability : TeaModel {
            /// <summary>
            /// <para>The number of <b>high-risk</b> unfixed vulnerabilities on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>109</para>
            /// </summary>
            [NameInMap("AsapCount")]
            [Validation(Required=false)]
            public int? AsapCount { get; set; }

            /// <summary>
            /// <para>The numbers of high-risk unfixed vulnerabilities at all points in time.</para>
            /// </summary>
            [NameInMap("AsapList")]
            [Validation(Required=false)]
            public List<string> AsapList { get; set; }

            /// <summary>
            /// <para>The points in time when data of unfixed vulnerabilities is collected in the trend chart.</para>
            /// </summary>
            [NameInMap("DateArray")]
            [Validation(Required=false)]
            public List<string> DateArray { get; set; }

            /// <summary>
            /// <para>The number of <b>medium-risk</b> unfixed vulnerabilities on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>275</para>
            /// </summary>
            [NameInMap("LaterCount")]
            [Validation(Required=false)]
            public int? LaterCount { get; set; }

            /// <summary>
            /// <para>The numbers of medium-risk unfixed vulnerabilities at all points in time.</para>
            /// </summary>
            [NameInMap("LaterList")]
            [Validation(Required=false)]
            public List<string> LaterList { get; set; }

            /// <summary>
            /// <para>The risk levels of unfixed vulnerabilities.</para>
            /// </summary>
            [NameInMap("LevelsOn")]
            [Validation(Required=false)]
            public List<string> LevelsOn { get; set; }

            /// <summary>
            /// <para>The number of <b>low-risk</b> unfixed vulnerabilities on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NntfCount")]
            [Validation(Required=false)]
            public int? NntfCount { get; set; }

            /// <summary>
            /// <para>The numbers of low-risk unfixed vulnerabilities at all points in time.</para>
            /// </summary>
            [NameInMap("NntfList")]
            [Validation(Required=false)]
            public List<string> NntfList { get; set; }

            /// <summary>
            /// <para>The time periods during which data of unfixed vulnerabilities is collected.</para>
            /// </summary>
            [NameInMap("TimeArray")]
            [Validation(Required=false)]
            public List<string> TimeArray { get; set; }

            /// <summary>
            /// <para>The total number of unfixed vulnerabilities on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>384</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The numbers of unfixed vulnerabilities at all points in time.</para>
            /// </summary>
            [NameInMap("ValueArray")]
            [Validation(Required=false)]
            public List<string> ValueArray { get; set; }

        }

    }

}

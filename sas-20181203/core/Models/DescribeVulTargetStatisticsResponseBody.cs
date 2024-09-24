// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6BA51E212F80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the configurations of the vulnerability scan feature.</para>
        /// </summary>
        [NameInMap("TargetStats")]
        [Validation(Required=false)]
        public List<DescribeVulTargetStatisticsResponseBodyTargetStats> TargetStats { get; set; }
        public class DescribeVulTargetStatisticsResponseBodyTargetStats : TeaModel {
            /// <summary>
            /// <para>An array that consists of available servers.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeVulTargetStatisticsResponseBodyTargetStatsTargets> Targets { get; set; }
            public class DescribeVulTargetStatisticsResponseBodyTargetStatsTargets : TeaModel {
                /// <summary>
                /// <para>Indicates whether the configurations are applied to the server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>add</b>: yes</description></item>
                /// <item><description><b>del</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// <para>The group ID or UUID of the server to which the configurations are applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0011ea53-738c-4bff-93be-ce6a1cc9****</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The condition by which the configurations are applied to the server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b>: the UUID of the server</description></item>
                /// <item><description><b>groupId</b>: the ID of the server group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>uuid</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The total number of servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The number of servers to which the configurations are applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cve: Linux software vulnerabilities</description></item>
            /// <item><description>sys: Windows system vulnerabilities</description></item>
            /// <item><description>cms: Web-CMS vulnerabilities</description></item>
            /// <item><description>emg: urgent vulnerabilities</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("VulType")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

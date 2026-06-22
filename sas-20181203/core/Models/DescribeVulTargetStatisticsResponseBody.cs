// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page when paging is used in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page when paging is used in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6BA51E212F80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics of vulnerability configurations.</para>
        /// </summary>
        [NameInMap("TargetStats")]
        [Validation(Required=false)]
        public List<DescribeVulTargetStatisticsResponseBodyTargetStats> TargetStats { get; set; }
        public class DescribeVulTargetStatisticsResponseBodyTargetStats : TeaModel {
            /// <summary>
            /// <para>The list of target servers for the assets.</para>
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeVulTargetStatisticsResponseBodyTargetStatsTargets> Targets { get; set; }
            public class DescribeVulTargetStatisticsResponseBodyTargetStatsTargets : TeaModel {
                /// <summary>
                /// <para>The type of configuration effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>add</b>: The configuration takes effect on the server.</description></item>
                /// <item><description><b>del</b>: The configuration does not take effect on the server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>add</para>
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// <para>The group ID or UUID of the asset on which the configuration takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0011ea53-738c-4bff-93be-ce6a1cc9****</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The target type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b>: asset.</description></item>
                /// <item><description><b>groupId</b>: server group.</description></item>
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
            /// <para>The total number of assets returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The number of servers on which the configuration takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

            /// <summary>
            /// <para>The type of vulnerability to query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cve: Linux software vulnerability</description></item>
            /// <item><description>sys: Windows system vulnerability</description></item>
            /// <item><description>cms: Web-CMS vulnerability</description></item>
            /// <item><description>emg: emergency vulnerability.</description></item>
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

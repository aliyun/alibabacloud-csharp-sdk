// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The alert aggregation method. Valid values vary by metric:</para>
        /// <list type="bullet">
        /// <item><description>Value: The value of the HTTP status code.</description></item>
        /// <item><description>Average: The average HTTP wait time.</description></item>
        /// <item><description>Value: The value of the Telnet status code.</description></item>
        /// <item><description>TelnetLatency: The average Telnet wait time.</description></item>
        /// <item><description>Average: The average ping packet loss rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Average</para>
        /// </summary>
        [NameInMap("Aggregate")]
        [Validation(Required=false)]
        public bool? Aggregate { get; set; }

        /// <summary>
        /// <para>The anchor branch ID. If you do not specify this parameter, the main branch of the project is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-7g8h9i0j1k2l</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-15T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-3m4n5o6p7q8r</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The granularity of performance data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5</description></item>
        /// <item><description>30</description></item>
        /// <item><description>60</description></item>
        /// <item><description>600</description></item>
        /// <item><description>1800</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics to query. Separate multiple values with commas (,).
        /// Note
        /// You can specify up to 5 performance metrics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDBCPUForPCU,PolarDBPCU,PolarDBMemoryForPCU,PolarDBQPSTPS,PolarDBConnections</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

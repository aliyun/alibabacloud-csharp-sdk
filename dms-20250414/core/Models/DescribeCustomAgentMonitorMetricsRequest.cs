// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeCustomAgentMonitorMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The custom agent ID.</para>
        /// <list type="bullet">
        /// <item><description>Required only when QueryType is set to CustomAgent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ca-a9fd******0lnq4g6c</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <para>The end time of the statistical period (epoch millis).</para>
        /// <list type="bullet">
        /// <item><description>Note: The maximum time range is 3 months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1756742400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The aggregation granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DAY: daily. The maximum supported time range is 3 months.</description></item>
        /// <item><description>HOUR: hourly. The maximum supported time range is 72 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The statistical scope. Default value: All. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: default DataAgent sessions.</description></item>
        /// <item><description>CustomAgent: specified custom agent sessions.</description></item>
        /// <item><description>All: all sessions in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start time of the statistical period (epoch millis).</para>
        /// <list type="bullet">
        /// <item><description>Note: The maximum time range is 3 months.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1756656000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99fad******qg6c0l4nlacu</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

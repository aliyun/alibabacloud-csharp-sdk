// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DescribeDataAgentMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query range.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782836200000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The metric names. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_agent_session_per_user</para>
        /// </summary>
        [NameInMap("MetricNames")]
        [Validation(Required=false)]
        public string MetricNames { get; set; }

        /// <summary>
        /// <para>The metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basic</b>: basic metrics.</description></item>
        /// <item><description><b>high_level</b>: advanced metrics.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The start time of the query range.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782835200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

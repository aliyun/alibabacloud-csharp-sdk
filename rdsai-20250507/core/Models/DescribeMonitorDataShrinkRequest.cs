// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMonitorDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The API key name.</para>
        /// </summary>
        [NameInMap("ApiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyNameShrink { get; set; }

        /// <summary>
        /// <para>The end time. Format: Timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627269085</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The statistical period. Default value: 15s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The metric to query.</para>
        /// <list type="bullet">
        /// <item><description><para>pv</para>
        /// </description></item>
        /// <item><description><para>uv</para>
        /// </description></item>
        /// <item><description><para>qps</para>
        /// </description></item>
        /// <item><description><para>success_rate</para>
        /// </description></item>
        /// <item><description><para>rt</para>
        /// </description></item>
        /// <item><description><para>rate_limited_count</para>
        /// </description></item>
        /// <item><description><para>tpm</para>
        /// </description></item>
        /// <item><description><para>cache</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>● pv</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The start time. Format: Timestamp.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268185</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}

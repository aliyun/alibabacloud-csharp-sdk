// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The names of the API keys to use for filtering the data. If this parameter is not specified, data from all keys is returned.</para>
        /// </summary>
        [NameInMap("ApiKeyName")]
        [Validation(Required=false)]
        public List<string> ApiKeyName { get; set; }

        /// <summary>
        /// <para>The end of the query time range, specified as a Unix timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627269085</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The aggregation interval for monitoring data, in seconds. Default: 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The metric to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>pv</c></para>
        /// </description></item>
        /// <item><description><para><c>uv</c></para>
        /// </description></item>
        /// <item><description><para><c>qps</c></para>
        /// </description></item>
        /// <item><description><para><c>success_rate</c></para>
        /// </description></item>
        /// <item><description><para><c>rt</c></para>
        /// </description></item>
        /// <item><description><para><c>rate_limited_count</c></para>
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
        /// <para>The start of the query time range, specified as a Unix timestamp in seconds.</para>
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

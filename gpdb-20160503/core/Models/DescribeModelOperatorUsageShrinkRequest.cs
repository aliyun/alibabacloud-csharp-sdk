// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelOperatorUsageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of API key IDs. Separate multiple IDs with commas (,). If this parameter is not specified, all API key IDs under the instance ID are used by default.</para>
        /// <remarks>
        /// <para>A maximum of 50 items can be included in the list.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ApiKeyIds")]
        [Validation(Required=false)]
        public string ApiKeyIdsShrink { get; set; }

        /// <summary>
        /// <para>The end time of the query. The format is <i>YYYY-MM-DDThh:mmZ</i> (UTC time).</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the interval between the start time and the end time cannot exceed 7 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-02T00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The dimension for splitting series. Separate multiple dimensions with commas (,). The order does not matter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>model (default): Splits by model.</description></item>
        /// <item><description>api_key: Splits by API key.</description></item>
        /// <item><description>model,api_key: Splits by model and API key.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>The list of metrics. Separate multiple metrics with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>request_count: The number of requests.</description></item>
        /// <item><description>success_count: The number of successful requests.</description></item>
        /// <item><description>error_count: The number of failed requests.</description></item>
        /// <item><description>success_rate: The request success rate.</description></item>
        /// <item><description>input_token: The number of input tokens.</description></item>
        /// <item><description>output_token: The number of output tokens.</description></item>
        /// <item><description>total_token: The total number of tokens.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string KeysShrink { get; set; }

        /// <summary>
        /// <para>The list of model names. Separate multiple names with commas (,).</para>
        /// </summary>
        [NameInMap("ModelNames")]
        [Validation(Required=false)]
        public string ModelNamesShrink { get; set; }

        /// <summary>
        /// <para>The time bucket size in seconds. Valid values: 1, 5, 15, 60, 300, and 3600.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><ol>
        /// <item><description>If Period is not specified, the default value is selected based on the following rules:</description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the time window is less than or equal to 1 hour, Period is set to 1.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the time window is less than or equal to 1 day, Period is set to 60.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>If the time window is less than or equal to 7 days, Period is set to 60.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><ol start="2">
        /// <item><description>If Period is set to 1, the time window must be less than or equal to 1 day.</description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The start time of the query. The format is <i>YYYY-MM-DDThh:mmZ</i> (UTC time).</para>
        /// <remarks>
        /// <para>You can query only metrics from the last 30 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

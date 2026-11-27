// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListLLMGatewayMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The end time for the metric query in ISO 8601 format. The time must be later than StartTime and is aligned to the minute. The maximum query range is 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-26T20:55:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity. Default value: minute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The name of the Supabase instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-7kox9010itfcn1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The metric type. The match is case-insensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tokenPerMinute: tokens per minute</description></item>
        /// <item><description>requestPerMinute: requests per minute</description></item>
        /// <item><description>errorRequestPerMinute: error requests per minute</description></item>
        /// <item><description>timeToFirstToken: time to first token percentiles</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tokenPerMinute</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The model filter condition. Separate multiple model names with commas. If this parameter is not specified, data for all models is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus,deepseek-v4-pro</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time for the metric query in ISO 8601 format. The time is aligned to the minute. The maximum query range between StartTime and EndTime is 7 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-26T20:40:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

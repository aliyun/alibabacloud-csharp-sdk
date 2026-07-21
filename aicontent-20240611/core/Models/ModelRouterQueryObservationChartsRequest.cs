// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryObservationChartsRequest : TeaModel {
        /// <summary>
        /// <para>The API key ID to use as a filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The client ID to use as a filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The end time of the custom time range, in ISO 8601 UTC format. If specified, <c>startTime</c> must also be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The model ID to use as a filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The start time of the custom time range, in ISO 8601 UTC format. If specified, <c>endTime</c> must also be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time range for the query. Valid values are <c>1h</c>, <c>6h</c>, <c>24h</c>, <c>7d</c>, and <c>30d</c>. This parameter is mutually exclusive with <c>startTime</c> and <c>endTime</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24h</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}

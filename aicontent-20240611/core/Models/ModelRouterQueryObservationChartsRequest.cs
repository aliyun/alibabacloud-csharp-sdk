// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryObservationChartsRequest : TeaModel {
        /// <summary>
        /// <para>The API key ID used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The client ID used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The list of department IDs, separated by commas. Supports querying data for multiple departments. This parameter is mutually exclusive with clientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("clientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The custom end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Optional. Filters by member IDs, separated by commas. If not specified, the department and all its members are included. If an empty value is specified, only the department is included without members.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001,30002</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public string MemberUserIds { get; set; }

        /// <summary>
        /// <para>The model ID used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The custom start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The time range. Valid values: 1h, 6h, 24h, 7d, 30d.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24h</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}

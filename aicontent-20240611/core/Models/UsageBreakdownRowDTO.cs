// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class UsageBreakdownRowDTO : TeaModel {
        /// <summary>
        /// <para>The API key ID. A value of 0 indicates that historical data is not broken down by API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <para>The API key name, corresponding to api_key_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default key</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The department ID. A value of 0 indicates no affiliated department.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>The department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Department</para>
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <para>The member ID for a member row. The value is 0 for a department row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001</para>
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public long? MemberUserId { get; set; }

        /// <summary>
        /// <para>The member name for a member row. The value is empty for a department row.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John Smith</para>
        /// </summary>
        [NameInMap("memberUserName")]
        [Validation(Required=false)]
        public string MemberUserName { get; set; }

        /// <summary>
        /// <para>The usage metric array. Only entries with non-zero values are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;: &quot;total_calls&quot;, &quot;value&quot;: 100}]</para>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public List<MetricKVPairDTO> Metrics { get; set; }

        /// <summary>
        /// <para>The model identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>The model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen-Plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The statistical dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The statistical time point, in UNIX timestamp (seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("summaryTime")]
        [Validation(Required=false)]
        public long? SummaryTime { get; set; }

    }

}

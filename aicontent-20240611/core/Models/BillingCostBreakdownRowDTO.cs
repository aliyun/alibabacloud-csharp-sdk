// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillingCostBreakdownRowDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public long? ApiKeyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认密钥</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>Billing type; currently fixed as total_amount</para>
        /// 
        /// <b>Example:</b>
        /// <para>total_amount</para>
        /// </summary>
        [NameInMap("billingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>Department ID; 0 indicates no associated department</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <para>Department name</para>
        /// 
        /// <b>Example:</b>
        /// <para>研发部</para>
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;billing_version&quot;: &quot;v1&quot;}</para>
        /// </summary>
        [NameInMap("dimValues")]
        [Validation(Required=false)]
        public string DimValues { get; set; }

        /// <summary>
        /// <para>Model identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-plus</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>Model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>Model name</para>
        /// 
        /// <b>Example:</b>
        /// <para>通义千问-Plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Statistics category</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>Payable amount, rounded to 8 decimal places</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00012800</para>
        /// </summary>
        [NameInMap("payableAmount")]
        [Validation(Required=false)]
        public float? PayableAmount { get; set; }

        /// <summary>
        /// <para>Statistics time point, Unix timestamp (seconds)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("summaryTime")]
        [Validation(Required=false)]
        public long? SummaryTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tiers")]
        [Validation(Required=false)]
        public List<BillingBillTierDTO> Tiers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;input_tokens&quot;: 512000, &quot;output_tokens&quot;: 256000}</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public string Values { get; set; }

    }

}

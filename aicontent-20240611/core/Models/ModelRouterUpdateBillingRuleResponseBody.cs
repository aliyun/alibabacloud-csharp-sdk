// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterUpdateBillingRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ModelRouterUpdateBillingRuleResponseBodyData Data { get; set; }
        public class ModelRouterUpdateBillingRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The billing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token_tiered</para>
            /// </summary>
            [NameInMap("billingType")]
            [Validation(Required=false)]
            public string BillingType { get; set; }

            /// <summary>
            /// <para>The deletion tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public int? DeleteTag { get; set; }

            /// <summary>
            /// <para>The time when the rule takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("effectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The model ID.</para>
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
            /// <para>通义千问Plus</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chat</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The billing configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("pricingConfig")]
            [Validation(Required=false)]
            public object PricingConfig { get; set; }

            /// <summary>
            /// <para>The vendor ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba</para>
            /// </summary>
            [NameInMap("symbol")]
            [Validation(Required=false)]
            public string Symbol { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

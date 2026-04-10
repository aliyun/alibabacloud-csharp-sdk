// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class ExchangeEntitlementResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ExchangeEntitlementResponseBodyData Data { get; set; }
        public class ExchangeEntitlementResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk_live_abc123xyz789</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("effectiveAt")]
            [Validation(Required=false)]
            public string EffectiveAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://llm-gateway.example.com/acme">https://llm-gateway.example.com/acme</a></para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-31T23:59:59Z</para>
            /// </summary>
            [NameInMap("expireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a1b2c3d4e5f6...</para>
            /// </summary>
            [NameInMap("keyHash")]
            [Validation(Required=false)]
            public string KeyHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORD20240101000001</para>
            /// </summary>
            [NameInMap("redemptionOrderNo")]
            [Validation(Required=false)]
            public string RedemptionOrderNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("reused")]
            [Validation(Required=false)]
            public bool? Reused { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public ExchangeEntitlementResponseBodyDataTemplate Template { get; set; }
            public class ExchangeEntitlementResponseBodyDataTemplate : TeaModel {
                [NameInMap("allowedModels")]
                [Validation(Required=false)]
                public List<string> AllowedModels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("quotaLimit")]
                [Validation(Required=false)]
                public long? QuotaLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>基础版 Token 包</para>
                /// </summary>
                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TOKEN_PACK</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("retryAble")]
        [Validation(Required=false)]
        public bool? RetryAble { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

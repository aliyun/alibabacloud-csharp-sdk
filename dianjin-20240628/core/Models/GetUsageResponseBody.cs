// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUsageResponseBodyData Data { get; set; }
        public class GetUsageResponseBodyData : TeaModel {
            [NameInMap("entitlements")]
            [Validation(Required=false)]
            public List<GetUsageResponseBodyDataEntitlements> Entitlements { get; set; }
            public class GetUsageResponseBodyDataEntitlements : TeaModel {
                [NameInMap("allowedModels")]
                [Validation(Required=false)]
                public List<string> AllowedModels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>238746</para>
                /// </summary>
                [NameInMap("bindingId")]
                [Validation(Required=false)]
                public long? BindingId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("effectiveAt")]
                [Validation(Required=false)]
                public string EffectiveAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-31T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireAt")]
                [Validation(Required=false)]
                public string ExpireAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("quotaInitial")]
                [Validation(Required=false)]
                public long? QuotaInitial { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("quotaRemaining")]
                [Validation(Required=false)]
                public long? QuotaRemaining { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("quotaUsed")]
                [Validation(Required=false)]
                public long? QuotaUsed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>893724</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

            }

            [NameInMap("modelStats")]
            [Validation(Required=false)]
            public List<GetUsageResponseBodyDataModelStats> ModelStats { get; set; }
            public class GetUsageResponseBodyDataModelStats : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("inputUsage")]
                [Validation(Required=false)]
                public long? InputUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-turbo</para>
                /// </summary>
                [NameInMap("model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("outputUsage")]
                [Validation(Required=false)]
                public long? OutputUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("requests")]
                [Validation(Required=false)]
                public long? Requests { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("totalUsage")]
                [Validation(Required=false)]
                public long? TotalUsage { get; set; }

            }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public GetUsageResponseBodyDataSummary Summary { get; set; }
            public class GetUsageResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("totalInputUsage")]
                [Validation(Required=false)]
                public long? TotalInputUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("totalOutputUsage")]
                [Validation(Required=false)]
                public long? TotalOutputUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalRequests")]
                [Validation(Required=false)]
                public long? TotalRequests { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("totalUsage")]
                [Validation(Required=false)]
                public long? TotalUsage { get; set; }

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

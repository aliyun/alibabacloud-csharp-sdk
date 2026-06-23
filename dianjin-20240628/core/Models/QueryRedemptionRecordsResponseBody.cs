// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class QueryRedemptionRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryRedemptionRecordsResponseBodyData Data { get; set; }
        public class QueryRedemptionRecordsResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryRedemptionRecordsResponseBodyDataItems> Items { get; set; }
            public class QueryRedemptionRecordsResponseBodyDataItems : TeaModel {
                [NameInMap("allowedModels")]
                [Validation(Required=false)]
                public List<string> AllowedModels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("effectiveAt")]
                [Validation(Required=false)]
                public string EffectiveAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireAt")]
                [Validation(Required=false)]
                public string ExpireAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("keyHash")]
                [Validation(Required=false)]
                public string KeyHash { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("outBizNo")]
                [Validation(Required=false)]
                public string OutBizNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("quotaBalance")]
                [Validation(Required=false)]
                public long? QuotaBalance { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("quotaStatus")]
                [Validation(Required=false)]
                public string QuotaStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("redemptionOrderNo")]
                [Validation(Required=false)]
                public string RedemptionOrderNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("retryAble")]
        [Validation(Required=false)]
        public bool? RetryAble { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

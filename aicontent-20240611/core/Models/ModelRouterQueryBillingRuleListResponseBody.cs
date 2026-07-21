// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryBillingRuleListResponseBody : TeaModel {
        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ModelRouterQueryBillingRuleListResponseBodyData Data { get; set; }
        public class ModelRouterQueryBillingRuleListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of billing rules</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ModelRouterQueryBillingRuleListResponseBodyDataList> List { get; set; }
            public class ModelRouterQueryBillingRuleListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Billing type</para>
                /// 
                /// <b>Example:</b>
                /// <para>token_tiered</para>
                /// </summary>
                [NameInMap("billingType")]
                [Validation(Required=false)]
                public string BillingType { get; set; }

                /// <summary>
                /// <para>Delete marker</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("deleteTag")]
                [Validation(Required=false)]
                public int? DeleteTag { get; set; }

                /// <summary>
                /// <para>Effective time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("effectiveTime")]
                [Validation(Required=false)]
                public string EffectiveTime { get; set; }

                /// <summary>
                /// <para>Expiration time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Rule ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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
                /// <para>通义千问Plus</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>Model type</para>
                /// 
                /// <b>Example:</b>
                /// <para>chat</para>
                /// </summary>
                [NameInMap("modelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                /// <summary>
                /// <para>Billing configuration</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("pricingConfig")]
                [Validation(Required=false)]
                public object PricingConfig { get; set; }

                /// <summary>
                /// <para>Vendor identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba</para>
                /// </summary>
                [NameInMap("symbol")]
                [Validation(Required=false)]
                public string Symbol { get; set; }

                /// <summary>
                /// <para>Version number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Number of items per page</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>maxResults</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>nextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

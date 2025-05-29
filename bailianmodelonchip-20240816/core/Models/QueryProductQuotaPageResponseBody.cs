// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class QueryProductQuotaPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryProductQuotaPageResponseBodyData Data { get; set; }
        public class QueryProductQuotaPageResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryProductQuotaPageResponseBodyDataData> Data { get; set; }
            public class QueryProductQuotaPageResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-23 02:02:03</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("durationType")]
                [Validation(Required=false)]
                public int? DurationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-05-31 00:00:00</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>67241348</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ifUnsubscribe")]
                [Validation(Required=false)]
                public int? IfUnsubscribe { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ifUsed")]
                [Validation(Required=false)]
                public int? IfUsed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("licenseCount")]
                [Validation(Required=false)]
                public long? LicenseCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("maxQps")]
                [Validation(Required=false)]
                public int? MaxQps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>g6RD6uvFYNZv44ky</para>
                /// </summary>
                [NameInMap("orderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2oImhCz4f8XCviiM</para>
                /// </summary>
                [NameInMap("productKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("purchaseModel")]
                [Validation(Required=false)]
                public int? PurchaseModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("purchaseType")]
                [Validation(Required=false)]
                public int? PurchaseType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("settlementFee")]
                [Validation(Required=false)]
                public double? SettlementFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>217037888563265</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("tokenNumber")]
                [Validation(Required=false)]
                public long? TokenNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("unitPrice")]
                [Validation(Required=false)]
                public double? UnitPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-23 02:02:03</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageIndex")]
            [Validation(Required=false)]
            public int? PageIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>151</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>32B81CD6-D583-5056-A6EB-3C1107AB26C3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

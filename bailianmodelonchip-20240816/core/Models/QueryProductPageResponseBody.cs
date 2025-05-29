// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class QueryProductPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryProductPageResponseBodyData Data { get; set; }
        public class QueryProductPageResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryProductPageResponseBodyDataData> Data { get; set; }
            public class QueryProductPageResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("activeLicenseCount")]
                [Validation(Required=false)]
                public long? ActiveLicenseCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zcrzbqrF29pkgXukLaQ+6jGsohQiPhdOuIrUSVSvNO5oDntQdM76mNXj+AJ2i7eP</para>
                /// </summary>
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-05 06:24:27</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
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
                /// <para>nnjNQQv3ZjyYE7H4</para>
                /// </summary>
                [NameInMap("productKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3dc95cac8272b86a5d10de7768d8fc41</para>
                /// </summary>
                [NameInMap("productSecret")]
                [Validation(Required=false)]
                public string ProductSecret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>383756559581697</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("tokenCount")]
                [Validation(Required=false)]
                public long? TokenCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-05 06:24:27</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("usedToken")]
                [Validation(Required=false)]
                public long? UsedToken { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>359687</para>
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
            /// <para>100</para>
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
        /// <b>Example:</b>
        /// <para>EA4643D5-5FA8-55BA-A959-F7D3E38E0AE0</para>
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

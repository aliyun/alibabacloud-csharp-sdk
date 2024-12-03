// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryProductListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about all Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProductListResponseBodyData Data { get; set; }
        public class QueryProductListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The service definitions.</para>
            /// </summary>
            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public QueryProductListResponseBodyDataProductList ProductList { get; set; }
            public class QueryProductListResponseBodyDataProductList : TeaModel {
                [NameInMap("Product")]
                [Validation(Required=false)]
                public List<QueryProductListResponseBodyDataProductListProduct> Product { get; set; }
                public class QueryProductListResponseBodyDataProductListProduct : TeaModel {
                    /// <summary>
                    /// <para>The code of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cdn</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CDN (Pay-as-you-go)</para>
                    /// </summary>
                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                    /// <summary>
                    /// <para>The type of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CDN</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <para>The billing method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Subscription: subscription</description></item>
                    /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>449</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This API is not applicable for caller.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94858229-2758-4663-A7D0-99490D541F15</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

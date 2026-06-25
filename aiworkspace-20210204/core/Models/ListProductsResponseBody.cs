// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of products.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user has permission to purchase the product.</para>
            /// </summary>
            [NameInMap("HasPermissionToPurchase")]
            [Validation(Required=false)]
            public bool? HasPermissionToPurchase { get; set; }

            /// <summary>
            /// <para>Indicates whether the product is purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPurchased")]
            [Validation(Required=false)]
            public bool? IsPurchased { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataWorks_isolate</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The purchase URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliy">https://common-buy.aliy</a></para>
            /// </summary>
            [NameInMap("PurchaseUrl")]
            [Validation(Required=false)]
            public string PurchaseUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1e195c5116124202371861018d5bde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyServices> Services { get; set; }
        public class ListProductsResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>Indicates whether the service is activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            /// <summary>
            /// <para>The activation URL.</para>
            /// </summary>
            [NameInMap("OpenUrl")]
            [Validation(Required=false)]
            public string OpenUrl { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            [NameInMap("HasPermissionToPurchase")]
            [Validation(Required=false)]
            public bool? HasPermissionToPurchase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPurchased")]
            [Validation(Required=false)]
            public bool? IsPurchased { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DataWorks_isolate</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductInstanceId")]
            [Validation(Required=false)]
            public string ProductInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliy">https://common-buy.aliy</a></para>
            /// </summary>
            [NameInMap("PurchaseUrl")]
            [Validation(Required=false)]
            public string PurchaseUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1e195c5116124202371861018d5bde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyServices> Services { get; set; }
        public class ListProductsResponseBodyServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            [NameInMap("OpenUrl")]
            [Validation(Required=false)]
            public string OpenUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

        }

    }

}

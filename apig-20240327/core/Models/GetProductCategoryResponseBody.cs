// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetProductCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProductCategoryResponseBodyData Data { get; set; }
        public class GetProductCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the product category. This ID can be used as the categoryId path parameter for GetProductCategory, UpdateProductCategory, and DeleteProductCategory, or as an element in the categories array for SetProductCategories and CreateProduct.</para>
            /// 
            /// <b>Example:</b>
            /// <para>category-xxxxxxxx</para>
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The description of the product category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product category containing AI-related capabilities</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The icon of the product category. It consists of two fields: icon type (type) and icon value (value).</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public HiMarketIcon Icon { get; set; }

            /// <summary>
            /// <para>The name of the product category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai-capabilities</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

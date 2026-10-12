// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateProductCategoryResponseBody : TeaModel {
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
        public CreateProductCategoryResponseBodyData Data { get; set; }
        public class CreateProductCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the newly created product category. It can be used as the categoryId path parameter in GetProductCategory, UpdateProductCategory, and DeleteProductCategory, or as an element in the category ID array for SetProductCategories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>category-xxxxxxxx</para>
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

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

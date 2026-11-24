// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class SubmitProductMatchRequest : TeaModel {
        /// <summary>
        /// <para>The product brand. If this parameter is not specified, the system attempts to extract the brand from the shop name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILA</para>
        /// </summary>
        [NameInMap("BrandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <para>The Miaojie product category. It is currently used for extension and auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kids Shoes</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the product main image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/items/228516909/main.jpg">https://example.com/items/228516909/main.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The Miaojie product ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>228516909</para>
        /// </summary>
        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>The HTTP or HTTPS URL of the product detail page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/items/228516909">https://example.com/items/228516909</a></para>
        /// </summary>
        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// <para>The shop name. It also serves as the extraction source when the brand name is missing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILA Official Flagship Store</para>
        /// </summary>
        [NameInMap("ShopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        /// <summary>
        /// <para>The product title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILA Kids Training Shoes</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Good : TeaModel {
        /// <summary>
        /// <para>Product name</para>
        /// 
        /// <b>Example:</b>
        /// <para>儿童学习桌</para>
        /// </summary>
        [NameInMap("goodName")]
        [Validation(Required=false)]
        public string GoodName { get; set; }

        /// <summary>
        /// <para>Product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6736</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>Quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>SKU ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>7232****2321</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>SKU title</para>
        /// 
        /// <b>Example:</b>
        /// <para>白色</para>
        /// </summary>
        [NameInMap("skuTitle")]
        [Validation(Required=false)]
        public string SkuTitle { get; set; }

    }

}

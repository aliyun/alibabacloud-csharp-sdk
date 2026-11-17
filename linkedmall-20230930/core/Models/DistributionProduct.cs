// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DistributionProduct : TeaModel {
        /// <summary>
        /// <para>The category chain name.</para>
        /// </summary>
        [NameInMap("categoryChain")]
        [Validation(Required=false)]
        public string CategoryChain { get; set; }

        /// <summary>
        /// <para>The leaf category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50016422</para>
        /// </summary>
        [NameInMap("categoryLeafId")]
        [Validation(Required=false)]
        public long? CategoryLeafId { get; set; }

        /// <summary>
        /// <para>The leaf category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例类目</para>
        /// </summary>
        [NameInMap("categoryLeafName")]
        [Validation(Required=false)]
        public string CategoryLeafName { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LM_DEMO</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <para>The distribution status.</para>
        /// </summary>
        [NameInMap("distributeStatus")]
        [Validation(Required=false)]
        public string DistributeStatus { get; set; }

        /// <summary>
        /// <para>The main image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/product.png">https://example.com/images/product.png</a></para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>660057403063402509</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The seller ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("sellerId")]
        [Validation(Required=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// <para>The short product title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例商品</para>
        /// </summary>
        [NameInMap("shortTitle")]
        [Validation(Required=false)]
        public string ShortTitle { get; set; }

        /// <summary>
        /// <para>The SKU list.</para>
        /// </summary>
        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<DistributionSku> Skus { get; set; }

        /// <summary>
        /// <para>The long product title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例商品名称</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The white background image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/product-white.png">https://example.com/images/product-white.png</a></para>
        /// </summary>
        [NameInMap("whiteBackgroundPicUrl")]
        [Validation(Required=false)]
        public string WhiteBackgroundPicUrl { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DistributionSku : TeaModel {
        /// <summary>
        /// <para>The alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例规格</para>
        /// </summary>
        [NameInMap("aliasTitle")]
        [Validation(Required=false)]
        public string AliasTitle { get; set; }

        /// <summary>
        /// <para>The barcode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6901234567892</para>
        /// </summary>
        [NameInMap("barCode")]
        [Validation(Required=false)]
        public string BarCode { get; set; }

        /// <summary>
        /// <para>The maximum acceptable credit period.</para>
        /// </summary>
        [NameInMap("creditPeriod")]
        [Validation(Required=false)]
        public int? CreditPeriod { get; set; }

        /// <summary>
        /// <para>The consignment supply price.</para>
        /// </summary>
        [NameInMap("dxPrice")]
        [Validation(Required=false)]
        public long? DxPrice { get; set; }

        /// <summary>
        /// <para>Specifies whether credit periods are supported.</para>
        /// </summary>
        [NameInMap("hasCredit")]
        [Validation(Required=false)]
        public bool? HasCredit { get; set; }

        /// <summary>
        /// <para>Specifies whether invoicing is supported.</para>
        /// </summary>
        [NameInMap("hasInvoice")]
        [Validation(Required=false)]
        public bool? HasInvoice { get; set; }

        /// <summary>
        /// <para>The distribution supply price.</para>
        /// </summary>
        [NameInMap("jxPrice")]
        [Validation(Required=false)]
        public long? JxPrice { get; set; }

        /// <summary>
        /// <para>The image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/images/product.png">https://example.com/images/product.png</a></para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <para>The inventory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>sku id</para>
        /// 
        /// <b>Example:</b>
        /// <para>660460842235822082</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// </summary>
        [NameInMap("skuStatus")]
        [Validation(Required=false)]
        public string SkuStatus { get; set; }

        /// <summary>
        /// <para>The tax code.</para>
        /// </summary>
        [NameInMap("taxCode")]
        [Validation(Required=false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// <para>The tax rate.</para>
        /// </summary>
        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public int? TaxRate { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例商品名称</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}

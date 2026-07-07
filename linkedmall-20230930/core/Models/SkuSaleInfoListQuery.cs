// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SkuSaleInfoListQuery : TeaModel {
        /// <summary>
        /// <para>Region code. Use a five-level administrative division code, such as a town or subdistrict code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106109</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>Product query parameters</para>
        /// <remarks>
        /// <para>You can query up to 20 SKUs per request.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("skuQueryParams")]
        [Validation(Required=false)]
        public List<SkuQueryParam> SkuQueryParams { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSaleInfoQuery : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22000009</para>
        /// </summary>
        [NameInMap("distributorShopId")]
        [Validation(Required=false)]
        public string DistributorShopId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

    }

}

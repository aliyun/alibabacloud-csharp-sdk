// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SelectionGroupAddProductRequest : TeaModel {
        /// <summary>
        /// <para>Collection of product IDs to add</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can add up to 30 products per call.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productIds")]
        [Validation(Required=false)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PIDxxxxx</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

    }

}

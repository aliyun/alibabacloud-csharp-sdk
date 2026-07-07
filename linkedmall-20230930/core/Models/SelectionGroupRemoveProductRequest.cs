// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SelectionGroupRemoveProductRequest : TeaModel {
        /// <summary>
        /// <para>A list of IDs for the products to be removed from stock.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>A single call supports a maximum of 30 products.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productIds")]
        [Validation(Required=false)]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// <para>The ID of the purchaser.</para>
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

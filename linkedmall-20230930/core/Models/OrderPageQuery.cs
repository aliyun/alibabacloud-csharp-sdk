// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderPageQuery : TeaModel {
        /// <summary>
        /// <para>The collection of primary order IDs.</para>
        /// </summary>
        [NameInMap("orderIdList")]
        [Validation(Required=false)]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// <para>The external purchase order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****56121</para>
        /// </summary>
        [NameInMap("outPurchaseOrderId")]
        [Validation(Required=false)]
        public string OutPurchaseOrderId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The purchase order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5696</para>
        /// </summary>
        [NameInMap("purchaseOrderId")]
        [Validation(Required=false)]
        public string PurchaseOrderId { get; set; }

    }

}

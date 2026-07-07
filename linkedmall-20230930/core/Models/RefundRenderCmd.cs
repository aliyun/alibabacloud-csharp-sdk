// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundRenderCmd : TeaModel {
        /// <summary>
        /// <para>Refund Type: 1 for refund only, 3 for return and refund</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        /// <summary>
        /// <para>Goods Status: 4 for not shipped, 1 for not received, 2 for received</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("goodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        /// <summary>
        /// <para>Sub-distribution order ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

    }

}

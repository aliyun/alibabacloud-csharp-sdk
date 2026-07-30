// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeDetailRequest : TeaModel {
        /// <summary>
        /// <para>The external user ID. If organization members are synchronized, use btripUserId. Otherwise, pass the userId corresponding to the user in the distributor\&quot;s own system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123455</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The change order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21351235134</para>
        /// </summary>
        [NameInMap("change_order_id")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// <para>The distributor order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The sales order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1402002197440511306</para>
        /// </summary>
        [NameInMap("sale_order_id")]
        [Validation(Required=false)]
        public string SaleOrderId { get; set; }

    }

}

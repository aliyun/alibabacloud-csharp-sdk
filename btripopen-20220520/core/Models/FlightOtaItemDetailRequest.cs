// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaItemDetailRequest : TeaModel {
        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Either the external order ID or the business travel order ID is required.</para>
        /// <remarks>
        /// <para>Notice: Pass in this parameter when querying refund/change and baggage rules for a rebooking product. The rules may not be calculable for a re-rebooking scenario.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1017060204732105050</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// <remarks>
        /// <para>Notice: If querying a rebooking product, pass in the rebooking product otaItemId.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68cdc6b37c87484c98b479b49306ffbb_0</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// <remarks>
        /// <para>Notice: Pass in this parameter when querying refund/change and baggage rules for a rebooking product. The rules may not be calculable for a re-rebooking scenario.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3814233628483219456</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}

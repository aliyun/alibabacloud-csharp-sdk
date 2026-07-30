// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The key for asynchronous order creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to use asynchronous order creation mode. If asynchronous order creation is used, only a key is returned before the result is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        /// <summary>
        /// <para>The business travel user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHANG/SAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The contact information. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public string ContactInfoShrink { get; set; }

        /// <summary>
        /// <para>The extended information. This parameter is optional and used to pass parameters for special requirements.</para>
        /// </summary>
        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public string ExtraInfoShrink { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The total price of the order including tax (excluding service fees). Unit: cents.</para>
        /// <remarks>
        /// <para>This parameter is optional. If specified, the system verifies whether the price is consistent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>102000</para>
        /// </summary>
        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        /// <summary>
        /// <para>The quoted product ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fb731deeb4510b86c17e8c8c25740_11</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JP2024071800000002</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The list of passengers. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public string PassengerListShrink { get; set; }

        /// <summary>
        /// <para>The key returned by seat and price verification. If this parameter is specified, seat and price verification is not performed again.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public string ContactInfoShrink { get; set; }

        [NameInMap("cost_center")]
        [Validation(Required=false)]
        public string CostCenterShrink { get; set; }

        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public string ExtraInfoShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open12k0lclldfdc7v10E2HaRrOr00</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chinese</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56319a175bdf4b1898190bd7edb603b5_0</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F11380075736888770560</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public string PassengerListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("total_price_cent")]
        [Validation(Required=false)]
        public long? TotalPriceCent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12341234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopCreateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The key for the asynchronous application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asyncKey_2390u230slgw023</para>
        /// </summary>
        [NameInMap("async_apply_key")]
        [Validation(Required=false)]
        public string AsyncApplyKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the asynchronous commit pattern. If asynchronous commit is used, only a key is returned before the application result is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("async_apply_mode")]
        [Validation(Required=false)]
        public bool? AsyncApplyMode { get; set; }

        /// <summary>
        /// <para>The business travel order ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017035199702438072</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the rebooking product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d01eb358456b4ba38eb4d8f1499186da_0</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3881646464813400064</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The external rebooking application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JPM20241024354</para>
        /// </summary>
        [NameInMap("out_re_shop_apply_id")]
        [Validation(Required=false)]
        public string OutReShopApplyId { get; set; }

        /// <summary>
        /// <para>The rebooking group key returned by the inquiry operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edcac4f4c79d40ccb141ddb6da567e65</para>
        /// </summary>
        [NameInMap("passenger_journey_group_key")]
        [Validation(Required=false)]
        public string PassengerJourneyGroupKey { get; set; }

        /// <summary>
        /// <para>The rebooking reason code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("re_shop_reason_code")]
        [Validation(Required=false)]
        public string ReShopReasonCode { get; set; }

        /// <summary>
        /// <para>The list of passengers selected for rebooking.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_passengers")]
        [Validation(Required=false)]
        public string SelectedPassengersShrink { get; set; }

        /// <summary>
        /// <para>The total rebooking fee (excluding the service fee), in cents.
        ///      * Total rebooking fee = cabin upgrade fee + handling fee + tax difference (applicable to international flights).
        ///      * Pass in this parameter when fees are incurred to verify whether the price has changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1400</para>
        /// </summary>
        [NameInMap("total_re_shop_fee")]
        [Validation(Required=false)]
        public long? TotalReShopFee { get; set; }

    }

}

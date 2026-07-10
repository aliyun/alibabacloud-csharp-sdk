// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightReShopApplyShrinkRequest : TeaModel {
        [NameInMap("async_apply_key")]
        [Validation(Required=false)]
        public string AsyncApplyKey { get; set; }

        [NameInMap("async_apply_mode")]
        [Validation(Required=false)]
        public bool? AsyncApplyMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_re_shop_apply_id")]
        [Validation(Required=false)]
        public string OutReShopApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_journey_group_key")]
        [Validation(Required=false)]
        public string PassengerJourneyGroupKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("re_shop_reason_code")]
        [Validation(Required=false)]
        public string ReShopReasonCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_journeys")]
        [Validation(Required=false)]
        public string SelectedJourneysShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_passengers")]
        [Validation(Required=false)]
        public string SelectedPassengersShrink { get; set; }

        [NameInMap("user_intention_memo")]
        [Validation(Required=false)]
        public string UserIntentionMemo { get; set; }

    }

}

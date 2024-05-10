// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderCreateShrinkRequest : TeaModel {
        [NameInMap("accept_no_seat")]
        [Validation(Required=false)]
        public string AcceptNoSeat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("book_train_infos")]
        [Validation(Required=false)]
        public string BookTrainInfosShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_user_name")]
        [Validation(Required=false)]
        public string BtripUserName { get; set; }

        [NameInMap("business_info")]
        [Validation(Required=false)]
        public string BusinessInfoShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public string ContactInfoShrink { get; set; }

        [NameInMap("force_match")]
        [Validation(Required=false)]
        public string ForceMatch { get; set; }

        [NameInMap("is_pay_now")]
        [Validation(Required=false)]
        public bool? IsPayNow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("passenger_open_info_s")]
        [Validation(Required=false)]
        public string PassengerOpenInfoSShrink { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_journeys")]
        [Validation(Required=false)]
        public string RefundJourneysShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_passenger_list")]
        [Validation(Required=false)]
        public string RefundPassengerListShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_type")]
        [Validation(Required=false)]
        public string RefundTypeShrink { get; set; }

    }

}

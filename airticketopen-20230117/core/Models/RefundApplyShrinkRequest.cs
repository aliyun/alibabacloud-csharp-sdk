// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundApplyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>order number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4966***617111</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>journeys for which a refund is being requested</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_journeys")]
        [Validation(Required=false)]
        public string RefundJourneysShrink { get; set; }

        /// <summary>
        /// <para>passengers that applying for a refund</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_passenger_list")]
        [Validation(Required=false)]
        public string RefundPassengerListShrink { get; set; }

        /// <summary>
        /// <para>refund type and attachments</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_type")]
        [Validation(Required=false)]
        public string RefundTypeShrink { get; set; }

    }

}

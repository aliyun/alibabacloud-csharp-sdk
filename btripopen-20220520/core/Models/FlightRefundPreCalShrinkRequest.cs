// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The external order ID of the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>Specifies whether the refund is voluntary. This field is currently unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public string IsVoluntary { get; set; }

        /// <summary>
        /// <para>The list of passenger segments selected for refund.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_segment_info_list")]
        [Validation(Required=false)]
        public string PassengerSegmentInfoListShrink { get; set; }

    }

}

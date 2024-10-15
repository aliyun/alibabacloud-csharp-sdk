// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public string IsVoluntary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_segment_info_list")]
        [Validation(Required=false)]
        public string PassengerSegmentInfoListShrink { get; set; }

    }

}

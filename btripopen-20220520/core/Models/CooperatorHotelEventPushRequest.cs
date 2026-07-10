// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorHotelEventPushRequest : TeaModel {
        [NameInMap("change_order_status")]
        [Validation(Required=false)]
        public int? ChangeOrderStatus { get; set; }

        [NameInMap("change_order_status_desc")]
        [Validation(Required=false)]
        public string ChangeOrderStatusDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cooperator_order_id")]
        [Validation(Required=false)]
        public string CooperatorOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        [NameInMap("event_desc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("event_time")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}

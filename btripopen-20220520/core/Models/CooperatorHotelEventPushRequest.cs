// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorHotelEventPushRequest : TeaModel {
        /// <summary>
        /// <para>The order status after the change. Leave empty unless a special scenario applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("change_order_status")]
        [Validation(Required=false)]
        public int? ChangeOrderStatus { get; set; }

        /// <summary>
        /// <para>The description of the order status after the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>交易成功</para>
        /// </summary>
        [NameInMap("change_order_status_desc")]
        [Validation(Required=false)]
        public string ChangeOrderStatusDesc { get; set; }

        /// <summary>
        /// <para>The order ID of the service provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>coop_123456</para>
        /// </summary>
        [NameInMap("cooperator_order_id")]
        [Validation(Required=false)]
        public string CooperatorOrderId { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_LEAVE</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The description of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户离店</para>
        /// </summary>
        [NameInMap("event_desc")]
        [Validation(Required=false)]
        public string EventDesc { get; set; }

        /// <summary>
        /// <para>The time when the event occurred.</para>
        /// <para>Format: yyyy-MM-dd HH:mm:ss</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204-09-01 10:55:20</para>
        /// </summary>
        [NameInMap("event_time")]
        [Validation(Required=false)]
        public string EventTime { get; set; }

        /// <summary>
        /// <para>The order ID on the Zhongzhou platform.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}

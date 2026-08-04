// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ThirdImmediateMsgPushRequest : TeaModel {
        /// <summary>
        /// <para>Business type (FLIGHT: flight, TRAIN: train)</para>
        /// 
        /// <b>Example:</b>
        /// <para>FLIGHT</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Change details (JSON-formatted change data)</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ChangeDetail")]
        [Validation(Required=false)]
        public string ChangeDetail { get; set; }

        /// <summary>
        /// <para>Order ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>orderId</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>Passenger IDs to change</para>
        /// 
        /// <b>Example:</b>
        /// <para>psgIds</para>
        /// </summary>
        [NameInMap("PsgIds")]
        [Validation(Required=false)]
        public string PsgIds { get; set; }

        /// <summary>
        /// <para>Request source</para>
        /// 
        /// <b>Example:</b>
        /// <para>source</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>change type (TRAIN_ISSUED, FLIGHT_CHANGED)</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRAIN_ISSUED</para>
        /// </summary>
        [NameInMap("TrafficChangeType")]
        [Validation(Required=false)]
        public string TrafficChangeType { get; set; }

        /// <summary>
        /// <para>change type description (ticket issued, rebooked)</para>
        /// 
        /// <b>Example:</b>
        /// <para>已出票</para>
        /// </summary>
        [NameInMap("TrafficChangeTypeDesc")]
        [Validation(Required=false)]
        public string TrafficChangeTypeDesc { get; set; }

        /// <summary>
        /// <para>Journey IDs to change</para>
        /// 
        /// <b>Example:</b>
        /// <para>trafficJourneyIds</para>
        /// </summary>
        [NameInMap("TrafficJourneyIds")]
        [Validation(Required=false)]
        public string TrafficJourneyIds { get; set; }

        /// <summary>
        /// <para>sub-order ID of the changed train request</para>
        /// 
        /// <b>Example:</b>
        /// <para>trafficSubOrderIds</para>
        /// </summary>
        [NameInMap("TrafficSubOrderIds")]
        [Validation(Required=false)]
        public string TrafficSubOrderIds { get; set; }

        /// <summary>
        /// <para>user ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>userId</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

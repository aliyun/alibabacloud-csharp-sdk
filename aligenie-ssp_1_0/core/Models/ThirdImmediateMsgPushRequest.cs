// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ThirdImmediateMsgPushRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FLIGHT</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>changeDetail</para>
        /// </summary>
        [NameInMap("ChangeDetail")]
        [Validation(Required=false)]
        public string ChangeDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>orderId</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>psgIds</para>
        /// </summary>
        [NameInMap("PsgIds")]
        [Validation(Required=false)]
        public string PsgIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trafficChangeType</para>
        /// </summary>
        [NameInMap("TrafficChangeType")]
        [Validation(Required=false)]
        public string TrafficChangeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trafficChangeTypeDesc</para>
        /// </summary>
        [NameInMap("TrafficChangeTypeDesc")]
        [Validation(Required=false)]
        public string TrafficChangeTypeDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trafficJourneyIds</para>
        /// </summary>
        [NameInMap("TrafficJourneyIds")]
        [Validation(Required=false)]
        public string TrafficJourneyIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>trafficSubOrderIds</para>
        /// </summary>
        [NameInMap("TrafficSubOrderIds")]
        [Validation(Required=false)]
        public string TrafficSubOrderIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>userId</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

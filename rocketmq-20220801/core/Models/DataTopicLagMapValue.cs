// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DataTopicLagMapValue : TeaModel {
        /// <summary>
        /// <para>Ready message count</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("readyCount")]
        [Validation(Required=false)]
        public long? ReadyCount { get; set; }

        /// <summary>
        /// <para>The number of messages being consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("inflightCount")]
        [Validation(Required=false)]
        public long? InflightCount { get; set; }

        /// <summary>
        /// <para>Delivery delay time, in seconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("deliveryDuration")]
        [Validation(Required=false)]
        public long? DeliveryDuration { get; set; }

    }

}

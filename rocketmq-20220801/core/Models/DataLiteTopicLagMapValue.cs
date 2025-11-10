// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DataLiteTopicLagMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("readyCount")]
        [Validation(Required=false)]
        public long? ReadyCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("deliveryDuration")]
        [Validation(Required=false)]
        public long? DeliveryDuration { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class DeliveryOption : TeaModel {
        /// <summary>
        /// <para>The maximum number of concurrent events that can be delivered by the upstream event source to Function Compute. This parameter is valid only when ApsaraMQ for Kafka is used as the event source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <para>The format of each data element in the event parameter of the function. CloudEvents: describes event data in a common format, including event description and event payload data. CloudEvents is designed to simplify event declaration and transmission between different services and platforms. This is the default value. RawData: delivers only the event payload data and does not include other metadata information in the CloudEvents format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RawData</para>
        /// </summary>
        [NameInMap("eventSchema")]
        [Validation(Required=false)]
        public string EventSchema { get; set; }

    }

}

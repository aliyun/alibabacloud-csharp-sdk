// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerTimeSpanResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerTimeSpanResponseBodyData Data { get; set; }
        public class OnsConsumerTimeSpanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The most recent point in time when a message in the topic was consumed by the customer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570761026400</para>
            /// </summary>
            [NameInMap("ConsumeTimeStamp")]
            [Validation(Required=false)]
            public long? ConsumeTimeStamp { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the consumer group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_111111111111_DOxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The point in time when the earliest stored message was published to the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570761026804</para>
            /// </summary>
            [NameInMap("MaxTimeStamp")]
            [Validation(Required=false)]
            public long? MaxTimeStamp { get; set; }

            /// <summary>
            /// <para>The point in time when the most recently stored message was published to the topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1570701231122</para>
            /// </summary>
            [NameInMap("MinTimeStamp")]
            [Validation(Required=false)]
            public long? MinTimeStamp { get; set; }

            /// <summary>
            /// <para>The name of the topic that you want to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-mq_topic</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A07E3902-B92E-44A6-B6C5-6AA111111****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

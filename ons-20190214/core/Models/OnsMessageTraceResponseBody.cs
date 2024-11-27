// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageTraceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the message that is queried.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageTraceResponseBodyData Data { get; set; }
        public class OnsMessageTraceResponseBodyData : TeaModel {
            [NameInMap("MessageTrack")]
            [Validation(Required=false)]
            public List<OnsMessageTraceResponseBodyDataMessageTrack> MessageTrack { get; set; }
            public class OnsMessageTraceResponseBodyDataMessageTrack : TeaModel {
                /// <summary>
                /// <para>The ID of the consumer group that subscribes to the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_test_group_id</para>
                /// </summary>
                [NameInMap("ConsumerGroup")]
                [Validation(Required=false)]
                public string ConsumerGroup { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the message you want to query belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MQ_INST_111111111111_DOxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The status of the message. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CONSUMED</b>: The message is consumed.</description></item>
                /// <item><description><b>CONSUMED_BUT_FILTERED</b>: No consumer group subscribes to the message. The message is filtered out and not consumed.</description></item>
                /// <item><description><b>NOT_CONSUME_YET</b>: The message is not consumed.</description></item>
                /// <item><description><b>NOT_ONLINE</b>: The consumer group is offline.</description></item>
                /// <item><description><b>UNKNOWN</b>: The message is not consumed due to unknown reasons.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CONSUMED</para>
                /// </summary>
                [NameInMap("TrackType")]
                [Validation(Required=false)]
                public string TrackType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EAE5BE23-37A1-4354-94D6-E44AE17E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

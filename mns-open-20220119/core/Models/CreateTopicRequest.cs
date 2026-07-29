// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the log management feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.
        /// Default value: false.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        [NameInMap("EnableSSE")]
        [Validation(Required=false)]
        public bool? EnableSSE { get; set; }

        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum length of the message body sent to the topic. Valid values: 1024 to 65536. Unit: bytes. Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("MaxMessageSize")]
        [Validation(Required=false)]
        public long? MaxMessageSize { get; set; }

        [NameInMap("SseAlgorithm")]
        [Validation(Required=false)]
        public string SseAlgorithm { get; set; }

        [NameInMap("SseType")]
        [Validation(Required=false)]
        public string SseType { get; set; }

        /// <summary>
        /// <para>The list of resource tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic to create.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

        /// <summary>
        /// <para>The type of the topic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: normal topic</description></item>
        /// <item><description>fifo: FIFO topic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("TopicType")]
        [Validation(Required=false)]
        public string TopicType { get; set; }

    }

}

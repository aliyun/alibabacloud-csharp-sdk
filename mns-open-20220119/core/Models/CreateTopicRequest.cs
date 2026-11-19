// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the logging feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false: disables the feature.
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

        /// <summary>
        /// <para>Specifies whether to enable server-side encryption for the message body. Valid values: true or false.</para>
        /// </summary>
        [NameInMap("EnableSSE")]
        [Validation(Required=false)]
        public bool? EnableSSE { get; set; }

        /// <summary>
        /// <para>The KMS key ID used when KMS encryption is enabled. The key must belong to the same account and region as the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum size of the message body that can be sent to the topic.
        /// Valid values: 1024 to 65536. Unit: bytes.
        /// Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("MaxMessageSize")]
        [Validation(Required=false)]
        public long? MaxMessageSize { get; set; }

        /// <summary>
        /// <para>The server-side encryption algorithm. Currently, only AES-256-GCM is supported. If this parameter is not specified, the default algorithm is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES-256-GCM</para>
        /// </summary>
        [NameInMap("SseAlgorithm")]
        [Validation(Required=false)]
        public string SseAlgorithm { get; set; }

        /// <summary>
        /// <para>The server-side encryption method. Valid values: SMQ (service-hosted key) or KMS (user-managed KMS key).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
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
        /// <para>The name of the topic. The name can be up to 120 characters in length and must start with a letter. It can contain letters, digits, and hyphens (-).</para>
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
        /// <item><description>normal: standard topic.</description></item>
        /// <item><description>fifo: FIFO topic.</description></item>
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

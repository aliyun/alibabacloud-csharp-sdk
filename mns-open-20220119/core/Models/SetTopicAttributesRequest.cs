// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetTopicAttributesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the log management feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLogging")]
        [Validation(Required=false)]
        public bool? EnableLogging { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable server-side encryption for message bodies. Valid values: true or false.</para>
        /// </summary>
        [NameInMap("EnableSSE")]
        [Validation(Required=false)]
        public bool? EnableSSE { get; set; }

        /// <summary>
        /// <para>The KMS key ID. This parameter is required when you use KMS for encryption. The key must belong to the same Alibaba Cloud account and region as the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum size of a message body sent to the topic. Valid values: 1024 to 65536. Unit: bytes. Default value: 65536.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65536</para>
        /// </summary>
        [NameInMap("MaxMessageSize")]
        [Validation(Required=false)]
        public long? MaxMessageSize { get; set; }

        /// <summary>
        /// <para>The server-side encryption algorithm. Currently, only AES-256-GCM is supported. If you do not specify this parameter, the default algorithm is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES-256-GCM</para>
        /// </summary>
        [NameInMap("SseAlgorithm")]
        [Validation(Required=false)]
        public string SseAlgorithm { get; set; }

        /// <summary>
        /// <para>The server-side encryption method. Valid values: SMQ (service-managed key) or KMS (customer-managed KMS key).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("SseType")]
        [Validation(Required=false)]
        public string SseType { get; set; }

        /// <summary>
        /// <para>The name of the topic. The name can be up to 120 characters in length. It must start with a letter and can contain letters, digits, and hyphens.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

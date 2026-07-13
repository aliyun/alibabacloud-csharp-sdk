// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetTopicAttributesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicAttributesResponseBodyData Data { get; set; }
        public class GetTopicAttributesResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EnableSSE")]
            [Validation(Required=false)]
            public bool? EnableSSE { get; set; }

            [NameInMap("EncryptionEnabled")]
            [Validation(Required=false)]
            public bool? EncryptionEnabled { get; set; }

            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            [NameInMap("LoggingEnabled")]
            [Validation(Required=false)]
            public bool? LoggingEnabled { get; set; }

            [NameInMap("MaxMessageSize")]
            [Validation(Required=false)]
            public long? MaxMessageSize { get; set; }

            [NameInMap("MessageCount")]
            [Validation(Required=false)]
            public long? MessageCount { get; set; }

            [NameInMap("MessageRetentionPeriod")]
            [Validation(Required=false)]
            public long? MessageRetentionPeriod { get; set; }

            [NameInMap("SseAlgorithm")]
            [Validation(Required=false)]
            public string SseAlgorithm { get; set; }

            [NameInMap("SseType")]
            [Validation(Required=false)]
            public string SseType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTopicAttributesResponseBodyDataTags> Tags { get; set; }
            public class GetTopicAttributesResponseBodyDataTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http:// 111111111****.mns.us-west-1-internal.aliyuncs.com/topics/testTopic</para>
            /// </summary>
            [NameInMap("TopicInnerUrl")]
            [Validation(Required=false)]
            public string TopicInnerUrl { get; set; }

            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http:// 111111111****.mns.us-west-1.aliyuncs.com/topics/testTopic</para>
            /// </summary>
            [NameInMap("TopicUrl")]
            [Validation(Required=false)]
            public string TopicUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

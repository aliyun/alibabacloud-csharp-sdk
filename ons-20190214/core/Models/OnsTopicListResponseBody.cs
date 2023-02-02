// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListResponseBody : TeaModel {
        /// <summary>
        /// The information about the topics.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTopicListResponseBodyData Data { get; set; }
        public class OnsTopicListResponseBodyData : TeaModel {
            [NameInMap("PublishInfoDo")]
            [Validation(Required=false)]
            public List<OnsTopicListResponseBodyDataPublishInfoDo> PublishInfoDo { get; set; }
            public class OnsTopicListResponseBodyDataPublishInfoDo : TeaModel {
                /// <summary>
                /// The point in time when the topic was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether the instance that contains the topic uses a namespace. Valid values:
                /// 
                /// *   **true**: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.
                /// *   **false**: The instance does not use a separate namespace. The name of each resource must be globally unique within and across all instances.
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// The ID of the instance that contains the topic.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The type of the messages. Valid values:
                /// 
                /// *   **0**: normal messages
                /// *   **1**: partitionally ordered messages
                /// *   **2**: globally ordered messages
                /// *   **4**: transactional messages
                /// *   **5**: scheduled or delayed messages
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public int? MessageType { get; set; }

                /// <summary>
                /// The user ID of the topic owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The code of the relationship between the current account and the topic. Valid values:
                /// 
                /// *   **1**: The current account is the owner of the topic.
                /// *   **2**: The current account can publish messages to the topic.
                /// *   **4**: The current account can subscribe to the topic.
                /// *   **6**: The current account can publish messages to and subscribe to the topic.
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public int? Relation { get; set; }

                /// <summary>
                /// The name of the relationship between the current account and the topic. The value of this parameter indicates that the current account is the owner of the topic, the current account can publish messages to the topic, the current account can subscribe to the topic, or the current account can publish messages to and subscribe to the topic.
                /// </summary>
                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                /// <summary>
                /// The description of the topic.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The status of the topic. Valid values:
                /// 
                /// *   **0**: The topic is being created.
                /// *   **1**: The topic is being used.
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// The tags that are attached to the topic.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsTopicListResponseBodyDataPublishInfoDoTags Tags { get; set; }
                public class OnsTopicListResponseBodyDataPublishInfoDoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsTopicListResponseBodyDataPublishInfoDoTagsTag> Tag { get; set; }
                    public class OnsTopicListResponseBodyDataPublishInfoDoTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The name of the topic.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. This is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

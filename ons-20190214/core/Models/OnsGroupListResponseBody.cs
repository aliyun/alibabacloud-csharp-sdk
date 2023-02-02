// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupListResponseBody : TeaModel {
        /// <summary>
        /// The returned list of subscriptions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsGroupListResponseBodyData Data { get; set; }
        public class OnsGroupListResponseBodyData : TeaModel {
            [NameInMap("SubscribeInfoDo")]
            [Validation(Required=false)]
            public List<OnsGroupListResponseBodyDataSubscribeInfoDo> SubscribeInfoDo { get; set; }
            public class OnsGroupListResponseBodyDataSubscribeInfoDo : TeaModel {
                /// <summary>
                /// The time when the group was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The ID of the consumer group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The protocol over which the queried consumer groups consume messages. All clients in a consumer group communicate with the Message Queue for Apache RocketMQ broker over the same protocol. A consumer group cannot contain TCP clients and HTTP clients at the same time. You must create different consumer groups for TCP clients and HTTP clients. Valid values:
                /// 
                /// *   **tcp**: indicates that the consumer group consumes messages over TCP.
                /// *   **http**: indicates that the consumer group consumes messages over HTTP.
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// Indicates whether the instance uses a namespace. Valid values:
                /// 
                /// *   **true**: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.
                /// *   **false**: The instance does not use a separate namespace. The name of each resource must be globally unique within and across all instances.
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the user who created the consumer group.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The description of the consumer group.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The tags that are attached to the consumer group.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public OnsGroupListResponseBodyDataSubscribeInfoDoTags Tags { get; set; }
                public class OnsGroupListResponseBodyDataSubscribeInfoDoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag> Tag { get; set; }
                    public class OnsGroupListResponseBodyDataSubscribeInfoDoTagsTag : TeaModel {
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
                /// The time when the group ID was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

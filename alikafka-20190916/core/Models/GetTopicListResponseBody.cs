// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The topics.
        /// </summary>
        [NameInMap("TopicList")]
        [Validation(Required=false)]
        public GetTopicListResponseBodyTopicList TopicList { get; set; }
        public class GetTopicListResponseBodyTopicList : TeaModel {
            [NameInMap("TopicVO")]
            [Validation(Required=false)]
            public List<GetTopicListResponseBodyTopicListTopicVO> TopicVO { get; set; }
            public class GetTopicListResponseBodyTopicListTopicVO : TeaModel {
                /// <summary>
                /// Indicates whether the topic was automatically created.
                /// </summary>
                [NameInMap("AutoCreate")]
                [Validation(Required=false)]
                public bool? AutoCreate { get; set; }

                /// <summary>
                /// The log cleanup policy for the topic. This parameter is returned only if **LocalTopic** is set to **true**. Valid values:
                /// 
                /// *   false: the default log cleanup policy.
                /// *   true: the Apache Kafka log compaction policy.
                /// </summary>
                [NameInMap("CompactTopic")]
                [Validation(Required=false)]
                public bool? CompactTopic { get; set; }

                /// <summary>
                /// The timestamp that indicates when the topic was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The storage type that is used for the topic. Valid values:
                /// 
                /// *   false: cloud storage
                /// *   true: local storage
                /// </summary>
                [NameInMap("LocalTopic")]
                [Validation(Required=false)]
                public bool? LocalTopic { get; set; }

                /// <summary>
                /// The number of partitions in the topic.
                /// </summary>
                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public int? PartitionNum { get; set; }

                /// <summary>
                /// The ID of the region where the instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The topic description. Valid values:
                /// 
                /// *   The description can contain only letters, digits, hyphens (-), and underscores (_).
                /// *   The description must be 3 to 64 characters in length.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The topic status. Valid value:
                /// 
                /// **0**: running.
                /// 
                /// If the topic is deleted, this parameter is not returned.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The topic status. Valid value:
                /// 
                /// **Running**.
                /// 
                /// If the topic is deleted, this parameter is not returned.
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public GetTopicListResponseBodyTopicListTopicVOTags Tags { get; set; }
                public class GetTopicListResponseBodyTopicListTopicVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetTopicListResponseBodyTopicListTopicVOTagsTagVO> TagVO { get; set; }
                    public class GetTopicListResponseBodyTopicListTopicVOTagsTagVO : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The topic name. Valid values:
                /// 
                /// *   The name can contain only letters, digits, hyphens (-), and underscores (_).
                /// *   The name must be 3 to 64 characters in length. If the name contains more than 64 characters, the system automatically truncates the name.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                [NameInMap("TopicConfig")]
                [Validation(Required=false)]
                public string TopicConfig { get; set; }

            }

        }

        /// <summary>
        /// The number of topics.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

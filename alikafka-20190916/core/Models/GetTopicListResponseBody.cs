// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicListResponseBody : TeaModel {
        /// <summary>
        /// The number of topics.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The information about the topic.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The status of the topic. Valid values:
        /// 
        /// **0:** indicates that the topic is running.
        /// 
        /// If the topic is deleted, this parameter is not returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The description. Valid values:
        /// 
        /// *   The description contains only letters, digits, hyphens (-), and underscores (\_).
        /// *   The description is 3 to 64 characters in length.
        /// </summary>
        [NameInMap("TopicList")]
        [Validation(Required=false)]
        public GetTopicListResponseBodyTopicList TopicList { get; set; }
        public class GetTopicListResponseBodyTopicList : TeaModel {
            [NameInMap("TopicVO")]
            [Validation(Required=false)]
            public List<GetTopicListResponseBodyTopicListTopicVO> TopicVO { get; set; }
            public class GetTopicListResponseBodyTopicListTopicVO : TeaModel {
                [NameInMap("AutoCreate")]
                [Validation(Required=false)]
                public bool? AutoCreate { get; set; }

                /// <summary>
                /// The region ID of the instance whose topics were queried.
                /// </summary>
                [NameInMap("CompactTopic")]
                [Validation(Required=false)]
                public bool? CompactTopic { get; set; }

                /// <summary>
                /// Running
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("LocalTopic")]
                [Validation(Required=false)]
                public bool? LocalTopic { get; set; }

                /// <summary>
                /// The name of the topic. Valid values:
                /// 
                /// *   The name contains only letters, digits, hyphens (-), and underscores (\_).
                /// *   The name is 3 to 64 characters in length. If the name that you specified contains more than 64 characters, the returned name is automatically truncated.
                /// </summary>
                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public int? PartitionNum { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of the topic. Valid values:
                /// 
                /// **Running**
                /// 
                /// If the topic is deleted, this parameter is not returned.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The timestamp that indicates when the topic was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The ID of the instance
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                /// <summary>
                /// Indicates whether the topic was automatically created.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public GetTopicListResponseBodyTopicListTopicVOTags Tags { get; set; }
                public class GetTopicListResponseBodyTopicListTopicVOTags : TeaModel {
                    [NameInMap("TagVO")]
                    [Validation(Required=false)]
                    public List<GetTopicListResponseBodyTopicListTopicVOTagsTagVO> TagVO { get; set; }
                    public class GetTopicListResponseBodyTopicListTopicVOTagsTagVO : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The log cleanup policy that is used for the topic. This parameter is returned when the **LocalTopic** parameter is set to **true**. Valid values:
                /// 
                /// *   false: The topic uses the delete policy.
                /// *   true: The topic uses the compact policy.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// The number of partitions in the topic.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

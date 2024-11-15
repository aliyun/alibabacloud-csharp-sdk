// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetTopicListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0D3DC5B-5C37-47AD-9F22-1F559880****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The topics.</para>
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
                /// <para>Indicates whether the topic was automatically created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoCreate")]
                [Validation(Required=false)]
                public bool? AutoCreate { get; set; }

                /// <summary>
                /// <para>The log cleanup policy for the topic. This parameter is returned only if <b>LocalTopic</b> is set to <b>true</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: the default log cleanup policy.</description></item>
                /// <item><description>true: the Apache Kafka log compaction policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CompactTopic")]
                [Validation(Required=false)]
                public bool? CompactTopic { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the topic was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1576563109000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alikafka_pre-cn-0pp1954n****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The storage type that is used for the topic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: cloud storage</description></item>
                /// <item><description>true: local storage</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LocalTopic")]
                [Validation(Required=false)]
                public bool? LocalTopic { get; set; }

                /// <summary>
                /// <para>The number of partitions in the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public int? PartitionNum { get; set; }

                /// <summary>
                /// <para>The ID of the region where the instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The topic description. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>The description can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>The description must be 3 to 64 characters in length.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The topic status. Valid value:</para>
                /// <para><b>0</b>: running.</para>
                /// <para>If the topic is deleted, this parameter is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The topic status. Valid value:</para>
                /// <para><b>Running</b>.</para>
                /// <para>If the topic is deleted, this parameter is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("StatusName")]
                [Validation(Required=false)]
                public string StatusName { get; set; }

                /// <summary>
                /// <para>The tags.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The topic name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>The name can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>The name must be 3 to 64 characters in length. If the name contains more than 64 characters, the system automatically truncates the name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>topic_name</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <para>The topic configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;replication-factor&quot;:3}</para>
                /// </summary>
                [NameInMap("TopicConfig")]
                [Validation(Required=false)]
                public string TopicConfig { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of topics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

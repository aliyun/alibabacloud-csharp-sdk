// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the topics.</para>
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
                /// <para>The time when the topic was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1570700947000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance that contains the topic uses a namespace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.</description></item>
                /// <item><description><b>false</b>: The instance does not use a separate namespace. The name of each resource must be globally unique within an instance and across all instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// <para>The ID of the instance that contains the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MQ_INST_188077086902****_BXSuW61e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The message type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: normal messages</description></item>
                /// <item><description><b>1</b>: partitionally ordered messages</description></item>
                /// <item><description><b>2</b>: globally ordered messages</description></item>
                /// <item><description><b>4</b>: transactional messages</description></item>
                /// <item><description><b>5</b>: scheduled or delayed messages</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public int? MessageType { get; set; }

                /// <summary>
                /// <para>The user ID of the topic owner. The value of this parameter is an Alibaba account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>138015630679****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Indicates the relationship between the current account and the topic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The current account is the owner of the topic.</description></item>
                /// <item><description><b>2</b>: The current account can publish messages to the topic.</description></item>
                /// <item><description><b>4</b>: The current account can subscribe to the topic.</description></item>
                /// <item><description><b>6</b>: The current account can publish messages to and subscribe to the topic.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Relation")]
                [Validation(Required=false)]
                public int? Relation { get; set; }

                /// <summary>
                /// <para>The relationship between the current account and the topic. The value of this parameter indicates whether the current account is the owner of the topic, and whether the current account can subscribe or publish messages to the topic. the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Publish and subscribe</para>
                /// </summary>
                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

                /// <summary>
                /// <para>The description of the topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The status of the topic that is asynchronously created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The topic is being created.</description></item>
                /// <item><description><b>1</b>: The topic is being used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public int? ServiceStatus { get; set; }

                /// <summary>
                /// <para>The tags that are attached to the topic.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CartService</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SrviceA</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A978869-7681-4529-B470-107E1379****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

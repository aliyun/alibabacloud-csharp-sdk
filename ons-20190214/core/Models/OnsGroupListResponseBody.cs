// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned list of subscriptions.</para>
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
                /// <para>The point in time when the consumer group was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568896605000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_test_group_id</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The protocol over which the queried consumer group publishes and subscribes to messages. All clients in a consumer group communicate with the ApsaraMQ for RocketMQ broker over the same protocol. You must create different consumer groups for TCP clients and HTTP clients. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>tcp</b>: indicates that the consumer group publishes and subscribes to messages over TCP.</description></item>
                /// <item><description><b>http</b>: indicates that the consumer group publishes and subscribes to messages over HTTP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance uses a namespace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The instance uses a separate namespace. The name of each resource must be unique in the instance. The names of resources in different instances can be the same.</description></item>
                /// <item><description><b>false</b>: The instance does not use a separate namespace. The name of each resource must be globally unique within the instance and across all instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndependentNaming")]
                [Validation(Required=false)]
                public bool? IndependentNaming { get; set; }

                /// <summary>
                /// <para>The ID of the instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>MQ_INST_111111111111_DOxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID of the user who created the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>138015630679****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The description of the consumer group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The tags that are attached to the consumer group.</para>
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
                        /// <para>The key of the tag that is attached to the consumer group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CartService</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag that is attached to the consumer group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ServiceA</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The most recent point in time when the consumer group was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1570700979000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16996623-AC4A-43AF-9248-FD9D2D75****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

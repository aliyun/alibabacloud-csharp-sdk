// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0****be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>301D2CBE-66F8-403D-AEC0-82582478****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the resource and tags, including the resource ID, the resource type, tag keys, and tag values.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_188077086902****_BXSuW61e</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates the ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TopicA</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the resource whose tags you want to query.</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN::MQ::INSTANCE: indicates that the resource is a ApsaraMQ for RocketMQ instance.</description></item>
            /// <item><description>ALIYUN::MQ::TOPIC: indicates that the resource is a topic.</description></item>
            /// <item><description>ALIYUN::MQ::GROUP: indicates that the resource is a group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::MQ::TOPIC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CartService</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceA</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}

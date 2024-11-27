// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance to which the resource whose tags you want to query belongs.</para>
        /// <remarks>
        /// <para>This parameter is required when you query the tags of a topic or a group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The list of resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TopicA</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource whose tags you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b></description></item>
        /// <item><description><b>TOPIC</b></description></item>
        /// <item><description><b>GROUP</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TOPIC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to query. A maximum of 20 tags can be included in the list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to detach from the resource.</para>
            /// <list type="bullet">
            /// <item><description>If you include this parameter in a request, the value of this parameter cannot be an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CartService</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to query.</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter can be an empty string.</description></item>
            /// <item><description>The tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceA</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

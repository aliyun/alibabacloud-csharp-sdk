// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance that contains the resource to which you want to attach tags.</para>
        /// <remarks>
        /// <para>This parameter is required when you attach tags to a topic or a group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TopicA</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource to which you want to attach tags. Valid values:</para>
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
        /// <para>The tags that you want to attach to the resource.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. If you configure this parameter, you must also configure the <b>Value</b> parameter.****</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter cannot be an empty string.</description></item>
            /// <item><description>A tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. A tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to attach to the resource. If you configure this parameter, you must also configure the <b>Key</b> parameter.****</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter can be an empty string.</description></item>
            /// <item><description>A tag value must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. A tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

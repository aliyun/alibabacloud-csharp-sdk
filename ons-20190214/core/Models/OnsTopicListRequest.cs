// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance that contains the topics you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of tags that are attached to the topic. A maximum of 20 tags can be included in the list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsTopicListRequestTag> Tag { get; set; }
        public class OnsTopicListRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is attached to the topics you want to query. This parameter is not required. If you configure this parameter, you must also configure the <b>Value</b> parameter.**** If you include the Key and Value parameters in a request, this operation queries only the topics that use the specified tag. If you do not include these parameters in a request, this operation queries all topics that you can access.</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter cannot be an empty string.</description></item>
            /// <item><description>A tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CartService</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that is attached to the topics you want to query. This parameter is not required. If you configure this parameter, you must also configure the <b>Key</b> parameter.**** If you include the Key and Value parameters in a request, this operation queries only the topics that use the specified tag. If you do not include these parameters in a request, this operation queries all topics that you can access.</para>
            /// <list type="bullet">
            /// <item><description>The value of this parameter can be an empty string.</description></item>
            /// <item><description>A tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceA</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic that you want to query. This parameter is required if you want to query a specific topic. If you do not include this parameter in a request, all topics that you can access are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The user ID of the topic owner. Set this parameter to an Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138015630679****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

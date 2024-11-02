// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UnTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the specified resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The IDs of the resources from which you want to remove tags.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-123</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>acl</b>: an access control list (ACL)</description></item>
        /// <item><description><b>loadbalancer</b>: an Application Load Balancer (ALB) instance</description></item>
        /// <item><description><b>securitypolicy</b>: a security policy</description></item>
        /// <item><description><b>servergroup</b>: a server group</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loadbalancer</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to remove.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UnTagResourcesRequestTag> Tag { get; set; }
        public class UnTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that you want to remove. The tag key can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag that you want to remove. The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The keys of the tags that you want to remove.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

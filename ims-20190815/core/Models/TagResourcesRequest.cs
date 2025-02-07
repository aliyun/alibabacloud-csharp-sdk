// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of resource N.</para>
        /// <para>Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource ID is the ID of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>ResourceId</c> and <c>ResourcePrincipalName</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The name of resource N.</para>
        /// <para>Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource name is the name of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>ResourceId</c> and <c>ResourcePrincipalName</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TagResources</para>
        /// </summary>
        [NameInMap("ResourcePrincipalName")]
        [Validation(Required=false)]
        public List<string> ResourcePrincipalName { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>user: a Resource Access Management (RAM) user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The key of tag N.</para>
        /// <para>Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key can be up to 128 characters in length. The tag key cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// <para>Valid values of N: 1 to 20. You cannot specify empty strings as tag keys. The tag key can be up to 128 characters in length. The tag key cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// <para>Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

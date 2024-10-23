// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. If a response is truncated because it reaches the value of PageSize, the value of IsTruncated will be true. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of resource N.</para>
        /// <para>Valid values of N: 1 to 50. If ResourceType is set to user, the resource ID is the ID of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The name of resource N.</para>
        /// <para>Valid values of N: 1 to 50. If ResourceType is set to user, the resource name is the name of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourcePrincipalName")]
        [Validation(Required=false)]
        public List<string> ResourcePrincipalName { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>user: a RAM user</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag value.</para>
        /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>operator</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N.</para>
            /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
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

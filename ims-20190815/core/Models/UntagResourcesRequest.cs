// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: remove all tags from the resources.</description></item>
        /// <item><description>false (default): does not remove all tags from the resources.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when TagKey.N is not set in the request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The IDs of resources.</para>
        /// <para>Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource ID is the ID of the RAM user.</para>
        /// <remarks>
        /// <para>You must specify only one of the following parameters: ResourceId and ResourcePrincipalName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UntagResources</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The names of resources.</para>
        /// <para>Valid values of N: 1 to 50. If the ResourceType parameter is set to user, the resource name is the name of the RAM user.</para>
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
        /// <para>The tag keys of resources.</para>
        /// <para>Valid values of N: 1 to 20. N must be consecutive.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

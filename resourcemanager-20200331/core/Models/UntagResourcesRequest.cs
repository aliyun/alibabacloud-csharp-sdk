// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the specified resource group or member of a resource directory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): No.</description></item>
        /// <item><description>true: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The ID of the resource group or the member of the resource directory.</para>
        /// <para>You can specify up to 50 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceGroup (default): Removes tags from resource groups.</description></item>
        /// <item><description>Account: Removes tags from members of a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you remove tags from members of a resource directory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceGroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// <para>You can remove up to 20 tag keys.</para>
        /// <remarks>
        /// <para>If the All parameter is set to true to remove all tags, you do not need to specify tag keys.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

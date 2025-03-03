// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the specified resource groups or members. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default value)</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The ID of a resource group or member.</para>
        /// <para>You can specify a maximum of 50 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the objects from which you want to remove tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceGroup: resource group. This is the default value.</description></item>
        /// <item><description>Account: member.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you remove tags from members in a resource directory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceGroup</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>A tag key.</para>
        /// <para>You can specify a maximum of 20 tag keys.</para>
        /// <remarks>
        /// <para> If you set the <c>All</c> parameter to <c>true</c>, you do not need to configure this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

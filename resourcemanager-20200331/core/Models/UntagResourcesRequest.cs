// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags from the specified resource group or resource directory member. Valid values:</para>
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
        /// <para>The ID of the resource group or resource directory member.</para>
        /// <para>You can specify up to 50 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceGroup (default): Unbinds tags from a resource group.</description></item>
        /// <item><description>Account: Unbinds tags from a resource directory member.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you unbind tags from a resource directory member.</para>
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
        /// <para>You can unbind up to 20 tag keys.</para>
        /// <remarks>
        /// <para>If the <c>All</c> parameter for unbinding all tags is set to <c>true</c>, you do not need to specify tag keys.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}

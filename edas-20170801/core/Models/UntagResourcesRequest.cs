// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all existing tags from the specified resources. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: removes all existing tags from the specified resources.</description></item>
        /// <item><description><b>false</b>: does not remove all existing tags from the specified resources.</description></item>
        /// </list>
        /// <remarks>
        /// <para>All existing tags of a resource are removed only if the <b>tagKeys</b> parameter is left empty and the <b>DeleteAll</b> parameter is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// <para>The IDs of the resources from which you want to remove tags. You can specify up to 20 IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;f5ad6ff7-xxxx-xxxx-xxxx-2axxxx82xxxx&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The region in which the resource resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>application</b>: Enterprise Distributed Application Service (EDAS) application</description></item>
        /// <item><description><b>cluster</b>: EDAS cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags that you want to remove. You can specify up to 20 tags. Set this parameter to a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;tagKey1&quot;,&quot;tagKey2&quot;]</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}

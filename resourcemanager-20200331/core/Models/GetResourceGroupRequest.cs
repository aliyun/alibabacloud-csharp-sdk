// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return tag information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): does not return tag information.</description></item>
        /// <item><description>true: returns tag information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/158855.html">ListResourceGroups</a> to query resource group IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

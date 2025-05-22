// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DeleteResourceGroupRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para> The ID of the resource group that you want to delete.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you also specify ResourceGroupIds, both parameters take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aj01tck67a0szp***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> The IDs of the resource groups that you want to delete.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you also specify ResourceGroupId, both parameters take effect.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

    }

}

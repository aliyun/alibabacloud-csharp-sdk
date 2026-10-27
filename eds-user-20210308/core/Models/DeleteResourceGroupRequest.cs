// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DeleteResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to delete.</para>
        /// <remarks>
        /// <para>If the <c>ResourceGroupIds</c> parameter is not empty, both parameters take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aj01tck67a0szp***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of IDs of the resource groups to delete.</para>
        /// <remarks>
        /// <para>If the <c>ResourceGroupIds</c> parameter is not empty, both parameters take effect.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

    }

}

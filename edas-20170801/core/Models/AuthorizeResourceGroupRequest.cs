// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AuthorizeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group. You can call the ListResourceGroup operation to query the resource group ID. For more information, see <a href="https://help.aliyun.com/document_detail/62055.html">ListResourceGroup</a>.</para>
        /// <para>You can specify multiple resource group IDs. Separate multiple resource group IDs with semicolons (;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>461;462</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user to be authorized.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test@13333********</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which you want to move the cloud resource instance.</para>
        /// <remarks>
        /// <para>Resource groups are a mechanism for grouping and managing resources under an Alibaba Cloud account, which helps you solve the complexity of resource grouping and authorization management within a single cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">Resource Management</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be tagged. Currently, only instance-level tagging is supported.</para>
        /// <para>For example, if the instance ID is alikafka_post-cn-v0h1fgs2xxxx, the resource ID is alikafka_post-cn-v0h1fgs2xxxx.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}

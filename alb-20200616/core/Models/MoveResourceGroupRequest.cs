// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class MoveResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which you want to transfer the cloud resource.</para>
        /// <remarks>
        /// <para> You can use resource groups to manage resources within your Alibaba Cloud account by group. This helps you resolve issues such as resource grouping and permission management for your Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">What is resource management?</a></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-hp34s2h0xx1ht4nwo****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>loadbalancer</b>: Application Load Balancer (ALB) instance</description></item>
        /// <item><description><b>acl</b>: access control list (ACL)</description></item>
        /// <item><description><b>securitypolicy</b>: security policy</description></item>
        /// <item><description><b>servergroup</b>: server group</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}

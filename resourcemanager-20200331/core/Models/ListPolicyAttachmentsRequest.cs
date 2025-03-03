// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyAttachmentsRequest : TeaModel {
        /// <summary>
        /// <para>The language that is used to return the description of the system policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// <para>The name must be 1 to 128 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdministratorAccess</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The type of the policy. If you do not specify this parameter, the system lists all types of policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Custom: custom policy</description></item>
        /// <item><description>System: system policy</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The name of the object to which the policy is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:alice@demo.onaliyun.com">alice@demo.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// <para>The type of the object to which the policy is attached. If you do not specify this parameter, the system lists all types of objects. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMSUser: RAM user</description></item>
        /// <item><description>IMSGroup: RAM user group</description></item>
        /// <item><description>ServiceRole: RAM role</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMSUser</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group or the ID of the Alibaba Cloud account to which the resource group belongs. If you do not specify this parameter, the system lists all policy attachment records under the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-001</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}

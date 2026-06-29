// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy.</para>
        /// <remarks>
        /// <para>Only CPFS for Lingjun supports this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lc-xxx</para>
        /// </summary>
        [NameInMap("LifecyclePolicyId")]
        [Validation(Required=false)]
        public string LifecyclePolicyId { get; set; }

        /// <summary>
        /// <para>The lifecycle policy name. Naming rules:</para>
        /// <para>The name must be 3 to 64 characters in length, start with a letter, and can contain letters, digits, underscores (_), or hyphens (-).</para>
        /// <remarks>
        /// <para>Optional for General-purpose NAS file systems. If specified, this parameter takes precedence. If not specified, LifecyclePolicyId is used instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclepolicy_01</para>
        /// </summary>
        [NameInMap("LifecyclePolicyName")]
        [Validation(Required=false)]
        public string LifecyclePolicyName { get; set; }

        /// <summary>
        /// <para>The policy type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Auto: automatic execution</description></item>
        /// <item><description>OnDemand: on-demand execution<remarks>
        /// <para>Only CPFS for Lingjun supports this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("LifecyclePolicyType")]
        [Validation(Required=false)]
        public string LifecyclePolicyType { get; set; }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// <para>Start value (default value): 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of lifecycle management policies on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters results by path.</para>
        /// <remarks>
        /// <para>Only CPFS for Lingjun supports this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/abc/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The storage class type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InfrequentAccess: IA storage class.</description></item>
        /// <item><description>Archive: Archive storage class.<remarks>
        /// <para>If StorageType is not specified, all lifecycle policies are returned.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InfrequentAccess</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}

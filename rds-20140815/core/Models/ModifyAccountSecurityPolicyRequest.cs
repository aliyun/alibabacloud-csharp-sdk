// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyAccountSecurityPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/2628785.html">DescribeDBInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1ibu****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The custom password policy for ApsaraDB RDS for SQL Server accounts. The following policies are supported:</para>
        /// <list type="bullet">
        /// <item><description>Set only the maximum password age. After this period expires, the password must be changed: <c>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the maximum age}}</c></description></item>
        /// <item><description>Set only the minimum password age. The password cannot be changed again within this period: <c>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the minimum age}}</c></description></item>
        /// <item><description>Set both the maximum and minimum password ages: <c>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the maximum age, &quot;MinimumPasswordAge&quot;: Specify the minimum age}}</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>The minimum password age (valid values: 0 to 998) cannot be greater than the maximum password age (valid values: 0 to 999).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: 30, &quot;MinimumPasswordAge&quot;: 20}}</para>
        /// </summary>
        [NameInMap("GroupPolicy")]
        [Validation(Required=false)]
        public string GroupPolicy { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

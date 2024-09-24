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
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2628785.html">DescribeDBInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1ibu****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The custom password policy for the account of the ApsaraDB RDS for SQL Server instance. The following policies are supported:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;account security policy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the maximum password age}}</c>: You can configure only the maximum password age. After the maximum password age is reached, you must change the password.</description></item>
        /// <item><description><c>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the minimum password age}}</c>: You can configure only the minimum password age. During the specified period, you cannot change the password.</description></item>
        /// <item><description><c>{&quot;accountSecurityPolicy&quot;: {&quot;MaximumPasswordAge&quot;: Specify the maximum password age, &quot;MinimumPasswordAge&quot;: Specify the minimum password age}}</c>: You can configure the maximum and minimum password age at the same time.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The minimum password age cannot be greater than the maximum password age. Valid values for the minimum password age: 0 to 998. Valid values for the maximum password age: 0 to 999.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateAbacPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The content of the policy. Specifies whether the authorized user can access and use the resources and features defined in the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Statement&quot;: [
        ///     {
        ///       &quot;Action&quot;: &quot;<em>&quot;,
        ///       &quot;Effect&quot;: &quot;Allow&quot;,
        ///       &quot;Resource&quot;: &quot;</em>&quot;,
        ///       &quot;Condition&quot;: {
        ///         &quot;StringEqualsIgnoreCase&quot;: {
        ///           &quot;dms:DbType&quot;: [
        ///             &quot;redis&quot;
        ///           ]
        ///         }
        ///       }
        ///     }
        ///   ],
        ///   &quot;Version&quot;: &quot;1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AbacPolicyContent")]
        [Validation(Required=false)]
        public string AbacPolicyContent { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AbacPolicyDesc")]
        [Validation(Required=false)]
        public string AbacPolicyDesc { get; set; }

        /// <summary>
        /// <para>The name of the policy. The name must be unique for the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy_test</para>
        /// </summary>
        [NameInMap("AbacPolicyName")]
        [Validation(Required=false)]
        public string AbacPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, go to the DMS console and move the pointer over the profile picture in the upper-right corner. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

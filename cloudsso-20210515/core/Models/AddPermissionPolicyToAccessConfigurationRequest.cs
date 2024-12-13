// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class AddPermissionPolicyToAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The configurations of the inline policy.</para>
        /// <para>The value can be up to 4,096 characters in length.</para>
        /// <para>If you set <c>PermissionPolicyType</c> to <c>Inline</c>, you must specify this parameter. For more information about the syntax and structure of RAM policies, see <a href="https://help.aliyun.com/document_detail/93739.html">Policy syntax and structure</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;<em>&quot;,&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: &quot;</em>&quot;}],&quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("InlinePolicyDocument")]
        [Validation(Required=false)]
        public string InlinePolicyDocument { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PermissionPolicyType</c> to <c>System</c>, you must set this parameter to the name of the system policy. You can obtain the name of the system policy from RAM.</description></item>
        /// <item><description>If you set <c>PermissionPolicyType</c> to <c>Inline</c>, you must set this parameter to the name of the inline policy. A custom value is supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSFullAccess</para>
        /// </summary>
        [NameInMap("PermissionPolicyName")]
        [Validation(Required=false)]
        public string PermissionPolicyName { get; set; }

        /// <summary>
        /// <para>The type of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System: system policy. Resource Access Management (RAM) system policies are reused.</description></item>
        /// <item><description>Inline: inline policy. Inline policies are created based on the RAM policy syntax and structure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("PermissionPolicyType")]
        [Validation(Required=false)]
        public string PermissionPolicyType { get; set; }

    }

}

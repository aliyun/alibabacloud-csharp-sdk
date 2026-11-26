// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class AddPermissionPolicyToAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00jhtfl8thteu6uj****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The content of the inline policy.</para>
        /// <para>Length: up to 4,096 characters.</para>
        /// <para>This parameter is required when PermissionPolicyType is set to Inline. For more information about the syntax and structure of an access policy, see <a href="https://help.aliyun.com/document_detail/93739.html">Access policy syntax and structure</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;<em>&quot;,&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: &quot;</em>&quot;}],&quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("InlinePolicyDocument")]
        [Validation(Required=false)]
        public string InlinePolicyDocument { get; set; }

        /// <summary>
        /// <para>The name of the access policy. Details:</para>
        /// <list type="bullet">
        /// <item><description>If PermissionPolicyType is set to System, this parameter specifies the name of the system policy. Because RAM system policies are reused, obtain the system policy name from RAM.</description></item>
        /// <item><description>If PermissionPolicyType is set to Inline, this parameter specifies the name of the inline policy. You can customize this parameter. The name can be up to 32 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSFullAccess</para>
        /// </summary>
        [NameInMap("PermissionPolicyName")]
        [Validation(Required=false)]
        public string PermissionPolicyName { get; set; }

        /// <summary>
        /// <para>The type of the access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System: system policy. System policies from Resource Access Management (RAM) are reused.</description></item>
        /// <item><description>Inline: inline policy. A custom policy written based on the syntax and structure of RAM access policies.</description></item>
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

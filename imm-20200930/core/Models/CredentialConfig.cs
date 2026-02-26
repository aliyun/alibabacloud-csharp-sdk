// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CredentialConfig : TeaModel {
        /// <summary>
        /// <para>The authorization chains. All roles in the array must have the <c>sts:AssumeRole</c> permission. You need to only grant other permissions, such as read and write permissions on OSS, to the last role in the array. You can grant permissions in the RAM console.</para>
        /// </summary>
        [NameInMap("Chain")]
        [Validation(Required=false)]
        public List<CredentialConfigChain> Chain { get; set; }
        public class CredentialConfigChain : TeaModel {
            /// <summary>
            /// <para>The ID of the account that you use to grant permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10232100246xxxxx</para>
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            /// <summary>
            /// <para>The RAM role that can be assumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunOSSRole</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The role type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: Alibaba Cloud account.</description></item>
            /// <item><description>service: Alibaba Cloud service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// <para>The policy that is attached to the role specified by the ServiceRole parameter. For example, the policy allows access to OSS. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: &quot;oss:<em>&quot;,&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: &quot;</em>&quot;}],&quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The service role in the account that is used to call an IMM API operation. The role must have the <c>sts:AssumeRole</c> permission. You can configure permissions for the role in the Resource Access Management (RAM) console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunSTSAssumeForIMMServiceRole</para>
        /// </summary>
        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

    }

}

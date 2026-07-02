// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class SetSecretPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The content of the secret policy. The value must be in the JSON format. The value can be up to 32,768 bytes in length.</para>
        /// <para>A secret policy contains the following elements:</para>
        /// <list type="bullet">
        /// <item><description><para>Version: The version of the secret policy. The value can only be 1.</para>
        /// </description></item>
        /// <item><description><para>Statement: The statement of the secret policy. Each secret policy can contain one or more statements.</para>
        /// </description></item>
        /// </list>
        /// <para>The following code shows the format of a secret policy:</para>
        /// <pre><c>{
        ///     &quot;Version&quot;: &quot;1&quot;,
        ///     &quot;Statement&quot;: [
        ///         {
        ///             &quot;Sid&quot;: &quot;Enable RAM User Permissions&quot;,
        ///             &quot;Effect&quot;: &quot;Allow&quot;,
        ///             &quot;Principal&quot;: {
        ///               &quot;RAM&quot;: [&quot;acs:ram::12345678****:*&quot;]
        ///             },
        ///             &quot;Action&quot;: [
        ///                 &quot;kms:*&quot;
        ///             ],
        ///             &quot;Resource&quot;: [
        ///                 &quot;*&quot;
        ///             ]
        ///         }
        ///     ]
        /// }
        /// </c></pre>
        /// <para>The following section describes the elements in a statement:</para>
        /// <list type="bullet">
        /// <item><description><para>Sid: Optional. The custom identifier of the statement. The value can be up to 128 characters in length and can contain uppercase letters (A-Z), lowercase letters (a-z), digits (0-9), and special characters, including underscores (_), forward slashes (/), equal signs (=), plus signs (+), periods (.), at signs (@), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Effect: Required. Specifies whether to allow or deny the permissions in the statement. Valid values: Allow and Deny.</para>
        /// </description></item>
        /// <item><description><para>Principal: Required. The principal that is authorized to access the secret. You can set this parameter to the current Alibaba Cloud account (the account to which the secret belongs), a RAM user or RAM role of the current Alibaba Cloud account, or a RAM user or RAM role of another Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>Action: Required. The API operations that are allowed or denied. The value must start with \<c>kms:\\</c>. For a list of supported operations, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>. If you specify an operation that is not in the list, the operation does not take effect.</para>
        /// </description></item>
        /// <item><description><para>Resource: Required. The value can only be \<c>\\*\\</c>, which indicates the current KMS secret.</para>
        /// </description></item>
        /// <item><description><para>Condition: Optional. The conditions for the authorization to take effect. You can use conditions to evaluate the context of an API request to determine whether a policy statement is applicable. The format is <c>&quot;Condition&quot;: {&quot;condition operator&quot;: {&quot;condition key&quot;: &quot;condition value&quot;}}</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you grant permissions to a RAM user or RAM role of another Alibaba Cloud account, you must go to the RAM console and use the Alibaba Cloud account to which the RAM user or RAM role belongs to grant the RAM user or RAM role the permissions to use the secret. For more information, see <a href="https://help.aliyun.com/document_detail/480682.html">Custom policies for KMS</a>, <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>, and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;: [{&quot;Sid&quot;:&quot;kms default secret policy&quot;,&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;: [&quot;acs:ram::119285303511****:<em>&quot;]},&quot;Action&quot;:[&quot;kms:</em>&quot;],&quot;Resource&quot;: [&quot;*&quot;] }] }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The name of the secret policy. The value can only be \<c>default\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The name or Alibaba Cloud Resource Name (ARN) of the secret.</para>
        /// <remarks>
        /// <para>When you access a secret in another Alibaba Cloud account, you must specify the ARN of the secret. The ARN of a secret is in the format of <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret_test</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}

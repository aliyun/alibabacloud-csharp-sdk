// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class SetKeyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID or Alibaba Cloud Resource Name (ARN) of the key.</para>
        /// <remarks>
        /// <para>To access a key of another Alibaba Cloud account, you must specify the ARN of the key. The key ARN is in the format of <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz630494463ejqjx****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The key policy. The policy is in the JSON format. The policy can be up to 32,768 bytes in length.</para>
        /// <para>A key policy contains the following elements:</para>
        /// <list type="bullet">
        /// <item><description><para>Version: The version of the key policy. The value can only be 1.</para>
        /// </description></item>
        /// <item><description><para>Statement: The statement of the key policy. Each key policy can contain one or more statements.</para>
        /// </description></item>
        /// </list>
        /// <para>The following code provides an example of a key policy:</para>
        /// <pre><c>{
        ///     &quot;Version&quot;: &quot;1&quot;,
        ///     &quot;Statement&quot;: [
        ///         {
        ///             &quot;Sid&quot;: &quot;Enable RAM User Permissions&quot;,
        ///             &quot;Effect&quot;: &quot;Allow&quot;,
        ///             &quot;Principal&quot;: {
        ///               &quot;RAM&quot;: [&quot;acs:ram::112890462****:*&quot;]
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
        /// <para>The following section describes the elements in a Statement:</para>
        /// <list type="bullet">
        /// <item><description><para>Sid: Optional. The custom statement identifier. The value can be up to 128 characters in length and can contain uppercase letters, lowercase letters, digits, and the following special characters: _ / + = . @ -.</para>
        /// </description></item>
        /// <item><description><para>Effect: Required. The effect of the policy statement. Valid values: Allow and Deny.</para>
        /// </description></item>
        /// <item><description><para>Principal: Required. The principal that is authorized to access the key. You can set this parameter to the current Alibaba Cloud account, a RAM user or RAM role of the current Alibaba Cloud account, or a RAM user or RAM role of another Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>Action: Required. The API operations that are allowed or denied. The value must start with kms:. For more information about the operations, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>. If you specify an operation that is not included in the list, the operation will not take effect.</para>
        /// </description></item>
        /// <item><description><para>Resource: Required. The key. The value can only be \*.</para>
        /// </description></item>
        /// <item><description><para>Condition: Optional. The conditions for the policy to take effect. You can use conditions to evaluate the context of an API request to determine whether the policy statement is applicable. The format is <c>&quot;Condition&quot;: {&quot;condition operator&quot;: {&quot;condition key&quot;: &quot;condition value&quot;}}</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you grant permissions to a RAM user or RAM role of another Alibaba Cloud account, you must use the Alibaba Cloud account to which the RAM user or RAM role belongs to grant the RAM user or RAM role the permissions to use the key in the RAM console. For more information, see <a href="https://help.aliyun.com/document_detail/480682.html">Custom policies for KMS</a>, <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>, and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;:[{&quot;Action&quot;:[&quot;kms:<em>&quot;],&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;:[&quot;acs:ram::119285303511</em><em>**:<em>&quot;]},&quot;Resource&quot;:[&quot;</em>&quot;],&quot;Sid&quot;:&quot;kms default key policy&quot;},{&quot;Action&quot;:[&quot;kms:List</em>&quot;,&quot;kms:Describe*&quot;,&quot;kms:Create*&quot;,&quot;kms:Enable*&quot;,&quot;kms:Disable*&quot;,&quot;kms:Get*&quot;,&quot;kms:Set*&quot;,&quot;kms:Update*&quot;,&quot;kms:Delete*&quot;,&quot;kms:Cancel*&quot;,&quot;kms:TagResource&quot;,&quot;kms:UntagResource&quot;,&quot;kms:ImportKeyMaterial&quot;,&quot;kms:ScheduleKeyDeletion&quot;],&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;:[&quot;acs:ram::119285303511****:user/for_test_policy&quot;]},&quot;Resource&quot;:[&quot;*&quot;]}],&quot;Version&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The name of the key policy. The name can only be \<c>default\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the KMS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-bjj62d8f5e0sgtx8h****</para>
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// <para>The description of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydbinfo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic rotation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic rotation.</description></item>
        /// <item><description>false: disables automatic rotation. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when SecretType is set to Rds (ApsaraDB RDS secret), PolarDB (PolarDB secret), Redis (Redis secret), RAMCredentials (RAM secret), or ECS (ECS secret). When SecretType is set to Generic (generic secret), automatic rotation is not supported. You can call the <a href="https://help.aliyun.com/document_detail/154503.html">PutSecretValue</a> operation to manually rotate the secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>The ID of the key used to encrypt the secret value.</para>
        /// <remarks>
        /// <para>The key and the secret must belong to the same KMS instance, and the key must be a symmetric key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key-gzz63ff0db5hg3qje****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret, which is used to specify the property of a specific secret type. The value can be up to 1,024 characters in length.</para>
        /// <list type="bullet">
        /// <item><description><para>When SecretType is set to Generic (generic secret), this parameter is ignored.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to Rds (ApsaraDB RDS secret), you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (required): the child class of the secret. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>SingleUser: specifies that Secrets Manager manages the ApsaraDB RDS secret in single-account pattern. During secret rotation, the password of the specified account is reset to a new random password.</description></item>
        /// <item><description>DoubleUsers: specifies that Secrets Manager manages the ApsaraDB RDS secret in dual-account pattern. ACSCurrent and ACSPrevious reference one account each. During secret rotation, the password of the account referenced by ACSPrevious is reset to a new random password, and then Secrets Manager swaps the accounts referenced by ACSCurrent and ACSPrevious.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>DBInstanceId (required): instance ID of the ApsaraDB RDS instance to which the account belongs.</para>
        /// </description></item>
        /// <item><description><para>CustomData (optional): custom data. The value is a JSON-formatted key-value pair. You can specify up to 10 key-value pairs, separated by commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. Default value: <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When SecretType is set to Redis (Redis secret), you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description>SecretSubType (required): the child class of the secret. Valid values:  <list type="bullet">
        /// <item><description>DoubleUsers: specifies that Secrets Manager manages the Redis secret in dual-account pattern. ACSCurrent and ACSPrevious reference one account each. During secret rotation, the password of the account referenced by ACSPrevious is reset to a new random password, and then Secrets Manager swaps the accounts referenced by ACSCurrent and ACSPrevious.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>AccountName (required): the database username.</description></item>
        /// <item><description>CloneAccountName (required): the database username, which is the value of AccountName appended with the <c>_clone</c> suffix.</description></item>
        /// <item><description>AccountPrivilege (required): the permissions to access the database.</description></item>
        /// <item><description>InstanceId (required): instance ID of the Redis instance.</description></item>
        /// <item><description>RegionId (required): the region ID of the Redis instance.</description></item>
        /// <item><description>CustomData (optional): custom data. The value is a JSON-formatted key-value pair. You can specify up to 10 key-value pairs, separated by commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. Default value: <c>{}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When SecretType is set to RAMCredentials (RAM secret), you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description>SecretSubType (required): the child class of the secret. Valid value: RamUserAccessKey.</description></item>
        /// <item><description>UserName (required): the name of the Resource Access Management (RAM) user.</description></item>
        /// <item><description>CustomData (optional): custom data. The value is a JSON-formatted key-value pair. You can specify up to 10 key-value pairs, separated by commas (,). Default value: <c>{}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When SecretType is set to ECS (ECS secret), you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (required): the child class of the secret. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>Password: ECS password.</description></item>
        /// <item><description>SSHKey: ECS SSH public and private keys.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>RegionId (required): the region ID of the ECS instance.  </para>
        /// </description></item>
        /// <item><description><para>InstanceId (required): instance ID of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>CustomData (optional): custom data. The value is a JSON-formatted key-value pair. You can specify up to 10 key-value pairs, separated by commas (,). Default value: <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>When SecretType is set to PolarDB, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (required): DoubleUsers (fixed value).</para>
        /// </description></item>
        /// <item><description><para>RegionId (required): the region ID.</para>
        /// </description></item>
        /// <item><description><para>DBClusterId (required): instance ID of the PolarDB cluster.</para>
        /// </description></item>
        /// <item><description><para>DBType (required): MySQL or PostgreSQL.</para>
        /// </description></item>
        /// <item><description><para>AccountName (required): the account name.</para>
        /// </description></item>
        /// <item><description><para>CloneAccountName: the value of AccountName appended with <c>_clone</c>.</para>
        /// </description></item>
        /// <item><description><para>AccountType: the account type. Only Normal is supported.</para>
        /// </description></item>
        /// <item><description><para>AccountPrivilege: the account permissions. This parameter is available only for MySQL.</para>
        /// </description></item>
        /// <item><description><para>DBName: the database name. This parameter is available only for MySQL.</para>
        /// </description></item>
        /// <item><description><para>CustomData (optional): custom data. The value is a JSON-formatted key-value pair. You can specify up to 10 key-value pairs, separated by commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. Default value: <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When SecretType is set to Rds, Redis, PolarDB, RAMCredentials, or ECS, you must set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SecretSubType&quot;:&quot;SingleUser&quot;, &quot;DBInstanceId&quot;:&quot;rm-bp1b3dd3a506e****&quot; ,&quot;CustomData&quot;:{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}}</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfigShrink { get; set; }

        /// <summary>
        /// <para>The content of the access policy in JSON format. The maximum length is 32,768 bytes.</para>
        /// <para>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>. If you do not specify this parameter, the default access policy is used.</para>
        /// <para>The access policy includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Version: the version of the access policy. Currently, only version 1 is supported.</description></item>
        /// <item><description>Statement: the statements in the access policy. Each access policy contains one or more statements.</description></item>
        /// </list>
        /// <para>The access policy uses the following format:</para>
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
        /// <para>Statement details:</para>
        /// <list type="bullet">
        /// <item><description><para>Sid: optional. The custom statement identifier. The value can be up to 128 characters in length and can contain uppercase letters (A-Z), lowercase letters (a-z), digits (0-9), and special characters (_/+=.@-).</para>
        /// </description></item>
        /// <item><description><para>Effect: required. Specifies whether to allow or deny the permissions in the policy statement. Valid values: Allow and Deny.</para>
        /// </description></item>
        /// <item><description><para>Principal: required. The principal to which the policy is attached. You can set this field to the current Alibaba Cloud account (the account to which the secret belongs), a RAM user or RAM role under the current Alibaba Cloud account, or a RAM user or RAM role under another Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>Action: required. The API operations to allow or deny. The value must start with &quot;kms:&quot;. For the list of available operations, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>. If you specify an operation that is not in the list, the setting does not take effect.</para>
        /// </description></item>
        /// <item><description><para>Resource: required. The value can only be *, which indicates the current KMS secret.</para>
        /// </description></item>
        /// <item><description><para>Condition: optional. The conditions that must be met for the authorization to take effect. You can use conditions to evaluate the context of an API request to determine whether the policy statement applies. The format is <c>&quot;Condition&quot;: {&quot;condition operator&quot;: {&quot;condition key&quot;: &quot;condition value&quot;}}</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you grant Resource Access Management (RAM) user or RAM role under another Alibaba Cloud account, you must also use the Alibaba Cloud account of the RAM user or RAM role to authorize them to use the secret in the RAM console. Only then can the RAM user or RAM role use the secret. For more information, see <a href="https://help.aliyun.com/document_detail/480682.html">Custom policy examples for Key Management Service</a>, <a href="https://help.aliyun.com/document_detail/116146.html">Grant Resource Access Management (RAM) user</a>, and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;: [{&quot;Sid&quot;:&quot;kms default secret policy&quot;,&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;: [&quot;acs:ram::119285303511****:<em>&quot;]},&quot;Action&quot;:[&quot;kms:</em>&quot;],&quot;Resource&quot;: [&quot;*&quot;] }] }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation. Valid values: 6 hours to 8,760 hours (365 days).<br>The value must be in the <c>integer[unit]</c> format. <c>integer</c> specifies the time length, and <c>unit</c> specifies the time unit.<br>Valid values for <c>unit</c>: d (days), h (hours), m (minutes), and s (seconds). For example, both 7d and 604,800s indicate a 7-day interval.  </para>
        /// <remarks>
        /// <para>You must set this parameter only when EnableAutomaticRotation is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30d</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The secret value. The value can be up to 30,720 bytes (30 KB) in length. KMS encrypts the value by using the specified key and stores it in the initial version.</para>
        /// <list type="bullet">
        /// <item><description><para>When SecretType is set to Generic (generic secret), you can customize the secret value.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to Rds (ApsaraDB RDS secret), the secret value must be in the following format: <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}]}</c>. <c>AccountName</c> specifies the username of the ApsaraDB RDS instance, and <c>AccountPassword</c> specifies the password of the account.  </para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to Redis (Redis secret), set this parameter to <c>$Auto</c>.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to RAMCredentials (RAM secret), the secret value must be in the following format: <c>{&quot;AccessKeys&quot;:[{&quot;AccessKeyId&quot;:&quot;&quot;,&quot;AccessKeySecret&quot;:&quot;&quot;}]}</c>. <c>AccessKeyId</c> specifies the AccessKey ID, and <c>AccessKeySecret</c> specifies the AccessKey secret. You must specify all AccessKey pairs of the Resource Access Management (RAM) user.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to PolarDB, set this parameter to <c>$Auto</c>.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to ECS (ECS secret), the secret value must be in one of the following formats:  </para>
        /// <list type="bullet">
        /// <item><description><para>When SecretSubType in the ExtendedConfig parameter is set to Password: <c>{&quot;UserName&quot;:&quot;&quot;,&quot;Password&quot;: &quot;&quot;}</c>. <c>UserName</c> specifies the username used to log on to the ECS instance, and <c>Password</c> specifies the logon password.  </para>
        /// </description></item>
        /// <item><description><para>When SecretSubType in the ExtendedConfig parameter is set to SSHKey: <c>{&quot;UserName&quot;:&quot;&quot;,&quot;PublicKey&quot;: &quot;&quot;, &quot;PrivateKey&quot;: &quot;&quot;}</c>. <c>PublicKey</c> specifies the SSH public key used to log on to the ECS instance, and <c>PrivateKey</c> specifies the private key.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;user1&quot;,&quot;AccountPassword&quot;:&quot;****&quot;}]}</para>
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The type of the secret value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text: text. This is the default value.</description></item>
        /// <item><description>binary: binary data.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When SecretType is set to Rds, Redis, PolarDB, RAMCredentials, or ECS, SecretDataType can only be set to text.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The secret name. The secret name must be unique within the current region.
        /// The name can be up to 192 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The naming requirements vary based on the secret type:  </para>
        /// <list type="bullet">
        /// <item><description><para>When SecretType is set to Generic (generic secret), Rds (ApsaraDB RDS secret), or Redis (Redis or Tair secret), the name cannot start with <c>acs/</c>.  </para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to RAMCredentials (RAM secret), use the fixed value <c>$Auto</c>. In this case, KMS automatically generates the secret name, which starts with <c>acs/ram/user/</c> and includes the display name of the Resource Access Management (RAM) user.</para>
        /// </description></item>
        /// <item><description><para>When SecretType is set to ECS (ECS secret), the name must start with <c>acs/ecs/</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydbconninfo</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The type of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Generic: generic secret. This is the default value.  </para>
        /// </description></item>
        /// <item><description><para>Rds: ApsaraDB RDS secret.  </para>
        /// </description></item>
        /// <item><description><para>Redis: Redis secret.</para>
        /// </description></item>
        /// <item><description><para>RAMCredentials: RAM secret.  </para>
        /// </description></item>
        /// <item><description><para>ECS: ECS secret.</para>
        /// </description></item>
        /// <item><description><para>PolarDB: PolarDB secret.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Rds</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The tags of the secret. Each tag is a key-value pair that consists of a tag key and a tag value.</para>
        /// <para>The tag key and tag value can be up to 128 characters in length and can contain uppercase and lowercase letters, digits, forward slashes (/), backslashes (\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).</para>
        /// <list type="bullet">
        /// <item><description><para>A tag key cannot start with aliyun or acs:.</para>
        /// </description></item>
        /// <item><description><para>You can add up to 20 tags to each secret.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;TagKey\&quot;:\&quot;key1\&quot;,\&quot;TagValue\&quot;:\&quot;val1\&quot;},{\&quot;TagKey\&quot;:\&quot;key2\&quot;,\&quot;TagValue\&quot;:\&quot;val2\&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The version ID of the initial version. The version ID must be unique within the secret.
        /// The version ID can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

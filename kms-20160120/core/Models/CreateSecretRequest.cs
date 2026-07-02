// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS instance.</para>
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
        /// <item><description><para>true: enables automatic rotation.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables automatic rotation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if SecretType is set to Rds, PolarDB, Redis, RAMCredentials, or ECS. If SecretType is set to Generic, automatic rotation is not supported. You can call the <a href="https://help.aliyun.com/document_detail/154503.html">PutSecretValue</a> operation to manually rotate the secret.</para>
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
        /// <para>The key and the secret must be in the same KMS instance. The key must be a symmetric key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key-gzz63ff0db5hg3qje****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret. This parameter specifies the properties of the secret of a specific type. The value can be up to 1,024 characters in length.</para>
        /// <list type="bullet">
        /// <item><description><para>If SecretType is set to Generic, this parameter is ignored.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to Rds, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (Required): The subtype of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SingleUser: Secrets Manager manages the RDS secret in single-account mode. When the secret is rotated, the password of the specified account is reset to a new random password.</para>
        /// </description></item>
        /// <item><description><para>DoubleUsers: Secrets Manager manages the RDS secret in double-account mode. ACSCurrent and ACSPrevious point to one of the accounts. When the secret is rotated, the password of the account pointed to by ACSPrevious is reset to a new random password. Then, Secrets Manager swaps the accounts that ACSCurrent and ACSPrevious point to.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>DBInstanceId (Required): The ID of the RDS instance to which the account belongs.</para>
        /// </description></item>
        /// <item><description><para>CustomData (Optional): The custom data. The value is a key-value pair in the JSON format. You can specify up to 10 key-value pairs. Separate multiple key-value pairs with commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. The default value is <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If SecretType is set to Redis, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (Required): The subtype of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DoubleUsers: Secrets Manager manages the Redis secret in double-account mode. ACSCurrent and ACSPrevious point to one of the accounts. When the secret is rotated, the password of the account pointed to by ACSPrevious is reset to a new random password. Then, Secrets Manager swaps the accounts that ACSCurrent and ACSPrevious point to.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>AccountName (Required): The database username.</para>
        /// </description></item>
        /// <item><description><para>CloneAccountName (Required): The database username, which is the value of AccountName with the <c>_clone</c> suffix.</para>
        /// </description></item>
        /// <item><description><para>AccountPrivilege (Required): The permissions to access the database.</para>
        /// </description></item>
        /// <item><description><para>InstanceId (Required): The ID of the Redis instance.</para>
        /// </description></item>
        /// <item><description><para>RegionId (Required): The ID of the region where the Redis instance resides.</para>
        /// </description></item>
        /// <item><description><para>CustomData (Optional): The custom data. The value is a key-value pair in the JSON format. You can specify up to 10 key-value pairs. Separate multiple key-value pairs with commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. The default value is <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If SecretType is set to RAMCredentials, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (Required): The subtype of the secret. The value is RamUserAccessKey.</para>
        /// </description></item>
        /// <item><description><para>UserName (Required): The name of the RAM user.</para>
        /// </description></item>
        /// <item><description><para>CustomData (Optional): The custom data. The value is a key-value pair in the JSON format. You can specify up to 10 key-value pairs. Separate multiple key-value pairs with commas (,). The default value is <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If SecretType is set to ECS, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (Required): The subtype of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Password: an ECS password.</para>
        /// </description></item>
        /// <item><description><para>SSHKey: an ECS SSH key pair.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>RegionId (Required): The ID of the region where the ECS instance resides.</para>
        /// </description></item>
        /// <item><description><para>InstanceId (Required): The ID of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>CustomData (Optional): The custom data. The value is a key-value pair in the JSON format. You can specify up to 10 key-value pairs. Separate multiple key-value pairs with commas (,). The default value is <c>{}</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If SecretType is set to PolarDB, you must specify the following parameters in ExtendedConfig:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType (Required): The fixed value is DoubleUsers.</para>
        /// </description></item>
        /// <item><description><para>RegionId (Required): The region.</para>
        /// </description></item>
        /// <item><description><para>DBClusterId (Required): The ID of the PolarDB instance.</para>
        /// </description></item>
        /// <item><description><para>DBType (Required): MySQL or PostgreSQL.</para>
        /// </description></item>
        /// <item><description><para>AccountName (Required): The account name.</para>
        /// </description></item>
        /// <item><description><para>CloneAccountName: The value is AccountName_clone.</para>
        /// </description></item>
        /// <item><description><para>AccountType: Only Normal is supported.</para>
        /// </description></item>
        /// <item><description><para>AccountPrivilege: This parameter is available only for MySQL.</para>
        /// </description></item>
        /// <item><description><para>DBName: This parameter is available only for MySQL.</para>
        /// </description></item>
        /// <item><description><para>CustomData (Optional): The custom data. The value is a key-value pair in the JSON format. You can specify up to 10 key-value pairs. Separate multiple key-value pairs with commas (,). Example: {&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}. The default value is {}.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If SecretType is set to Rds, Redis, PolarDB, RAMCredentials, or ECS, you must configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SecretSubType&quot;:&quot;SingleUser&quot;, &quot;DBInstanceId&quot;:&quot;rm-bp1b3dd3a506e****&quot; ,&quot;CustomData&quot;:{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}}</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendedConfig { get; set; }

        /// <summary>
        /// <para>The content of the secret policy. The value is in the JSON format. The value can be up to 32,768 bytes in length.</para>
        /// <para>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>. If you do not specify this parameter, the default secret policy is used.</para>
        /// <para>A secret policy contains the following parts:</para>
        /// <list type="bullet">
        /// <item><description><para>Version: The version of the secret policy. Only 1 is supported.</para>
        /// </description></item>
        /// <item><description><para>Statement: The statements of the secret policy. Each secret policy can contain one or more statements.</para>
        /// </description></item>
        /// </list>
        /// <para>The following is the format of a secret policy:</para>
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
        /// <para>Details about a statement:</para>
        /// <list type="bullet">
        /// <item><description><para>Sid: (Optional) The custom identifier of the statement. The value can be up to 128 characters in length and can contain uppercase letters (A-Z), lowercase letters (a-z), digits (0-9), and special characters, including underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), at signs (@), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Effect: (Required) The effect of the policy statement. Valid values: Allow and Deny.</para>
        /// </description></item>
        /// <item><description><para>Principal: (Required) The principal that is authorized by the policy. You can specify the current Alibaba Cloud account (the account to which the secret belongs), a RAM user or RAM role of the current Alibaba Cloud account, or a RAM user or RAM role of another Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>Action: (Required) The API operations that are allowed or denied. The value must start with &quot;kms:&quot;. For the list of supported operations, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>. If you specify an operation that is not in the list, the setting does not take effect.</para>
        /// </description></item>
        /// <item><description><para>Resource: (Required) The resource. The value can only be \*, which indicates the current KMS secret.</para>
        /// </description></item>
        /// <item><description><para>Condition: (Optional) The conditions for the authorization to take effect. You can use conditions to evaluate the context of an API request to determine whether to apply the policy statement. The format is <c>&quot;Condition&quot;: {&quot;condition operator&quot;: {&quot;condition key&quot;: &quot;condition value&quot;}}</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2716465.html">Overview of secret policies</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After you grant permissions to a RAM user or RAM role of another Alibaba Cloud account, you must use the Alibaba Cloud account to which the RAM user or RAM role belongs to grant the RAM user or RAM role the permissions to use the secret in the RAM console. Then, the RAM user or RAM role can use the secret. For more information, see <a href="https://help.aliyun.com/document_detail/480682.html">Custom policies for KMS</a>, <a href="https://help.aliyun.com/document_detail/116146.html">Grant permissions to a RAM user</a>, and <a href="https://help.aliyun.com/document_detail/116147.html">Grant permissions to a RAM role</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;: [{&quot;Sid&quot;:&quot;kms default secret policy&quot;,&quot;Effect&quot;:&quot;Allow&quot;,&quot;Principal&quot;:{&quot;RAM&quot;: [&quot;acs:ram::119285303511****:<em>&quot;]},&quot;Action&quot;:[&quot;kms:</em>&quot;],&quot;Resource&quot;: [&quot;*&quot;] }] }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation. The value is in the range of 6 hours to 8,760 hours (365 days).<br>
        /// The value is in the <c>integer[unit]</c> format. <c>integer</c> indicates the interval. <c>unit</c> indicates the unit of time.<br>
        /// Valid values for unit: d (day), h (hour), m (minute), and s (second). For example, both 7d and 604,800s indicate a rotation interval of 7 days.<br><br></para>
        /// <remarks>
        /// <para>You must specify this parameter if you set EnableAutomaticRotation to true. You do not need to specify this parameter if you set EnableAutomaticRotation to false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30d</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The value of the secret. The value can be up to 30,720 bytes (30 KB) in length. KMS encrypts the secret value with the specified key and stores the encrypted value in the initial version.</para>
        /// <list type="bullet">
        /// <item><description><para>If SecretType is set to Generic, you can specify a custom secret value.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to Rds, the secret value must be in the following format: <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}]}</c>. In the format, <c>AccountName</c> specifies the username of the account for the RDS instance and <c>AccountPassword</c> specifies the password of the account.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to Redis, set this parameter to <c>$Auto</c>.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to RAMCredentials, the secret value must be in the following format: <c>{&quot;AccessKeys&quot;:[{&quot;AccessKeyId&quot;:&quot;&quot;,&quot;AccessKeySecret&quot;:&quot;&quot;}]}</c>. In the format, <c>AccessKeyId</c> specifies the AccessKey ID and <c>AccessKeySecret</c> specifies the AccessKey secret. You must specify all AccessKey pairs of the RAM user.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to PolarDB, set this parameter to <c>$Auto</c>.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to ECS, the secret value must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><para>If SecretSubType in the ExtendedConfig parameter is set to Password: <c>{&quot;UserName&quot;:&quot;&quot;,&quot;Password&quot;: &quot;&quot;}</c>. In the format, <c>UserName</c> specifies the username used to log on to the ECS instance and <c>Password</c> specifies the password used to log on to the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>If SecretSubType in the ExtendedConfig parameter is set to SSHKey: <c>{&quot;UserName&quot;:&quot;&quot;,&quot;PublicKey&quot;: &quot;&quot;, &quot;PrivateKey&quot;: &quot;&quot;}</c>. In the format, <c>PublicKey</c> specifies the SSH-formatted public key used to log on to the ECS instance and <c>PrivateKey</c> specifies the private key used to log on to the ECS instance.</para>
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
        /// <item><description><para>text (default): The secret value is a text string.</para>
        /// </description></item>
        /// <item><description><para>binary: The secret value is a binary string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If SecretType is set to Rds, Redis, PolarDB, RAMCredentials, or ECS, SecretDataType must be set to text.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The name of the secret. The name must be unique in the same region.
        /// The name can be up to 192 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following limits apply to secret names for different types of secrets:</para>
        /// <list type="bullet">
        /// <item><description><para>If SecretType is set to Generic, Rds, or Redis, the name cannot start with <c>acs/</c>.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to RAMCredentials, set this parameter to the fixed value <c>$Auto</c>. In this case, KMS automatically generates a secret name that starts with <c>acs/ram/user/</c> and contains the display name of the RAM user.</para>
        /// </description></item>
        /// <item><description><para>If SecretType is set to ECS, the name must start with <c>acs/ecs/</c>.</para>
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
        /// <item><description><para>Generic (default): a generic secret.</para>
        /// </description></item>
        /// <item><description><para>Rds: an RDS secret.</para>
        /// </description></item>
        /// <item><description><para>Redis: a Redis secret.</para>
        /// </description></item>
        /// <item><description><para>RAMCredentials: a RAM secret.</para>
        /// </description></item>
        /// <item><description><para>ECS: an ECS secret.</para>
        /// </description></item>
        /// <item><description><para>PolarDB: a PolarDB secret.</para>
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
        /// <para>The tags of the secret. Each tag consists of a key-value pair. A tag consists of a tag key and a tag value.</para>
        /// <para>The tag key and tag value can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).</para>
        /// <list type="bullet">
        /// <item><description><para>The tag key cannot start with aliyun or acs:.</para>
        /// </description></item>
        /// <item><description><para>You can specify up to 20 key-value pairs for each secret.</para>
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
        /// <para>The version number of the initial version. The version number must be unique within the secret.
        /// The version number can be up to 64 characters in length.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The version number of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-bjj62d8f5e0sgtx8h****</para>
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic rotation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: specifies to enable automatic rotation.</description></item>
        /// <item><description>false: specifies to disable automatic rotation. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid if you set the SecretType parameter to Rds, RAMCredentials, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mydbinfo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic rotation is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: indicates that automatic rotation is enabled.</description></item>
        /// <item><description>Disabled: indicates that automatic rotation is disabled.</description></item>
        /// <item><description>Invalid: indicates that the status of automatic rotation is abnormal. In this case, Secrets Manager cannot automatically rotate the secret.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned if you set the SecretType parameter to Rds, RAMCredentials, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>The description of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00aa68af-2c02-4f68-95fe-3435d330****</para>
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SecretSubType&quot;:&quot;SingleUser&quot;, &quot;DBInstanceId&quot;:&quot;rm-bp1b3dd3a506e****&quot; ,&quot;CustomData&quot;:{}}</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendedConfig { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30d</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The tags of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The type of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Generic: specifies a generic secret.</description></item>
        /// <item><description>Rds: specifies a managed ApsaraDB RDS secret.</description></item>
        /// <item><description>RAMCredentials: specifies a managed RAM secret.</description></item>
        /// <item><description>ECS: specifies a managed ECS secret.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret. This parameter specifies the properties of the secret of the specific type. The description can be up to 1,024 characters in length.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the SecretType parameter to Generic, you do not need to configure this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to Rds, configure the following fields for the ExtendedConfig parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType: required. The subtype of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SingleUser: Secrets Manager manages the ApsaraDB RDS secret in single-account mode. When the secret is rotated, the password of the specified account is reset to a new random password.</description></item>
        /// <item><description>DoubleUsers: Secrets Manager manages the ApsaraDB RDS secret in dual-account mode. One account is referenced by the ACSCurrent version, and the other account is referenced by the ACSPrevious version. When the secret is rotated, the password of the account referenced by the ACSPrevious version is reset to a new random password. Then, Secrets Manager switches the referenced accounts between the ACSCurrent and ACSPrevious versions.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>DBInstanceId: required. The ApsaraDB RDS instance to which the ApsaraDB RDS account belongs.</para>
        /// </description></item>
        /// <item><description><para>CustomData: optional. The custom data. The value is a collection of key-value pairs in the JSON format. Up to 10 key-value pairs can be specified. Separate multiple key-value pairs with commas (,). Example: <c>{&quot;Key1&quot;: &quot;v1&quot;, &quot;fds&quot;:&quot;fdsf&quot;}</c>. The default value is a pair of empty braces (<c>{}</c>).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to RAMCredentials, configure the following fields for the ExtendedConfig parameter:</para>
        /// <list type="bullet">
        /// <item><description>SecretSubType: required. The subtype of the secret. Set the value to RamUserAccessKey.</description></item>
        /// <item><description>UserName: required. The name of the RAM user.</description></item>
        /// <item><description>CustomData: optional. The custom data. The value is a collection of key-value pairs in the JSON format. Up to 10 key-value pairs can be specified. Separate multiple key-value pairs with commas (,). The default value is a pair of empty braces (<c>{}</c>).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to ECS, configure the following fields for the ExtendedConfig parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>SecretSubType: required. The subtype of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Password: the password that is used to log on to the ECS instance.</description></item>
        /// <item><description>SSHKey: the SSH public key and private key that are used to log on to the ECS instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>RegionId: required. The ID of the region in which the ECS instance resides.</para>
        /// </description></item>
        /// <item><description><para>InstanceId: required. The ID of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>CustomData: optional. The custom data. The value is a collection of key-value pairs in the JSON format. Up to 10 key-value pairs can be specified. Separate multiple key-value pairs with commas (,). The default value is a pair of empty braces (<c>{}</c>).</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you set the SecretType parameter to Rds, RAMCredentials, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The value of the secret that you want to create. Secrets Manager encrypts the secret value and stores the encrypted value in the initial version.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the SecretType parameter to Generic that indicates a generic secret, you can customize the secret value.</para>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to Rds that indicates a managed ApsaraDB RDS secret, the secret value must be in the format of <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}]}</c>. In the preceding format, <c>AccountName</c> indicates the username of the account that is used to connect to your ApsaraDB RDS instance, and <c>AccountPassword</c> specifies the password of the account.</para>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to RAMCredentials that indicates a managed RAM secret, the secret value must be in the format of <c>{&quot;AccessKeys&quot;:[{&quot;AccessKeyId&quot;:&quot;&quot;,&quot;AccessKeySecret&quot;:&quot;&quot;,}]}</c>. In the preceding format, <c>AccessKeyId</c> indicates the AccessKey ID of the RAM user and <c>AccessKeySecret</c> specifies the AccessKey secret of the RAM user. You must specify all the AccessKey pairs of the RAM user.</para>
        /// </description></item>
        /// <item><description><para>If you set the SecretType parameter to ECS that indicates a managed ECS secret, the secret value must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;UserName&quot;:&quot;&quot;,&quot;Password&quot;: &quot;&quot;}</c>: In the format, <c>UserName</c> specifies the username that is used to log on to the ECS instance, and <c>Password</c> specifies the password that is used to log on to the ECS instance.</description></item>
        /// <item><description><c>{&quot;UserName&quot;:&quot;&quot;,&quot;PublicKey&quot;: &quot;&quot;, &quot;PrivateKey&quot;: &quot;&quot;}</c>: In the format, <c>PublicKey</c> indicates the SSH public key that is used to log on to the ECS instance, and <c>PrivateKey</c> specifies the SSH private key that is used to log on to the ECS instance.</description></item>
        /// </list>
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
        /// <para>The ID of the dedicated KMS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rds</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation. Valid values: 6 hours to 8,760 hours (365 days).</para>
        /// <para>The value is in the <c>integer[unit]</c> format.</para>
        /// <para>The unit can be d (day), h (hour), m (minute), or s (second). For example, both 7d and 604800s indicate a seven-day interval.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the EnableAutomaticRotation parameter to true. This parameter is ignored if you set the EnableAutomaticRotation parameter to false or if the EnableAutomaticRotation parameter is not configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;TagKey\&quot;:\&quot;key1\&quot;,\&quot;TagValue\&quot;:\&quot;val1\&quot;},{\&quot;TagKey\&quot;:\&quot;key2\&quot;,\&quot;TagValue\&quot;:\&quot;val2\&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The type of the secret value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text</description></item>
        /// <item><description>binary</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the SecretType parameter to Rds, RAMCredentials, or ECS, the SecretDataType parameter must be set to text.</para>
        /// </remarks>
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

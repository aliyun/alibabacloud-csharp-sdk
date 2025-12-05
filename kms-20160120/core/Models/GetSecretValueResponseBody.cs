// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic rotation is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: indicates that automatic rotation is enabled.</description></item>
        /// <item><description>Disabled: indicates that automatic rotation is disabled.</description></item>
        /// <item><description>Invalid: indicates that the status of automatic rotation is abnormal. In this case, Secrets Manager cannot automatically rotate the secret.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The time when the secret was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-21T15:39:26Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The extended configuration of the secret.</para>
        /// <remarks>
        /// <para> This parameter is returned if you set the FetchExtendedConfig parameter to true. This parameter is returned only for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SecretSubType\&quot;:\&quot;SingleUser\&quot;, \&quot;DBInstanceId\&quot;:\&quot;rm-uf667446pc955****\&quot;,  \&quot;CustomData\&quot;:{} }</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// <para>The time when the last rotation was performed.</para>
        /// <remarks>
        /// <para> This parameter is returned if the secret was rotated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-05T08:22:03Z</para>
        /// </summary>
        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        /// <summary>
        /// <para>The time when the next rotation will be performed.</para>
        /// <remarks>
        /// <para> This parameter is returned if automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a3e9c36-1150-4881-84d3-eb8672fcafad</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation.</para>
        /// <para>The value is in the <c>integer[unit]</c> format. The <c>unit</c> field has a fixed value of s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.</para>
        /// <remarks>
        /// <para> This parameter is returned if automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>604800s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The secret value. Secrets Manager decrypts the ciphertext of the secret value and returns the plaintext of the secret value in this parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>For a generic secret, the secret value of the specified version is returned.</para>
        /// </description></item>
        /// <item><description><para>For a managed ApsaraDB RDS secret, the value is returned in the following format:<c>{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}</c> .</para>
        /// </description></item>
        /// <item><description><para>For a managed RAM secret, the secret value is returned in the following format: <c>{&quot;AccessKeyId&quot;:&quot;Adfdsfd&quot;,&quot;AccessKeySecret&quot;:&quot;fdsfdsf&quot;,&quot;GenerateTimestamp&quot;: &quot;2016-03-25T10:42:40Z&quot;}</c>.</para>
        /// </description></item>
        /// <item><description><para>For a managed ECS secret, the secret value is returned in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description><c>{&quot;UserName&quot;:&quot;root&quot;,&quot;Password&quot;:&quot;H5asdasdsads****&quot;}</c>: The secret value is returned in this format if the ECS secret is a password.</description></item>
        /// <item><description><c>{&quot;UserName&quot;:&quot;root&quot;,&quot;PublicKey&quot;:&quot;ssh-rsa ****mKwnVix9YTFY9Rs= imported-openssh-key&quot;,&quot;PrivateKey&quot;: &quot;d6bee1cb-2e14-4277-ba6b-73786b21****&quot;}</c>: The secret value is returned in this format is the ECS secret is a pair of SSH keys. The private key is in the Privacy Enhanced Mail (PEM) format.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testdata1</para>
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The type of the secret value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>text</description></item>
        /// <item><description>binary</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>binary</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The type of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Generic: indicates a generic secret.</description></item>
        /// <item><description>Rds: indicates a managed ApsaraDB RDS secret.</description></item>
        /// <item><description>RAMCredentials: indicates a managed RAM secret.</description></item>
        /// <item><description>ECS: indicates a managed ECS secret.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Generic</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The version number of the secret value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000000000000000000000000001</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The stage labels that mark the secret versions.</para>
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public GetSecretValueResponseBodyVersionStages VersionStages { get; set; }
        public class GetSecretValueResponseBodyVersionStages : TeaModel {
            [NameInMap("VersionStage")]
            [Validation(Required=false)]
            public List<string> VersionStage { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether automatic rotation is enabled. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>Enabled: Automatic rotation is enabled.  </description></item>
        /// <item><description>Disabled: Automatic rotation is disabled.  </description></item>
        /// <item><description>Invalid: The rotation status is abnormal, and KMS cannot automatically rotate the credential for you.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for RDS credentials, PolarDB credentials, Redis/Tair credentials, RAM credentials, or ECS credentials.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// <para>The time when the credential was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-02-21T15:39:26Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The extended configuration of the credential.  </para>
        /// <remarks>
        /// <para>This parameter is returned only for RDS credentials, PolarDB credentials, Redis/Tair credentials, RAM credentials, or ECS credentials when FetchExtendedConfig is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;SecretSubType\&quot;:\&quot;SingleUser\&quot;, \&quot;DBInstanceId\&quot;:\&quot;rm-uf667446pc955****\&quot;,  \&quot;CustomData\&quot;:{} }</para>
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// <para>The time of the most recent rotation.  </para>
        /// <remarks>
        /// <para>This parameter is returned only if the credential has been rotated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-07-05T08:22:03Z</para>
        /// </summary>
        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        /// <summary>
        /// <para>The time of the next rotation.  </para>
        /// <remarks>
        /// <para>This parameter is returned only when automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-06T18:22:03Z</para>
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// <para>The ID of the current request. Alibaba Cloud generates a unique identifier for each request, which can be used for troubleshooting and issue tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a3e9c36-1150-4881-84d3-eb8672fcafad</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The epoch for automatic credential rotation.<br>The format is <c>integer[unit]</c>, where <c>integer</c> indicates the time duration and <c>unit</c> indicates the time unit. Valid value for <c>unit</c>: s (seconds). For example, a 7-day rotation epoch is 604800s.</para>
        /// <remarks>
        /// <para>This parameter is returned only when automatic rotation is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>604800s</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The value of the credential. KMS decrypts the stored ciphertext and returns this parameter.  </para>
        /// <list type="bullet">
        /// <item><description><para>For generic secrets, the credential value you specified is returned.  </para>
        /// </description></item>
        /// <item><description><para>For RDS credentials and Redis/Tair credentials, the credential value is in the format: <c>{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}</c>.  </para>
        /// </description></item>
        /// <item><description><para>For RAM credentials, the credential value is in the format: <c>{&quot;AccessKeyId&quot;:&quot;Adfdsfd&quot;,&quot;AccessKeySecret&quot;:&quot;fdsfdsf&quot;,&quot;GenerateTimestamp&quot;: &quot;2023-03-25T10:42:40Z&quot;}</c>.  </para>
        /// </description></item>
        /// <item><description><para>For ECS credentials, the credential value is in one of the following formats:  </para>
        /// <list type="bullet">
        /// <item><description>Security token type: <c>{&quot;UserName&quot;:&quot;ecs-user&quot;,&quot;Password&quot;:&quot;H5asdasdsads****&quot;}</c>.  </description></item>
        /// <item><description>Public-private key pair type (private key in PEM format): <c>{&quot;UserName&quot;:&quot;ecs-user&quot;,&quot;PublicKey&quot;:&quot;ssh-rsa ****mKwnVix9YTFY9Rs= imported-openssh-key&quot;,&quot;PrivateKey&quot;: &quot;d6bee1cb-2e14-4277-ba6b-73786b21****&quot;}</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For PolarDB credentials, the credential value is in the format: <c>{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}</c>.</para>
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
        /// <para>The value type of the credential. Valid values:</para>
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
        /// <para>The name of the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The type of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Generic: generic secret.  </description></item>
        /// <item><description>Rds: RDS credential.  </description></item>
        /// <item><description>Redis: Redis/Tair credential.</description></item>
        /// <item><description>RAMCredentials: RAM credential.  </description></item>
        /// <item><description>ECS: ECS credential.</description></item>
        /// <item><description>PolarDB: PolarDB credential.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Generic</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// <para>The version number of the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

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

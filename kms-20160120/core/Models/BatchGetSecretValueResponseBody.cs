// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class BatchGetSecretValueResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of errors for secrets that failed to be retrieved.</para>
        /// </summary>
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<BatchGetSecretValueResponseBodyErrors> Errors { get; set; }
        public class BatchGetSecretValueResponseBodyErrors : TeaModel {
            /// <summary>
            /// <para>The service error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Forbidden.ResourceNotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned for the error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("HttpStatus")]
            [Validation(Required=false)]
            public int? HttpStatus { get; set; }

            /// <summary>
            /// <para>The error message for the failed secret retrieval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource not found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The secret name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret002</para>
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8252db58-2036-408c-a3d5-56e656dc2551</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of secrets that are successfully retrieved.</para>
        /// </summary>
        [NameInMap("SecretValues")]
        [Validation(Required=false)]
        public List<BatchGetSecretValueResponseBodySecretValues> SecretValues { get; set; }
        public class BatchGetSecretValueResponseBodySecretValues : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic rotation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: Automatic rotation is enabled.</description></item>
            /// <item><description>Disabled: Automatic rotation is disabled.</description></item>
            /// <item><description>Invalid: The rotation status is abnormal. KMS cannot automatically rotate the secret.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, RAM secrets, or ECS secrets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("AutomaticRotation")]
            [Validation(Required=false)]
            public string AutomaticRotation { get; set; }

            /// <summary>
            /// <para>The time when the secret was created (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-21T15:39:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The extended configuration of the secret.  </para>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, RAM secrets, or ECS secrets when FetchExtendedConfig is set to true.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;SecretSubType\&quot;:\&quot;SingleUser\&quot;, \&quot;DBInstanceId\&quot;:\&quot;rm-uf667446pc955****\&quot;,  \&quot;CustomData\&quot;:{} }</para>
            /// </summary>
            [NameInMap("ExtendedConfig")]
            [Validation(Required=false)]
            public string ExtendedConfig { get; set; }

            /// <summary>
            /// <para>The time of the most recent rotation (UTC).</para>
            /// <remarks>
            /// <para>This parameter is returned only when the secret has been rotated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-05T08:22:03Z</para>
            /// </summary>
            [NameInMap("LastRotationDate")]
            [Validation(Required=false)]
            public string LastRotationDate { get; set; }

            /// <summary>
            /// <para>The time of the next rotation (UTC).</para>
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
            /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for troubleshooting purposes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8252db58-2036-408c-a3d5-56e656dc2551</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The interval for automatic rotation of the secret.
            /// The format is integer[unit], where integer specifies the duration and unit specifies the time unit. The value of unit is s (seconds). For example, a rotation interval of 7 days is 604800s.</para>
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
            /// <para>The secret value. KMS decrypts the stored ciphertext secret value and returns this parameter.  </para>
            /// <list type="bullet">
            /// <item><description><para>A generic secret returns the secret value that you specified.</para>
            /// </description></item>
            /// <item><description><para>An ApsaraDB RDS secret or Redis/Tair secret returns the secret value in the following format: <c>{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}</c>.</para>
            /// </description></item>
            /// <item><description><para>A RAM secret returns the secret value in the following format: <c>{&quot;AccessKeyId&quot;:&quot;Adfdsfd&quot;,&quot;AccessKeySecret&quot;:&quot;fdsfdsf&quot;,&quot;GenerateTimestamp&quot;: &quot;2023-03-25T10:42:40Z&quot;}</c>.  </para>
            /// </description></item>
            /// <item><description><para>An ECS secret returns the secret value in the following formats:  </para>
            /// <list type="bullet">
            /// <item><description>Password-type secret: <c>{&quot;UserName&quot;:&quot;ecs-user&quot;,&quot;Password&quot;:&quot;H5asdasdsads****&quot;}</c>.  </description></item>
            /// <item><description>Public-private key-type secret (private key in PEM format): <c>{&quot;UserName&quot;:&quot;ecs-user&quot;,&quot;PublicKey&quot;:&quot;ssh-rsa ****mKwnVix9YTFY9Rs= imported-openssh-key&quot;,&quot;PrivateKey&quot;: &quot;d6bee1cb-2e14-4277-ba6b-73786b21****&quot;}</c>.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>A PolarDB secret returns the secret value in the following format: <c>{&quot;AccountName&quot;:&quot;&quot;,&quot;AccountPassword&quot;:&quot;&quot;}</c>.</para>
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
            /// <para>The secret name.</para>
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
            /// <item><description>Generic: generic secret.  </description></item>
            /// <item><description>Rds: ApsaraDB RDS secret.  </description></item>
            /// <item><description>Redis: Redis/Tair secret.</description></item>
            /// <item><description>RAMCredentials: RAM secret.  </description></item>
            /// <item><description>ECS: ECS secret.</description></item>
            /// <item><description>PolarDB: PolarDB secret.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Generic</para>
            /// </summary>
            [NameInMap("SecretType")]
            [Validation(Required=false)]
            public string SecretType { get; set; }

            /// <summary>
            /// <para>The version number of the secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// <para>The version stages of the secret.</para>
            /// </summary>
            [NameInMap("VersionStages")]
            [Validation(Required=false)]
            public BatchGetSecretValueResponseBodySecretValuesVersionStages VersionStages { get; set; }
            public class BatchGetSecretValueResponseBodySecretValuesVersionStages : TeaModel {
                /// <summary>
                /// <para>The version stages of the secret.</para>
                /// </summary>
                [NameInMap("VersionStage")]
                [Validation(Required=false)]
                public List<string> VersionStage { get; set; }

            }

        }

    }

}

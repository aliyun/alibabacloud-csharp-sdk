// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable DryRun mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables DryRun mode.</description></item>
        /// <item><description>false (default): disables DryRun mode.</description></item>
        /// </list>
        /// <para>DryRun mode is used to test API calls and verify whether you have the required permissions on the corresponding resources and whether the request parameters are correctly configured. When DryRun mode is enabled, KMS always returns a failure and provides the failure reason. Failure reasons include:</para>
        /// <list type="bullet">
        /// <item><description>DryRunOperationError: The request would succeed without the DryRun parameter.</description></item>
        /// <item><description>ValidationError: The parameters specified in the request are invalid.</description></item>
        /// <item><description>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the extended configuration of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: retrieves the extended configuration.</description></item>
        /// <item><description>false (default): does not retrieve the extended configuration.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Generic secrets do not support extended configurations. This parameter is ignored if specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FetchExtendedConfig")]
        [Validation(Required=false)]
        public bool? FetchExtendedConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;AttestationDocument&quot;:&quot;base64-encoded-attestion-document&quot;,  &quot;KeyEncryptionAlgorithm&quot;:&quot;RSAES_OAEP_SHA_256&quot; }</para>
        /// </summary>
        [NameInMap("Recipient")]
        [Validation(Required=false)]
        public string Recipient { get; set; }

        /// <summary>
        /// <para>The secret name or secret Alibaba Cloud Resource Name (ARN).</para>
        /// <remarks>
        /// <para>To access a secret in another Alibaba Cloud account, you must specify the secret ARN. The format of the secret ARN is <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// <remarks>
        /// <para>ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, RAM secrets, and ECS secrets do not support specifying VersionId. This parameter is ignored if specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The version stage. Default value: ACSCurrent.</para>
        /// <para>If you specify this parameter, the secret value of the specified version stage is returned. If you do not specify this parameter, the secret value of the ACSCurrent version stage is returned.</para>
        /// <remarks>
        /// <para>For ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, RAM secrets, and ECS secrets, you can retrieve only the secret values of the ACSPrevious and ACSCurrent versions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ACSCurrent</para>
        /// </summary>
        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

    }

}

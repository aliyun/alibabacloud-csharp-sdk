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
        /// <item><description>true: Enables DryRun mode.</description></item>
        /// <item><description>false (default): Disables DryRun mode.</description></item>
        /// </list>
        /// <para>DryRun mode is used to test API calls, verify whether you have the required permissions on the specified resources, and check whether the request parameters are configured correctly. When DryRun mode is enabled, KMS always returns a failure with the reason for the failure. Possible failure reasons include:</para>
        /// <list type="bullet">
        /// <item><description>DryRunOperationError: The request would succeed if the DryRun parameter were not configured.</description></item>
        /// <item><description>ValidationError: A parameter specified in the request is invalid.</description></item>
        /// <item><description>AccessDeniedError: You do not have permission to perform this operation on the KMS resource.</description></item>
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
        /// <item><description>true: Retrieves the extended configuration.</description></item>
        /// <item><description>false (default): Does not retrieve the extended configuration.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Generic secrets do not support extended configuration. If you set this parameter, it is ignored.</para>
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
        /// <para>When accessing a secret in another Alibaba Cloud account, you must enter the secret ARN. The format of the secret ARN is <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
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
        /// <para>Specifying VersionId is not supported for ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, dynamic RAM secrets, or dynamic ECS secrets. If you set this parameter, it is ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The version status. Default value: ACSCurrent.</para>
        /// <para>If you specify this parameter, the secret value of the specified version status is returned. If you do not specify this parameter, the secret value of the ACSCurrent version status is returned.</para>
        /// <remarks>
        /// <para>For ApsaraDB RDS secrets, PolarDB secrets, Redis/Tair secrets, dynamic RAM secrets, and dynamic ECS secrets, only the secret values corresponding to ACSPrevious and ACSCurrent can be retrieved.</para>
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

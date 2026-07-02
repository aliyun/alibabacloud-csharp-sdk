// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled  </description></item>
        /// <item><description>false (Default Value): Disabled</description></item>
        /// </list>
        /// <para>DryRun mode is used for Testing API Calls to authenticate whether you have the required permissions on the specified resource and whether the Request Parameters are correctly configured. When DryRun mode is enabled, KMS always returns a failed response along with the failure reason. Possible failure reasons include:</para>
        /// <list type="bullet">
        /// <item><description>DryRunOperationError: The request would succeed if the DryRun parameter were not specified.  </description></item>
        /// <item><description>ValidationError: One or more parameters in the request are invalid.  </description></item>
        /// <item><description>AccessDeniedError: You do not have permission to execute this operation on the KMS resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Indicates whether to retrieve the extended configuration of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Retrieve  </description></item>
        /// <item><description>false (Default Value): Do not retrieve</description></item>
        /// </list>
        /// <remarks>
        /// <para>Generic secrets do not support extended configuration. If you specify this parameter, it will be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FetchExtendedConfig")]
        [Validation(Required=false)]
        public bool? FetchExtendedConfig { get; set; }

        /// <summary>
        /// <para>The name or ARN of the credential.  </para>
        /// <remarks>
        /// <para>When accessing a credential under another Alibaba Cloud account, you must specify the credential ARN. The ARN format is <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
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
        /// <para>Version number.</para>
        /// <remarks>
        /// <para>The VersionId parameter is not supported for RDS credentials, PolarDB credentials, Redis/Tair credentials, RAM credentials, and ECS credentials. If you specify this parameter, it will be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The version stage. Default value: ACSCurrent.  </para>
        /// <para>If you specify this parameter, the credential value of the specified version stage is returned. If you do not specify this parameter, the credential value of the ACSCurrent version stage is returned.  </para>
        /// <remarks>
        /// <para>For RDS credentials, PolarDB credentials, Redis/Tair credentials, RAM credentials, and ECS credentials, you can retrieve only the credential values corresponding to the ACSPrevious or ACSCurrent version stages.</para>
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

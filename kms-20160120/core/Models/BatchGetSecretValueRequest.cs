// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class BatchGetSecretValueRequest : TeaModel {
        /// <summary>
        /// <para>The list of secret information. You can query up to 20 different secrets at a time.</para>
        /// </summary>
        [NameInMap("SecretsList")]
        [Validation(Required=false)]
        public List<BatchGetSecretValueRequestSecretsList> SecretsList { get; set; }
        public class BatchGetSecretValueRequestSecretsList : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retrieve the extended configuration of the secret. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Retrieve the extended configuration.</description></item>
            /// <item><description>false (default): Do not retrieve the extended configuration.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Generic secrets do not support extended configurations. This parameter is ignored for generic secrets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FetchExtendedConfig")]
            [Validation(Required=false)]
            public string FetchExtendedConfig { get; set; }

            /// <summary>
            /// <para>The secret name or secret Alibaba Cloud Resource Name (ARN).</para>
            /// <remarks>
            /// <para>When accessing a secret in another Alibaba Cloud account, you must specify the secret ARN. The format of a secret ARN is <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
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

}

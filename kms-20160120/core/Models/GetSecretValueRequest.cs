// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to obtain the extended configuration of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is ignored for a generic secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FetchExtendedConfig")]
        [Validation(Required=false)]
        public bool? FetchExtendedConfig { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The version number of the secret value. If you specify this parameter, Secrets Manager returns the secret value of the specified version.</para>
        /// <remarks>
        /// <para> This parameter is ignored for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00000000000000000000000000000001</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The stage label that marks the secret version. If you specify this parameter, Secrets Manager returns the secret value of the version that is marked with the specified stage label.</para>
        /// <para>Default value: ACSCurrent.</para>
        /// <remarks>
        /// <para> For a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret, Secrets Manager can return only the secret value of the version marked with ACSPrevious or ACSCurrent.</para>
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

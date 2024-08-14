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
        /// Specifies whether to obtain the extended configuration of the secret. Valid values:
        /// 
        /// *   true
        /// *   false: This is the default value.
        /// 
        /// >  This parameter is ignored for a generic secret.
        /// </summary>
        [NameInMap("FetchExtendedConfig")]
        [Validation(Required=false)]
        public bool? FetchExtendedConfig { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The version number of the secret value. If you specify this parameter, Secrets Manager returns the secret value of the specified version.
        /// 
        /// >  This parameter is ignored for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// The stage label that marks the secret version. If you specify this parameter, Secrets Manager returns the secret value of the version that is marked with the specified stage label.
        /// 
        /// Default value: ACSCurrent.
        /// 
        /// >  For a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret, Secrets Manager can return only the secret value of the version marked with ACSPrevious or ACSCurrent.
        /// </summary>
        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

    }

}

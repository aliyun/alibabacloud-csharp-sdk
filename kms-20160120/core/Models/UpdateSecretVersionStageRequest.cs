// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageRequest : TeaModel {
        /// <summary>
        /// The version from which you want to remove the specified stage label.
        /// 
        /// >  You must specify at least one of the RemoveFromVersion and MoveToVersion parameters.
        /// </summary>
        [NameInMap("MoveToVersion")]
        [Validation(Required=false)]
        public string MoveToVersion { get; set; }

        /// <summary>
        /// The specified stage label. Valid values:
        /// 
        /// *   ACSCurrent
        /// *   ACSPrevious
        /// *   Custom stage label
        /// </summary>
        [NameInMap("RemoveFromVersion")]
        [Validation(Required=false)]
        public string RemoveFromVersion { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **UpdateSecretVersionStage**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

    }

}

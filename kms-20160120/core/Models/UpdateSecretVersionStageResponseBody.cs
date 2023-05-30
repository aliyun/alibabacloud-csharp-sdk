// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageResponseBody : TeaModel {
        /// <summary>
        /// The name of the secret.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The version to which you want to apply the specified stage label.
        /// 
        /// > * You must specify at least one of the RemoveFromVersion and MoveToVersion parameters.
        /// > * If the VersionStage parameter is set to ACSCurrent or ACSPrevious, this parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRequest : TeaModel {
        /// <summary>
        /// The ID of the deployment package.
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// The name of the deployment package.
        /// </summary>
        [NameInMap("ArtifactName")]
        [Validation(Required=false)]
        public string ArtifactName { get; set; }

        /// <summary>
        /// The version of the deployment package.
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

    }

}

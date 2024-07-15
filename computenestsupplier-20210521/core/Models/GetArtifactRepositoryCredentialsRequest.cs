// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRepositoryCredentialsRequest : TeaModel {
        /// <summary>
        /// The type of the deployment package. Valid values:
        /// 
        /// *   File: Object Storage Service (OSS) object.
        /// *   AcrImage: container image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

    }

}

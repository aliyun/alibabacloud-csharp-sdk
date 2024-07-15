// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactResponseBody : TeaModel {
        /// <summary>
        /// The ID of the deployment package.
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// The properties of the deployment package.
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactProperty { get; set; }

        /// <summary>
        /// The type of the deployment package.
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// The version of the deployment package.
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// The description of the deployment package.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the deployment package was modified.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the deployment package. Valid values:
        /// 
        /// *   Created: The deployment package is created.
        /// *   Scanning: The deployment package is being scanned.
        /// *   ScanFailed: The deployment package failed to be scanned.
        /// *   Delivering: The deployment package is being distributed.
        /// *   Available: The deployment package is available.
        /// *   Deleted: The deployment package is deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the region that supports the deployment package.
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public string SupportRegionIds { get; set; }

        /// <summary>
        /// The name of the deployment package.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}

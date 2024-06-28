// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ReleaseArtifactResponseBody : TeaModel {
        /// <summary>
        /// The ID of the artifact.
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// The content of the artifact.
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactProperty { get; set; }

        /// <summary>
        /// The type of the artifact.
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// The version of the artifact.
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// The description of the artifact.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the artifact was modified.
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
        /// The state of the artifact. Valid values:
        /// 
        /// *   Created: The artifact is created.
        /// *   Scanning: The artifact is being scanned.
        /// *   ScanFailed: The artifact failed to be scanned.
        /// *   Delivering: The artifact is being distributed.
        /// *   Available: The artifact is available.
        /// *   Deleted: The artifact is deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The version name of the artifact.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}

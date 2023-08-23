// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildTaskResponseBody : TeaModel {
        /// <summary>
        /// The type of the artifact building task. Valid values:
        /// 
        /// *   `IMAGE_TO_ACCELERATED_IMAGE`: builds accelerated images for Container Service for Kubernetes (ACK) clusters.
        /// *   `IMAGE_TO_ECI_ACCELERATED_IMAGE`: builds accelerated images for elastic container instances.
        /// </summary>
        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

        /// <summary>
        /// The ID of the artifact building task.
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time when the artifact building task ends.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public List<string> Instructions { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the source artifact.
        /// </summary>
        [NameInMap("SourceArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodySourceArtifact SourceArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodySourceArtifact : TeaModel {
            /// <summary>
            /// The type of the artifact that is built in the task. The value can only be IMAGE.
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// The ID of the repository to which the source artifact belongs. The repository can only be an image repository.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The version of the artifact. The artifact can only be an image.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The time when the artifact building task starts.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// The artifact that is built in the task.
        /// </summary>
        [NameInMap("TargetArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodyTargetArtifact TargetArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodyTargetArtifact : TeaModel {
            /// <summary>
            /// The type of the artifact that is built in the task. The value can only be IMAGE.
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// The ID of the repository to which the artifact that is built in the task belongs. The repository can only be an image repository. The value is the same as the ID of the repository to which the source artifact belongs.
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// The version of the artifact that is built in the task. The artifact can only be an image.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The status of the artifact that is built in the task. Valid values:
        /// 
        /// *   `PENDING`: The artifact is being scheduled.
        /// *   `BUILDING`: The artifact is being built.
        /// *   `SUCCESS`: The artifact is built.
        /// *   `FAILED`: The artifact fails to be built.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}

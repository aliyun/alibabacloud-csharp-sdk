// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the artifact building task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>IMAGE_TO_ACCELERATED_IMAGE</c>: builds accelerated images for Container Service for Kubernetes (ACK) clusters.</description></item>
        /// <item><description><c>IMAGE_TO_ECI_ACCELERATED_IMAGE</c>: builds accelerated images for elastic container instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_TO_ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

        /// <summary>
        /// <para>The ID of the artifact building task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i2a-1yu****</para>
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time when the artifact building task ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156871880</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public List<string> Instructions { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4C7DD0C-C9D6-437A-A7EE-121EFD70D002</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the source artifact.</para>
        /// </summary>
        [NameInMap("SourceArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodySourceArtifact SourceArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodySourceArtifact : TeaModel {
            /// <summary>
            /// <para>The type of the artifact that is built in the task. The value can only be IMAGE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The ID of the repository to which the source artifact belongs. The repository can only be an image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-shac42yvqzvq****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The version of the artifact. The artifact can only be an image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The time when the artifact building task starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156871881</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The artifact that is built in the task.</para>
        /// </summary>
        [NameInMap("TargetArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodyTargetArtifact TargetArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodyTargetArtifact : TeaModel {
            /// <summary>
            /// <para>The type of the artifact that is built in the task. The value can only be IMAGE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The ID of the repository to which the artifact that is built in the task belongs. The repository can only be an image repository. The value is the same as the ID of the repository to which the source artifact belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-1234567</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The version of the artifact that is built in the task. The artifact can only be an image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest_accelerated</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The status of the artifact that is built in the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>PENDING</c>: The artifact is being scheduled.</description></item>
        /// <item><description><c>BUILDING</c>: The artifact is being built.</description></item>
        /// <item><description><c>SUCCESS</c>: The artifact is built.</description></item>
        /// <item><description><c>FAILED</c>: The artifact fails to be built.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUILDING</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}

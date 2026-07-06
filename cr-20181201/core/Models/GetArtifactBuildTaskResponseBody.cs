// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The artifact build type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>IMAGE_TO_ACCELERATED_IMAGE</c>: an accelerated image for ACK.</para>
        /// </description></item>
        /// <item><description><para><c>IMAGE_TO_ECI_ACCELERATED_IMAGE</c>: an accelerated image for ECI.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_TO_ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

        /// <summary>
        /// <para>The ID of the artifact build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i2a-1yu****</para>
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Unix timestamp in seconds when the task ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685415871</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public List<string> Instructions { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>The source artifact.</para>
        /// </summary>
        [NameInMap("SourceArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodySourceArtifact SourceArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodySourceArtifact : TeaModel {
            /// <summary>
            /// <para>The artifact type. Currently, only <c>IMAGE</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The repository ID. Currently, only image repositories are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-shac42yvqzvq****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The artifact version. Currently, only image versions are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The Unix timestamp in seconds when the task started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685437471</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The target artifact.</para>
        /// </summary>
        [NameInMap("TargetArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodyTargetArtifact TargetArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodyTargetArtifact : TeaModel {
            /// <summary>
            /// <para>The artifact type. Currently, only <c>IMAGE</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The repository ID. It must be the same as the repository ID of the source artifact. Only image repositories are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-1234567</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The artifact version. Currently, only image versions are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest_accelerated</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The status of the artifact build task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PENDING</c>: The task is being scheduled.</para>
        /// </description></item>
        /// <item><description><para><c>BUILDING</c>: The task is in progress.</para>
        /// </description></item>
        /// <item><description><para><c>SUCCESS</c>: The task is successful.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED</c>: The task failed.</para>
        /// </description></item>
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

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
        /// <item><description><para><c>IMAGE_TO_ACCELERATED_IMAGE</c>: Accelerated image creation optimized for ACK scenarios.</para>
        /// </description></item>
        /// <item><description><para><c>IMAGE_TO_ECI_ACCELERATED_IMAGE</c>: Accelerated image artifact optimized for ECI scenarios.</para>
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
        /// <para>The artifact compression parameters.</para>
        /// </summary>
        [NameInMap("ArtifactCompression")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodyArtifactCompression ArtifactCompression { get; set; }
        public class GetArtifactBuildTaskResponseBodyArtifactCompression : TeaModel {
            /// <summary>
            /// <para>The operating system and architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux/arm64</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The number of layers to retain after compression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SquashKeepLayers")]
            [Validation(Required=false)]
            public int? SquashKeepLayers { get; set; }

            /// <summary>
            /// <para>The digest of the starting layer for compression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:xxxxx</para>
            /// </summary>
            [NameInMap("StartLayerDigest")]
            [Validation(Required=false)]
            public string StartLayerDigest { get; set; }

        }

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
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1685415871</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The reserved field list of the artifact build task. The list elements should be empty.</para>
        /// </summary>
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
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
            /// <para>The artifact type. Only IMAGE is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The number of artifact layers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LayerCount")]
            [Validation(Required=false)]
            public int? LayerCount { get; set; }

            /// <summary>
            /// <para>The repository ID. Only image repositories are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-shac42yvqzvq****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The artifact size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The artifact version. Only image versions are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in seconds.</para>
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
            /// <para>The artifact type. Only IMAGE is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The number of artifact layers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("LayerCount")]
            [Validation(Required=false)]
            public int? LayerCount { get; set; }

            /// <summary>
            /// <para>The repository ID. Only image repositories are supported. The repository ID of the target artifact must be the same as that of the source artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-1234567</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The artifact size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The artifact version. Only images are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>latest_accelerated</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The artifact build status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PENDING</c>: Scheduling in progress.</para>
        /// </description></item>
        /// <item><description><para><c>BUILDING</c>: Building in progress.</para>
        /// </description></item>
        /// <item><description><para><c>SUCCESS</c>: Build succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>FAILED</c>: Build failed.</para>
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

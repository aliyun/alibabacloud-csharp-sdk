// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildTaskResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("Instructions")]
        [Validation(Required=false)]
        public List<string> Instructions { get; set; }

        [NameInMap("SourceArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodySourceArtifact SourceArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodySourceArtifact : TeaModel {
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }
        };

        [NameInMap("TargetArtifact")]
        [Validation(Required=false)]
        public GetArtifactBuildTaskResponseBodyTargetArtifact TargetArtifact { get; set; }
        public class GetArtifactBuildTaskResponseBodyTargetArtifact : TeaModel {
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }
        };

    }

}

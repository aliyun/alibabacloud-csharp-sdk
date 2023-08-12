// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactVersionsResponseBody : TeaModel {
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactVersionsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactVersionsResponseBodyArtifacts : TeaModel {
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            [NameInMap("ArtifactProperty")]
            [Validation(Required=false)]
            public string ArtifactProperty { get; set; }

            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ImageDelivery")]
            [Validation(Required=false)]
            public Dictionary<string, string> ImageDelivery { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ResultFile")]
            [Validation(Required=false)]
            public string ResultFile { get; set; }

            [NameInMap("SecurityAuditResult")]
            [Validation(Required=false)]
            public string SecurityAuditResult { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupportRegionIds")]
            [Validation(Required=false)]
            public string SupportRegionIds { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

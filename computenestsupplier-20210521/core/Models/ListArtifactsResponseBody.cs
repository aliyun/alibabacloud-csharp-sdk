// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactsResponseBody : TeaModel {
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactsResponseBodyArtifacts : TeaModel {
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("MaxVersion")]
            [Validation(Required=false)]
            public string MaxVersion { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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

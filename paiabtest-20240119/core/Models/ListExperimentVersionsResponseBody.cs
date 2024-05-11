// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIABTest20240119.Models
{
    public class ListExperimentVersionsResponseBody : TeaModel {
        [NameInMap("ExperimentVersions")]
        [Validation(Required=false)]
        public List<ListExperimentVersionsResponseBodyExperimentVersions> ExperimentVersions { get; set; }
        public class ListExperimentVersionsResponseBodyExperimentVersions : TeaModel {
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("CrowdIds")]
            [Validation(Required=false)]
            public string CrowdIds { get; set; }

            [NameInMap("DebugUsers")]
            [Validation(Required=false)]
            public string DebugUsers { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("ExperimentVersionId")]
            [Validation(Required=false)]
            public string ExperimentVersionId { get; set; }

            [NameInMap("Flow")]
            [Validation(Required=false)]
            public int? Flow { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

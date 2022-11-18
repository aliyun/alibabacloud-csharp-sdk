// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListRunsResponseBody : TeaModel {
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Runs")]
        [Validation(Required=false)]
        public List<ListRunsResponseBodyRuns> Runs { get; set; }
        public class ListRunsResponseBodyRuns : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppRevision")]
            [Validation(Required=false)]
            public string AppRevision { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultRuntime")]
            [Validation(Required=false)]
            public string DefaultRuntime { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("ExecuteDirectory")]
            [Validation(Required=false)]
            public string ExecuteDirectory { get; set; }

            [NameInMap("ExecuteOptions")]
            [Validation(Required=false)]
            public ListRunsResponseBodyRunsExecuteOptions ExecuteOptions { get; set; }
            public class ListRunsResponseBodyRunsExecuteOptions : TeaModel {
                [NameInMap("CallCaching")]
                [Validation(Required=false)]
                public bool? CallCaching { get; set; }

                [NameInMap("DeleteIntermediateResults")]
                [Validation(Required=false)]
                public bool? DeleteIntermediateResults { get; set; }

                [NameInMap("FailureMode")]
                [Validation(Required=false)]
                public string FailureMode { get; set; }

                [NameInMap("UseRelativeOutputPaths")]
                [Validation(Required=false)]
                public bool? UseRelativeOutputPaths { get; set; }

            }

            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            [NameInMap("RunName")]
            [Validation(Required=false)]
            public string RunName { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmissionId")]
            [Validation(Required=false)]
            public string SubmissionId { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetRunResponseBody : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        [NameInMap("BillingInstanceIds")]
        [Validation(Required=false)]
        public List<string> BillingInstanceIds { get; set; }

        [NameInMap("Calls")]
        [Validation(Required=false)]
        public string Calls { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DefaultRuntime")]
        [Validation(Required=false)]
        public string DefaultRuntime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        public GetRunResponseBodyExecuteOptions ExecuteOptions { get; set; }
        public class GetRunResponseBodyExecuteOptions : TeaModel {
            [NameInMap("CallCaching")]
            [Validation(Required=false)]
            public bool? CallCaching { get; set; }

            [NameInMap("DataLoader")]
            [Validation(Required=false)]
            public string DataLoader { get; set; }

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

        [NameInMap("Failures")]
        [Validation(Required=false)]
        public string Failures { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public string Inputs { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

        [NameInMap("Timing")]
        [Validation(Required=false)]
        public string Timing { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

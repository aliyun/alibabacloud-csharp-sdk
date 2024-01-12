// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateRunRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DefaultRuntime")]
        [Validation(Required=false)]
        public string DefaultRuntime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExecuteDirectory")]
        [Validation(Required=false)]
        public string ExecuteDirectory { get; set; }

        [NameInMap("ExecuteOptions")]
        [Validation(Required=false)]
        public CreateRunRequestExecuteOptions ExecuteOptions { get; set; }
        public class CreateRunRequestExecuteOptions : TeaModel {
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
        public string Labels { get; set; }

        [NameInMap("OutputFolder")]
        [Validation(Required=false)]
        public string OutputFolder { get; set; }

        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

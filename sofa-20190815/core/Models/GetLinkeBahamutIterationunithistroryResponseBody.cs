// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutIterationunithistroryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutIterationunithistroryResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutIterationunithistroryResponseBodyResult : TeaModel {
            [NameInMap("Applicant")]
            [Validation(Required=false)]
            public string Applicant { get; set; }

            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            [NameInMap("ComponentExecutionId")]
            [Validation(Required=false)]
            public string ComponentExecutionId { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Incompatible")]
            [Validation(Required=false)]
            public bool? Incompatible { get; set; }

            [NameInMap("IterationUnitHistoryTypeEnum")]
            [Validation(Required=false)]
            public string IterationUnitHistoryTypeEnum { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("PipelineExecutionId")]
            [Validation(Required=false)]
            public long? PipelineExecutionId { get; set; }

            [NameInMap("PipelineInstanceId")]
            [Validation(Required=false)]
            public long? PipelineInstanceId { get; set; }

            [NameInMap("PublishJarEnv")]
            [Validation(Required=false)]
            public string PublishJarEnv { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UnitId")]
            [Validation(Required=false)]
            public string UnitId { get; set; }

            [NameInMap("UnitStageId")]
            [Validation(Required=false)]
            public string UnitStageId { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("MvnRepo")]
            [Validation(Required=false)]
            public List<string> MvnRepo { get; set; }

        }

    }

}

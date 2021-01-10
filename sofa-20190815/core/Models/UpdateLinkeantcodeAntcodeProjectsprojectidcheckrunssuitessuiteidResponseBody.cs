// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeProjectsprojectidcheckrunssuitessuiteidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CompletedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        [NameInMap("Conclusion")]
        [Validation(Required=false)]
        public string Conclusion { get; set; }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("DetailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("StartedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SuiteId")]
        [Validation(Required=false)]
        public long? SuiteId { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UpdateAt")]
        [Validation(Required=false)]
        public string UpdateAt { get; set; }

        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public List<UpdateLinkeantcodeAntcodeProjectsprojectidcheckrunssuitessuiteidResponseBodyAnnotations> Annotations { get; set; }
        public class UpdateLinkeantcodeAntcodeProjectsprojectidcheckrunssuitessuiteidResponseBodyAnnotations : TeaModel {
            [NameInMap("CheckRunId")]
            [Validation(Required=false)]
            public long? CheckRunId { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            [NameInMap("EndCol")]
            [Validation(Required=false)]
            public long? EndCol { get; set; }

            [NameInMap("EndLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("StartCol")]
            [Validation(Required=false)]
            public long? StartCol { get; set; }

            [NameInMap("StartLine")]
            [Validation(Required=false)]
            public long? StartLine { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}

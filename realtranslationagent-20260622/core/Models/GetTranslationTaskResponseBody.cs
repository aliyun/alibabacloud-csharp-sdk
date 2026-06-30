// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class GetTranslationTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTranslationTaskResponseBodyData Data { get; set; }
        public class GetTranslationTaskResponseBodyData : TeaModel {
            [NameInMap("BaseTaskId")]
            [Validation(Required=false)]
            public string BaseTaskId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetTranslationTaskResponseBodyDataConfig Config { get; set; }
            public class GetTranslationTaskResponseBodyDataConfig : TeaModel {
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                [NameInMap("TargetLanguage")]
                [Validation(Required=false)]
                public string TargetLanguage { get; set; }

                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

            }

            [NameInMap("CostCredits")]
            [Validation(Required=false)]
            public double? CostCredits { get; set; }

            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("EstimatedCostCredits")]
            [Validation(Required=false)]
            public double? EstimatedCostCredits { get; set; }

            [NameInMap("EstimatedTime")]
            [Validation(Required=false)]
            public long? EstimatedTime { get; set; }

            [NameInMap("ExtractedTerms")]
            [Validation(Required=false)]
            public List<GetTranslationTaskResponseBodyDataExtractedTerms> ExtractedTerms { get; set; }
            public class GetTranslationTaskResponseBodyDataExtractedTerms : TeaModel {
                [NameInMap("SourceTerm")]
                [Validation(Required=false)]
                public string SourceTerm { get; set; }

                [NameInMap("TargetTerm")]
                [Validation(Required=false)]
                public string TargetTerm { get; set; }

            }

            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            [NameInMap("Fonts")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Fonts { get; set; }

            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            [NameInMap("OriginalFileName")]
            [Validation(Required=false)]
            public string OriginalFileName { get; set; }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public long? WordCount { get; set; }

            [NameInMap("WorkSpaceId")]
            [Validation(Required=false)]
            public string WorkSpaceId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

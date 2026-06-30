// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class ListTranslationTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTranslationTasksResponseBodyData Data { get; set; }
        public class ListTranslationTasksResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTranslationTasksResponseBodyDataList> List { get; set; }
            public class ListTranslationTasksResponseBodyDataList : TeaModel {
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public string CompleteTime { get; set; }

                [NameInMap("CostCredits")]
                [Validation(Required=false)]
                public double? CostCredits { get; set; }

                [NameInMap("CostTime")]
                [Validation(Required=false)]
                public long? CostTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FileFormat")]
                [Validation(Required=false)]
                public string FileFormat { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

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

                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetLanguage")]
                [Validation(Required=false)]
                public string TargetLanguage { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                [NameInMap("WordCount")]
                [Validation(Required=false)]
                public long? WordCount { get; set; }

                [NameInMap("WorkSpaceId")]
                [Validation(Required=false)]
                public string WorkSpaceId { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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

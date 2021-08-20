// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class UpdateMergeRequestResponseBody : TeaModel {
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateMergeRequestResponseBodyResult Result { get; set; }
        public class UpdateMergeRequestResponseBodyResult : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("BehindCommitCount")]
            [Validation(Required=false)]
            public int? BehindCommitCount { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("AcceptedRevision")]
            [Validation(Required=false)]
            public string AcceptedRevision { get; set; }
            [NameInMap("SourceBranch")]
            [Validation(Required=false)]
            public string SourceBranch { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("NameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }
            [NameInMap("MergeType")]
            [Validation(Required=false)]
            public string MergeType { get; set; }
            [NameInMap("TargetBranch")]
            [Validation(Required=false)]
            public string TargetBranch { get; set; }
            [NameInMap("AheadCommitCount")]
            [Validation(Required=false)]
            public int? AheadCommitCount { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("MergeError")]
            [Validation(Required=false)]
            public string MergeError { get; set; }
            [NameInMap("MergedRevision")]
            [Validation(Required=false)]
            public string MergedRevision { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("MergeStatus")]
            [Validation(Required=false)]
            public string MergeStatus { get; set; }
            [NameInMap("AssigneeList")]
            [Validation(Required=false)]
            public List<UpdateMergeRequestResponseBodyResultAssigneeList> AssigneeList { get; set; }
            public class UpdateMergeRequestResponseBodyResultAssigneeList : TeaModel {
                public string ExternUserId { get; set; }
                public string Name { get; set; }
                public string AvatarUrl { get; set; }
                public string Id { get; set; }
            }
            [NameInMap("ApproveCheckResult")]
            [Validation(Required=false)]
            public UpdateMergeRequestResponseBodyResultApproveCheckResult ApproveCheckResult { get; set; }
            public class UpdateMergeRequestResponseBodyResultApproveCheckResult : TeaModel {
                [NameInMap("TotalCheckResult")]
                [Validation(Required=false)]
                public string TotalCheckResult { get; set; }

                [NameInMap("SatisfiedCheckResults")]
                [Validation(Required=false)]
                public List<UpdateMergeRequestResponseBodyResultApproveCheckResultSatisfiedCheckResults> SatisfiedCheckResults { get; set; }
                public class UpdateMergeRequestResponseBodyResultApproveCheckResultSatisfiedCheckResults : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("CheckName")]
                    [Validation(Required=false)]
                    public string CheckName { get; set; }

                    [NameInMap("ExtraUsers")]
                    [Validation(Required=false)]
                    public List<UpdateMergeRequestResponseBodyResultApproveCheckResultSatisfiedCheckResultsExtraUsers> ExtraUsers { get; set; }
                    public class UpdateMergeRequestResponseBodyResultApproveCheckResultSatisfiedCheckResultsExtraUsers : TeaModel {
                        [NameInMap("ExternUserId")]
                        [Validation(Required=false)]
                        public string ExternUserId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("AvatarUrl")]
                        [Validation(Required=false)]
                        public string AvatarUrl { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                    [NameInMap("UnsatisfiedItems")]
                    [Validation(Required=false)]
                    public List<string> UnsatisfiedItems { get; set; }

                    [NameInMap("SatisfiedItems")]
                    [Validation(Required=false)]
                    public List<string> SatisfiedItems { get; set; }

                }

                [NameInMap("UnsatisfiedCheckResults")]
                [Validation(Required=false)]
                public List<UpdateMergeRequestResponseBodyResultApproveCheckResultUnsatisfiedCheckResults> UnsatisfiedCheckResults { get; set; }
                public class UpdateMergeRequestResponseBodyResultApproveCheckResultUnsatisfiedCheckResults : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("CheckType")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("CheckName")]
                    [Validation(Required=false)]
                    public string CheckName { get; set; }

                    [NameInMap("ExtraUsers")]
                    [Validation(Required=false)]
                    public List<UpdateMergeRequestResponseBodyResultApproveCheckResultUnsatisfiedCheckResultsExtraUsers> ExtraUsers { get; set; }
                    public class UpdateMergeRequestResponseBodyResultApproveCheckResultUnsatisfiedCheckResultsExtraUsers : TeaModel {
                        [NameInMap("ExternUserId")]
                        [Validation(Required=false)]
                        public string ExternUserId { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("AvatarUrl")]
                        [Validation(Required=false)]
                        public string AvatarUrl { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                    }

                    [NameInMap("UnsatisfiedItems")]
                    [Validation(Required=false)]
                    public List<string> UnsatisfiedItems { get; set; }

                    [NameInMap("SatisfiedItems")]
                    [Validation(Required=false)]
                    public List<string> SatisfiedItems { get; set; }

                }

            }
            [NameInMap("Author")]
            [Validation(Required=false)]
            public UpdateMergeRequestResponseBodyResultAuthor Author { get; set; }
            public class UpdateMergeRequestResponseBodyResultAuthor : TeaModel {
                [NameInMap("ExternUserId")]
                [Validation(Required=false)]
                public string ExternUserId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }
        };

    }

}

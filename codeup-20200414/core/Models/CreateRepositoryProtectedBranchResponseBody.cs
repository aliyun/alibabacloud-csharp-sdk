// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class CreateRepositoryProtectedBranchResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateRepositoryProtectedBranchResponseBodyResult Result { get; set; }
        public class CreateRepositoryProtectedBranchResponseBodyResult : TeaModel {
            [NameInMap("AllowMergeRoles")]
            [Validation(Required=false)]
            public List<int?> AllowMergeRoles { get; set; }

            [NameInMap("AllowPushRoles")]
            [Validation(Required=false)]
            public List<int?> AllowPushRoles { get; set; }

            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MergeRequestSetting")]
            [Validation(Required=false)]
            public CreateRepositoryProtectedBranchResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class CreateRepositoryProtectedBranchResponseBodyResultMergeRequestSetting : TeaModel {
                [NameInMap("AllowMergeRequestRoles")]
                [Validation(Required=false)]
                public List<int?> AllowMergeRequestRoles { get; set; }

                [NameInMap("AllowSelfApproval")]
                [Validation(Required=false)]
                public bool? AllowSelfApproval { get; set; }

                [NameInMap("DefaultAssignees")]
                [Validation(Required=false)]
                public List<string> DefaultAssignees { get; set; }

                [NameInMap("IsRequireDiscussionProcessed")]
                [Validation(Required=false)]
                public bool? IsRequireDiscussionProcessed { get; set; }

                [NameInMap("IsResetApprovalWhenNewPush")]
                [Validation(Required=false)]
                public bool? IsResetApprovalWhenNewPush { get; set; }

                [NameInMap("MergeRequestMode")]
                [Validation(Required=false)]
                public string MergeRequestMode { get; set; }

                [NameInMap("MinimualApproval")]
                [Validation(Required=false)]
                public int? MinimualApproval { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

            [NameInMap("TestSetting")]
            [Validation(Required=false)]
            public CreateRepositoryProtectedBranchResponseBodyResultTestSetting TestSetting { get; set; }
            public class CreateRepositoryProtectedBranchResponseBodyResultTestSetting : TeaModel {
                [NameInMap("CheckConfig")]
                [Validation(Required=false)]
                public CreateRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig CheckConfig { get; set; }
                public class CreateRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig : TeaModel {
                    [NameInMap("CheckItems")]
                    [Validation(Required=false)]
                    public List<CreateRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems> CheckItems { get; set; }
                    public class CreateRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }

                [NameInMap("CodingGuidelinesDetection")]
                [Validation(Required=false)]
                public CreateRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection CodingGuidelinesDetection { get; set; }
                public class CreateRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("SensitiveInfoDetection")]
                [Validation(Required=false)]
                public CreateRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class CreateRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

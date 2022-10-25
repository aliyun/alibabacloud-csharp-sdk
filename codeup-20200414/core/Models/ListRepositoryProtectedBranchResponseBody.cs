// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListRepositoryProtectedBranchResponseBody : TeaModel {
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
        public List<ListRepositoryProtectedBranchResponseBodyResult> Result { get; set; }
        public class ListRepositoryProtectedBranchResponseBodyResult : TeaModel {
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
            public ListRepositoryProtectedBranchResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class ListRepositoryProtectedBranchResponseBodyResultMergeRequestSetting : TeaModel {
                [NameInMap("AllowMergeRequestRoles")]
                [Validation(Required=false)]
                public List<int?> AllowMergeRequestRoles { get; set; }

                [NameInMap("AllowSelfApproval")]
                [Validation(Required=false)]
                public bool? AllowSelfApproval { get; set; }

                [NameInMap("DefaultAssignees")]
                [Validation(Required=false)]
                public List<ListRepositoryProtectedBranchResponseBodyResultMergeRequestSettingDefaultAssignees> DefaultAssignees { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultMergeRequestSettingDefaultAssignees : TeaModel {
                    [NameInMap("AvatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }

                    [NameInMap("Email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("ExternUid")]
                    [Validation(Required=false)]
                    public string ExternUid { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("IsRequireDiscussionProcessed")]
                [Validation(Required=false)]
                public bool? IsRequireDiscussionProcessed { get; set; }

                [NameInMap("MergeRequestMode")]
                [Validation(Required=false)]
                public string MergeRequestMode { get; set; }

                [NameInMap("MinimumApproval")]
                [Validation(Required=false)]
                public int? MinimumApproval { get; set; }

                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            [NameInMap("TestSetting")]
            [Validation(Required=false)]
            public ListRepositoryProtectedBranchResponseBodyResultTestSetting TestSetting { get; set; }
            public class ListRepositoryProtectedBranchResponseBodyResultTestSetting : TeaModel {
                [NameInMap("CheckConfig")]
                [Validation(Required=false)]
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig CheckConfig { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig : TeaModel {
                    [NameInMap("CheckItems")]
                    [Validation(Required=false)]
                    public List<ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems> CheckItems { get; set; }
                    public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems : TeaModel {
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
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection CodingGuidelinesDetection { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection : TeaModel {
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
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection : TeaModel {
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

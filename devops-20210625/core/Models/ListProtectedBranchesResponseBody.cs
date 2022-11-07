// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProtectedBranchesResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListProtectedBranchesResponseBodyResult> Result { get; set; }
        public class ListProtectedBranchesResponseBodyResult : TeaModel {
            [NameInMap("allowMergeRoles")]
            [Validation(Required=false)]
            public List<int?> AllowMergeRoles { get; set; }

            [NameInMap("allowMergeUserIds")]
            [Validation(Required=false)]
            public List<long?> AllowMergeUserIds { get; set; }

            [NameInMap("allowMergeUsers")]
            [Validation(Required=false)]
            public List<ListProtectedBranchesResponseBodyResultAllowMergeUsers> AllowMergeUsers { get; set; }
            public class ListProtectedBranchesResponseBodyResultAllowMergeUsers : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("tbUserId")]
                [Validation(Required=false)]
                public string TbUserId { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("allowPushRoles")]
            [Validation(Required=false)]
            public List<int?> AllowPushRoles { get; set; }

            [NameInMap("allowPushUserIds")]
            [Validation(Required=false)]
            public List<long?> AllowPushUserIds { get; set; }

            [NameInMap("allowPushUsers")]
            [Validation(Required=false)]
            public List<ListProtectedBranchesResponseBodyResultAllowPushUsers> AllowPushUsers { get; set; }
            public class ListProtectedBranchesResponseBodyResultAllowPushUsers : TeaModel {
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("tbUserId")]
                [Validation(Required=false)]
                public string TbUserId { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("matches")]
            [Validation(Required=false)]
            public List<string> Matches { get; set; }

            [NameInMap("mergeRequestSetting")]
            [Validation(Required=false)]
            public ListProtectedBranchesResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class ListProtectedBranchesResponseBodyResultMergeRequestSetting : TeaModel {
                [NameInMap("allowMergeRequestRoles")]
                [Validation(Required=false)]
                public List<int?> AllowMergeRequestRoles { get; set; }

                [NameInMap("defaultAssignees")]
                [Validation(Required=false)]
                public List<ListProtectedBranchesResponseBodyResultMergeRequestSettingDefaultAssignees> DefaultAssignees { get; set; }
                public class ListProtectedBranchesResponseBodyResultMergeRequestSettingDefaultAssignees : TeaModel {
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("tbUserId")]
                    [Validation(Required=false)]
                    public string TbUserId { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("isAllowSelfApproval")]
                [Validation(Required=false)]
                public bool? IsAllowSelfApproval { get; set; }

                [NameInMap("isRequireDiscussionProcessed")]
                [Validation(Required=false)]
                public bool? IsRequireDiscussionProcessed { get; set; }

                [NameInMap("isRequired")]
                [Validation(Required=false)]
                public bool? IsRequired { get; set; }

                [NameInMap("isResetApprovalWhenNewPush")]
                [Validation(Required=false)]
                public bool? IsResetApprovalWhenNewPush { get; set; }

                [NameInMap("minimumApproval")]
                [Validation(Required=false)]
                public int? MinimumApproval { get; set; }

                [NameInMap("mrMode")]
                [Validation(Required=false)]
                public string MrMode { get; set; }

                [NameInMap("whiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            [NameInMap("testSettingDTO")]
            [Validation(Required=false)]
            public ListProtectedBranchesResponseBodyResultTestSettingDTO TestSettingDTO { get; set; }
            public class ListProtectedBranchesResponseBodyResultTestSettingDTO : TeaModel {
                [NameInMap("checkConfig")]
                [Validation(Required=false)]
                public ListProtectedBranchesResponseBodyResultTestSettingDTOCheckConfig CheckConfig { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOCheckConfig : TeaModel {
                    [NameInMap("checkItems")]
                    [Validation(Required=false)]
                    public List<ListProtectedBranchesResponseBodyResultTestSettingDTOCheckConfigCheckItems> CheckItems { get; set; }
                    public class ListProtectedBranchesResponseBodyResultTestSettingDTOCheckConfigCheckItems : TeaModel {
                        [NameInMap("isRequired")]
                        [Validation(Required=false)]
                        public bool? IsRequired { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("checkTaskQualityConfig")]
                [Validation(Required=false)]
                public ListProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig : TeaModel {
                    [NameInMap("bizNo")]
                    [Validation(Required=false)]
                    public string BizNo { get; set; }

                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("taskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                }

                [NameInMap("codeGuidelinesDetection")]
                [Validation(Required=false)]
                public ListProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                [NameInMap("isRequired")]
                [Validation(Required=false)]
                public bool? IsRequired { get; set; }

                [NameInMap("sensitiveInfoDetection")]
                [Validation(Required=false)]
                public ListProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

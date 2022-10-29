// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProtectedBranchesRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("allowMergeRoles")]
        [Validation(Required=false)]
        public List<int?> AllowMergeRoles { get; set; }

        [NameInMap("allowMergeUserIds")]
        [Validation(Required=false)]
        public List<long?> AllowMergeUserIds { get; set; }

        [NameInMap("allowPushRoles")]
        [Validation(Required=false)]
        public List<int?> AllowPushRoles { get; set; }

        [NameInMap("allowPushUserIds")]
        [Validation(Required=false)]
        public List<long?> AllowPushUserIds { get; set; }

        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("mergeRequestSetting")]
        [Validation(Required=false)]
        public UpdateProtectedBranchesRequestMergeRequestSetting MergeRequestSetting { get; set; }
        public class UpdateProtectedBranchesRequestMergeRequestSetting : TeaModel {
            [NameInMap("allowMergeRequestRoles")]
            [Validation(Required=false)]
            public List<int?> AllowMergeRequestRoles { get; set; }

            [NameInMap("defaultAssignees")]
            [Validation(Required=false)]
            public List<int?> DefaultAssignees { get; set; }

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
        public UpdateProtectedBranchesRequestTestSettingDTO TestSettingDTO { get; set; }
        public class UpdateProtectedBranchesRequestTestSettingDTO : TeaModel {
            [NameInMap("checkConfig")]
            [Validation(Required=false)]
            public UpdateProtectedBranchesRequestTestSettingDTOCheckConfig CheckConfig { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOCheckConfig : TeaModel {
                [NameInMap("checkItems")]
                [Validation(Required=false)]
                public List<UpdateProtectedBranchesRequestTestSettingDTOCheckConfigCheckItems> CheckItems { get; set; }
                public class UpdateProtectedBranchesRequestTestSettingDTOCheckConfigCheckItems : TeaModel {
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
            public UpdateProtectedBranchesRequestTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
            public UpdateProtectedBranchesRequestTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
            public UpdateProtectedBranchesRequestTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOSensitiveInfoDetection : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateProtectdBranchRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("allowMergeRoles")]
        [Validation(Required=false)]
        public List<int?> AllowMergeRoles { get; set; }

        [NameInMap("allowMergeUserIds")]
        [Validation(Required=false)]
        public List<string> AllowMergeUserIds { get; set; }

        [NameInMap("allowPushRoles")]
        [Validation(Required=false)]
        public List<int?> AllowPushRoles { get; set; }

        [NameInMap("allowPushUserIds")]
        [Validation(Required=false)]
        public List<string> AllowPushUserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("mergeRequestSetting")]
        [Validation(Required=false)]
        public CreateProtectdBranchRequestMergeRequestSetting MergeRequestSetting { get; set; }
        public class CreateProtectdBranchRequestMergeRequestSetting : TeaModel {
            [NameInMap("allowMergeRequestRoles")]
            [Validation(Required=false)]
            public List<int?> AllowMergeRequestRoles { get; set; }

            [NameInMap("defaultAssignees")]
            [Validation(Required=false)]
            public List<string> DefaultAssignees { get; set; }

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
        public CreateProtectdBranchRequestTestSettingDTO TestSettingDTO { get; set; }
        public class CreateProtectdBranchRequestTestSettingDTO : TeaModel {
            [NameInMap("checkConfig")]
            [Validation(Required=false)]
            public CreateProtectdBranchRequestTestSettingDTOCheckConfig CheckConfig { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOCheckConfig : TeaModel {
                [NameInMap("checkItems")]
                [Validation(Required=false)]
                public List<CreateProtectdBranchRequestTestSettingDTOCheckConfigCheckItems> CheckItems { get; set; }
                public class CreateProtectdBranchRequestTestSettingDTOCheckConfigCheckItems : TeaModel {
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
            public CreateProtectdBranchRequestTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
            public CreateProtectdBranchRequestTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
            public CreateProtectdBranchRequestTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOSensitiveInfoDetection : TeaModel {
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}

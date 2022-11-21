// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateProtectdBranchResponseBody : TeaModel {
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
        public CreateProtectdBranchResponseBodyResult Result { get; set; }
        public class CreateProtectdBranchResponseBodyResult : TeaModel {
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
            public CreateProtectdBranchResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class CreateProtectdBranchResponseBodyResultMergeRequestSetting : TeaModel {
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
            public CreateProtectdBranchResponseBodyResultTestSettingDTO TestSettingDTO { get; set; }
            public class CreateProtectdBranchResponseBodyResultTestSettingDTO : TeaModel {
                [NameInMap("checkConfig")]
                [Validation(Required=false)]
                public CreateProtectdBranchResponseBodyResultTestSettingDTOCheckConfig CheckConfig { get; set; }
                public class CreateProtectdBranchResponseBodyResultTestSettingDTOCheckConfig : TeaModel {
                    [NameInMap("checkItems")]
                    [Validation(Required=false)]
                    public List<CreateProtectdBranchResponseBodyResultTestSettingDTOCheckConfigCheckItems> CheckItems { get; set; }
                    public class CreateProtectdBranchResponseBodyResultTestSettingDTOCheckConfigCheckItems : TeaModel {
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
                public CreateProtectdBranchResponseBodyResultTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
                public class CreateProtectdBranchResponseBodyResultTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
                public CreateProtectdBranchResponseBodyResultTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
                public class CreateProtectdBranchResponseBodyResultTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
                public CreateProtectdBranchResponseBodyResultTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class CreateProtectdBranchResponseBodyResultTestSettingDTOSensitiveInfoDetection : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

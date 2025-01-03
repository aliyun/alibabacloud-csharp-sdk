// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateProtectdBranchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>protectBranch</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>--</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isAllowSelfApproval")]
            [Validation(Required=false)]
            public bool? IsAllowSelfApproval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isRequireDiscussionProcessed")]
            [Validation(Required=false)]
            public bool? IsRequireDiscussionProcessed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isResetApprovalWhenNewPush")]
            [Validation(Required=false)]
            public bool? IsResetApprovalWhenNewPush { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("minimumApproval")]
            [Validation(Required=false)]
            public int? MinimumApproval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>general</para>
            /// </summary>
            [NameInMap("mrMode")]
            [Validation(Required=false)]
            public string MrMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**.java</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("bizNo")]
                [Validation(Required=false)]
                public string BizNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_task_quality</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bz-task-quality</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            [NameInMap("codeGuidelinesDetection")]
            [Validation(Required=false)]
            public CreateProtectdBranchRequestTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOCodeGuidelinesDetection : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_code_guide_lines</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            [NameInMap("sensitiveInfoDetection")]
            [Validation(Required=false)]
            public CreateProtectdBranchRequestTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
            public class CreateProtectdBranchRequestTestSettingDTOSensitiveInfoDetection : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_code_sensitive_info</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}

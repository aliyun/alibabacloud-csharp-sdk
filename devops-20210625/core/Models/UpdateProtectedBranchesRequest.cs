// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProtectedBranchesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

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
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19224</para>
        /// </summary>
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
            public UpdateProtectedBranchesRequestTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
            public UpdateProtectedBranchesRequestTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
            public UpdateProtectedBranchesRequestTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
            public class UpdateProtectedBranchesRequestTestSettingDTOSensitiveInfoDetection : TeaModel {
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
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}

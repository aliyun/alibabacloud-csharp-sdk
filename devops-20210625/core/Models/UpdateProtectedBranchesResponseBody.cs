// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProtectedBranchesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A35869D5-BB29-5F84-A4DD-B09985EA2AFA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateProtectedBranchesResponseBodyResult Result { get; set; }
        public class UpdateProtectedBranchesResponseBodyResult : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("mergeRequestSetting")]
            [Validation(Required=false)]
            public UpdateProtectedBranchesResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class UpdateProtectedBranchesResponseBodyResultMergeRequestSetting : TeaModel {
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
            public UpdateProtectedBranchesResponseBodyResultTestSettingDTO TestSettingDTO { get; set; }
            public class UpdateProtectedBranchesResponseBodyResultTestSettingDTO : TeaModel {
                [NameInMap("checkConfig")]
                [Validation(Required=false)]
                public UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckConfig CheckConfig { get; set; }
                public class UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckConfig : TeaModel {
                    [NameInMap("checkItems")]
                    [Validation(Required=false)]
                    public List<UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckConfigCheckItems> CheckItems { get; set; }
                    public class UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckConfigCheckItems : TeaModel {
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
                public UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
                public class UpdateProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
                    /// <para>biz-task-quality</para>
                    /// </summary>
                    [NameInMap("taskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                }

                [NameInMap("codeGuidelinesDetection")]
                [Validation(Required=false)]
                public UpdateProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
                public class UpdateProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
                public UpdateProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class UpdateProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection : TeaModel {
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListProtectedBranchesResponseBody : TeaModel {
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
        /// <para>313A1BF6-63B7-52D4-A098-952221A65254</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19238</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup-test</para>
                /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19238</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup-test</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>protectedBranch</para>
            /// </summary>
            [NameInMap("branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19285</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                    /// </summary>
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                    /// </summary>
                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>19238</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>codeup-test</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

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
                public ListProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig CheckTaskQualityConfig { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOCheckTaskQualityConfig : TeaModel {
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
                public ListProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection CodeGuidelinesDetection { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOCodeGuidelinesDetection : TeaModel {
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
                public ListProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class ListProtectedBranchesResponseBodyResultTestSettingDTOSensitiveInfoDetection : TeaModel {
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
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

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

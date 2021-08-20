// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListRepositoryProtectedBranchResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListRepositoryProtectedBranchResponseBodyResult> Result { get; set; }
        public class ListRepositoryProtectedBranchResponseBodyResult : TeaModel {
            /// <summary>
            /// 保护分支名称
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// 保护分支 ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 允许推送代码的角色。  40：管理员  30：开发者
            /// </summary>
            [NameInMap("AllowPushRoles")]
            [Validation(Required=false)]
            public List<int?> AllowPushRoles { get; set; }

            /// <summary>
            /// 允许合并的角色。  40：管理员  30：开发者
            /// </summary>
            [NameInMap("AllowMergeRoles")]
            [Validation(Required=false)]
            public List<int?> AllowMergeRoles { get; set; }

            /// <summary>
            /// 代码评审设置
            /// </summary>
            [NameInMap("MergeRequestSetting")]
            [Validation(Required=false)]
            public ListRepositoryProtectedBranchResponseBodyResultMergeRequestSetting MergeRequestSetting { get; set; }
            public class ListRepositoryProtectedBranchResponseBodyResultMergeRequestSetting : TeaModel {
                [NameInMap("MergeRequestMode")]
                [Validation(Required=false)]
                public string MergeRequestMode { get; set; }
                [NameInMap("AllowSelfApproval")]
                [Validation(Required=false)]
                public bool? AllowSelfApproval { get; set; }
                [NameInMap("IsRequireDiscussionProcessed")]
                [Validation(Required=false)]
                public bool? IsRequireDiscussionProcessed { get; set; }
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }
                [NameInMap("MinimumApproval")]
                [Validation(Required=false)]
                public int? MinimumApproval { get; set; }
                [NameInMap("DefaultAssignees")]
                [Validation(Required=false)]
                public List<ListRepositoryProtectedBranchResponseBodyResultMergeRequestSettingDefaultAssignees> DefaultAssignees { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultMergeRequestSettingDefaultAssignees : TeaModel {
                    public string Name { get; set; }
                    public string ExternUid { get; set; }
                    public string AvatarUrl { get; set; }
                    public long? Id { get; set; }
                    public string Email { get; set; }
                }
                [NameInMap("AllowMergeRequestRoles")]
                [Validation(Required=false)]
                public List<string> AllowMergeRequestRoles { get; set; }
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }
            };

            /// <summary>
            /// 自动化检查设置
            /// </summary>
            [NameInMap("TestSetting")]
            [Validation(Required=false)]
            public ListRepositoryProtectedBranchResponseBodyResultTestSetting TestSetting { get; set; }
            public class ListRepositoryProtectedBranchResponseBodyResultTestSetting : TeaModel {
                [NameInMap("Required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }
                [NameInMap("CodingGuidelinesDetection")]
                [Validation(Required=false)]
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection CodingGuidelinesDetection { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCodingGuidelinesDetection : TeaModel {
                    /// <summary>
                    /// 检查信息
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// 合并前是否需要通过Java 代码规约扫描。
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }
                [NameInMap("SensitiveInfoDetection")]
                [Validation(Required=false)]
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection SensitiveInfoDetection { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingSensitiveInfoDetection : TeaModel {
                    /// <summary>
                    /// 检查信息
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// 合并前是否需要通过敏感信息检查
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }
                [NameInMap("CheckConfig")]
                [Validation(Required=false)]
                public ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig CheckConfig { get; set; }
                public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfig : TeaModel {
                    /// <summary>
                    /// 流水线检测列表
                    /// </summary>
                    [NameInMap("CheckItems")]
                    [Validation(Required=false)]
                    public List<ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems> CheckItems { get; set; }
                    public class ListRepositoryProtectedBranchResponseBodyResultTestSettingCheckConfigCheckItems : TeaModel {
                        /// <summary>
                        /// 流水线名称
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// 是否开启检测
                        /// </summary>
                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }
            };

        }

    }

}

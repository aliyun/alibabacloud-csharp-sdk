// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class ListSubTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSubTasksResponseBodyData> Data { get; set; }
        public class ListSubTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>03d1f08455e965cac0351eaa59256fd9</para>
            /// </summary>
            [NameInMap("FileHash")]
            [Validation(Required=false)]
            public string FileHash { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4190063324899520</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c7acb2f1264e4467887ef8f4c36c44ca1</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("TaskResultMessage")]
            [Validation(Required=false)]
            public ListSubTasksResponseBodyDataTaskResultMessage TaskResultMessage { get; set; }
            public class ListSubTasksResponseBodyDataTaskResultMessage : TeaModel {
                [NameInMap("SkillCheckResult")]
                [Validation(Required=false)]
                public ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResult SkillCheckResult { get; set; }
                public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResult : TeaModel {
                    [NameInMap("RiskInfo")]
                    [Validation(Required=false)]
                    public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfo> RiskInfo { get; set; }
                    public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfo : TeaModel {
                        [NameInMap("Ext")]
                        [Validation(Required=false)]
                        public ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExt Ext { get; set; }
                        public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExt : TeaModel {
                            [NameInMap("Config")]
                            [Validation(Required=false)]
                            public ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtConfig Config { get; set; }
                            public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtConfig : TeaModel {
                                [NameInMap("Detail")]
                                [Validation(Required=false)]
                                public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtConfigDetail> Detail { get; set; }
                                public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtConfigDetail : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>allowed-tools: Bash(agent-browser:*)</para>
                                    /// </summary>
                                    [NameInMap("Content")]
                                    [Validation(Required=false)]
                                    public string Content { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>The skill configuration allows Bash execution via agent-browser:* pattern without requiring user confirmation. This enables potentially dangerous command execution through the browser automation CLI.</para>
                                    /// </summary>
                                    [NameInMap("Description")]
                                    [Validation(Required=false)]
                                    public string Description { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>Dangerous Tools Without Confirmation</para>
                                    /// </summary>
                                    [NameInMap("ItemName")]
                                    [Validation(Required=false)]
                                    public string ItemName { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>2555</para>
                                    /// </summary>
                                    [NameInMap("Line")]
                                    [Validation(Required=false)]
                                    public string Line { get; set; }

                                }

                            }

                            [NameInMap("Guardrail")]
                            [Validation(Required=false)]
                            public ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrail Guardrail { get; set; }
                            public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrail : TeaModel {
                                [NameInMap("Detail")]
                                [Validation(Required=false)]
                                public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrailDetail> Detail { get; set; }
                                public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrailDetail : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>high</para>
                                    /// </summary>
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    [NameInMap("Result")]
                                    [Validation(Required=false)]
                                    public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrailDetailResult> Result { get; set; }
                                    public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtGuardrailDetailResult : TeaModel {
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>25</para>
                                        /// </summary>
                                        [NameInMap("Confidence")]
                                        [Validation(Required=false)]
                                        public float? Confidence { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>Suspicious attacks.</para>
                                        /// </summary>
                                        [NameInMap("Description")]
                                        [Validation(Required=false)]
                                        public string Description { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>attack</para>
                                        /// </summary>
                                        [NameInMap("Label")]
                                        [Validation(Required=false)]
                                        public string Label { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>high</para>
                                        /// </summary>
                                        [NameInMap("Level")]
                                        [Validation(Required=false)]
                                        public string Level { get; set; }

                                    }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>block</para>
                                    /// </summary>
                                    [NameInMap("Suggestion")]
                                    [Validation(Required=false)]
                                    public string Suggestion { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>promptAttack</para>
                                    /// </summary>
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>block</para>
                                /// </summary>
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                            }

                            [NameInMap("Sensitive")]
                            [Validation(Required=false)]
                            public ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtSensitive Sensitive { get; set; }
                            public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtSensitive : TeaModel {
                                [NameInMap("Detail")]
                                [Validation(Required=false)]
                                public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtSensitiveDetail> Detail { get; set; }
                                public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtSensitiveDetail : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>aliyun_ak_24</para>
                                    /// </summary>
                                    [NameInMap("Desc")]
                                    [Validation(Required=false)]
                                    public string Desc { get; set; }

                                    [NameInMap("Result")]
                                    [Validation(Required=false)]
                                    public List<string> Result { get; set; }

                                }

                            }

                            [NameInMap("Virus")]
                            [Validation(Required=false)]
                            public List<ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtVirus> Virus { get; set; }
                            public class ListSubTasksResponseBodyDataTaskResultMessageSkillCheckResultRiskInfoExtVirus : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>{}</para>
                                /// </summary>
                                [NameInMap("Ext")]
                                [Validation(Required=false)]
                                public string Ext { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("Score")]
                                [Validation(Required=false)]
                                public int? Score { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>Backdoor</para>
                                /// </summary>
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/home/97e55e6af371836f/</para>
                        /// </summary>
                        [NameInMap("Path")]
                        [Validation(Required=false)]
                        public string Path { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>file</para>
                        /// </summary>
                        [NameInMap("ResultType")]
                        [Validation(Required=false)]
                        public string ResultType { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSubTasksResponseBodyPageInfo PageInfo { get; set; }
        public class ListSubTasksResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9FDE3D6F-26BD-5937-B0E5-8F47962B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

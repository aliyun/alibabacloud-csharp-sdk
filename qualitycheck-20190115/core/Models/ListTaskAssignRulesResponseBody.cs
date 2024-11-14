// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListTaskAssignRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTaskAssignRulesResponseBodyData Data { get; set; }
        public class ListTaskAssignRulesResponseBodyData : TeaModel {
            [NameInMap("TaskAssignRuleInfo")]
            [Validation(Required=false)]
            public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfo> TaskAssignRuleInfo { get; set; }
            public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfo : TeaModel {
                [NameInMap("Agents")]
                [Validation(Required=false)]
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgents Agents { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgents : TeaModel {
                    [NameInMap("Agent")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgentsAgent> Agent { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgentsAgent : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>202526561358712105</para>
                        /// </summary>
                        [NameInMap("AgentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>agent</para>
                        /// </summary>
                        [NameInMap("AgentName")]
                        [Validation(Required=false)]
                        public string AgentName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XX</para>
                /// </summary>
                [NameInMap("AgentsStr")]
                [Validation(Required=false)]
                public string AgentsStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssignmentType")]
                [Validation(Required=false)]
                public int? AssignmentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39600</para>
                /// </summary>
                [NameInMap("CallTimeEnd")]
                [Validation(Required=false)]
                public long? CallTimeEnd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39600</para>
                /// </summary>
                [NameInMap("CallTimeStart")]
                [Validation(Required=false)]
                public long? CallTimeStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-07-12T14:47Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("DurationMax")]
                [Validation(Required=false)]
                public int? DurationMax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DurationMin")]
                [Validation(Required=false)]
                public int? DurationMin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public int? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Reviewers")]
                [Validation(Required=false)]
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewers Reviewers { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewers : TeaModel {
                    [NameInMap("Reviewer")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewersReviewer> Reviewer { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewersReviewer : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2337235457340978</para>
                        /// </summary>
                        [NameInMap("ReviewerId")]
                        [Validation(Required=false)]
                        public string ReviewerId { get; set; }

                        [NameInMap("ReviewerName")]
                        [Validation(Required=false)]
                        public string ReviewerName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRules Rules { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRules : TeaModel {
                    [NameInMap("RuleBasicInfo")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRulesRuleBasicInfo> RuleBasicInfo { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRulesRuleBasicInfo : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2312</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                    }

                }

                [NameInMap("SamplingMode")]
                [Validation(Required=false)]
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingMode SamplingMode { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingMode : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("AnyNumberOfDraws")]
                    [Validation(Required=false)]
                    public int? AnyNumberOfDraws { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Designated")]
                    [Validation(Required=false)]
                    public bool? Designated { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public int? Dimension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("NumberOfDraws")]
                    [Validation(Required=false)]
                    public int? NumberOfDraws { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1</para>
                    /// </summary>
                    [NameInMap("Proportion")]
                    [Validation(Required=false)]
                    public float? Proportion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RandomInspectionNumber")]
                    [Validation(Required=false)]
                    public int? RandomInspectionNumber { get; set; }

                    [NameInMap("SamplingModeAgents")]
                    [Validation(Required=false)]
                    public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingModeSamplingModeAgents SamplingModeAgents { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingModeSamplingModeAgents : TeaModel {
                        [NameInMap("SamplingModeAgent")]
                        [Validation(Required=false)]
                        public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingModeSamplingModeAgentsSamplingModeAgent> SamplingModeAgent { get; set; }
                        public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingModeSamplingModeAgentsSamplingModeAgent : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123</para>
                            /// </summary>
                            [NameInMap("AgentId")]
                            [Validation(Required=false)]
                            public string AgentId { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>zhangsan</para>
                            /// </summary>
                            [NameInMap("AgentName")]
                            [Validation(Required=false)]
                            public string AgentName { get; set; }

                        }

                    }

                }

                [NameInMap("SkillGroups")]
                [Validation(Required=false)]
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroups SkillGroups { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroups : TeaModel {
                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroupsSkillGroup> SkillGroup { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroupsSkillGroup : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>XXX</para>
                        /// </summary>
                        [NameInMap("SkillId")]
                        [Validation(Required=false)]
                        public string SkillId { get; set; }

                        [NameInMap("SkillName")]
                        [Validation(Required=false)]
                        public string SkillName { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XX</para>
                /// </summary>
                [NameInMap("SkillGroupsStr")]
                [Validation(Required=false)]
                public string SkillGroupsStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-07-12T14:47Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

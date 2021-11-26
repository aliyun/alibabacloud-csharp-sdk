// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListTaskAssignRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgents Agents { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgents : TeaModel {
                    [NameInMap("Agent")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgentsAgent> Agent { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoAgentsAgent : TeaModel {
                        [NameInMap("AgentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        [NameInMap("AgentName")]
                        [Validation(Required=false)]
                        public string AgentName { get; set; }

                    }

                }
                public string AgentsStr { get; set; }
                public int? AssignmentType { get; set; }
                public long? CallTimeEnd { get; set; }
                public long? CallTimeStart { get; set; }
                public int? CallType { get; set; }
                public string CreateTime { get; set; }
                public int? DurationMax { get; set; }
                public int? DurationMin { get; set; }
                public int? Enabled { get; set; }
                public int? Priority { get; set; }
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewers Reviewers { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewers : TeaModel {
                    [NameInMap("Reviewer")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewersReviewer> Reviewer { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoReviewersReviewer : TeaModel {
                        [NameInMap("ReviewerId")]
                        [Validation(Required=false)]
                        public string ReviewerId { get; set; }

                        [NameInMap("ReviewerName")]
                        [Validation(Required=false)]
                        public string ReviewerName { get; set; }

                    }

                }
                public long? RuleId { get; set; }
                public string RuleName { get; set; }
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRules Rules { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRules : TeaModel {
                    [NameInMap("RuleBasicInfo")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRulesRuleBasicInfo> RuleBasicInfo { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoRulesRuleBasicInfo : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                    }

                }
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingMode SamplingMode { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSamplingMode : TeaModel {
                    [NameInMap("AnyNumberOfDraws")]
                    [Validation(Required=false)]
                    public int? AnyNumberOfDraws { get; set; }

                    [NameInMap("Designated")]
                    [Validation(Required=false)]
                    public bool? Designated { get; set; }

                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public int? Dimension { get; set; }

                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public int? Limit { get; set; }

                    [NameInMap("NumberOfDraws")]
                    [Validation(Required=false)]
                    public int? NumberOfDraws { get; set; }

                    [NameInMap("Proportion")]
                    [Validation(Required=false)]
                    public float? Proportion { get; set; }

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
                            public string AgentId { get; set; }
                            public string AgentName { get; set; }
                        }
                    };

                }
                public ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroups SkillGroups { get; set; }
                public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroups : TeaModel {
                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public List<ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroupsSkillGroup> SkillGroup { get; set; }
                    public class ListTaskAssignRulesResponseBodyDataTaskAssignRuleInfoSkillGroupsSkillGroup : TeaModel {
                        [NameInMap("SkillId")]
                        [Validation(Required=false)]
                        public string SkillId { get; set; }

                        [NameInMap("SkillName")]
                        [Validation(Required=false)]
                        public string SkillName { get; set; }

                    }

                }
                public string SkillGroupsStr { get; set; }
                public string UpdateTime { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

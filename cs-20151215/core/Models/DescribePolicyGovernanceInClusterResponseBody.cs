// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyGovernanceInClusterResponseBody : TeaModel {
        [NameInMap("Violation")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyViolation Violation { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyViolation : TeaModel {
            [NameInMap("totalViolations")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolations TotalViolations { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolations : TeaModel {
                [NameInMap("deny")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsDeny> Deny { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsDeny : TeaModel {
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public string Violations { get; set; }

                }

                [NameInMap("warn")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsWarn> Warn { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsWarn : TeaModel {
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

            }

            [NameInMap("violations")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationViolations Violations { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationViolations : TeaModel {
                [NameInMap("deny")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationViolationsDeny> Deny { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationViolationsDeny : TeaModel {
                    [NameInMap("policyDescription")]
                    [Validation(Required=false)]
                    public string PolicyDescription { get; set; }

                    [NameInMap("policyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

                [NameInMap("warn")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationViolationsWarn> Warn { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationViolationsWarn : TeaModel {
                    [NameInMap("policyDescription")]
                    [Validation(Required=false)]
                    public string PolicyDescription { get; set; }

                    [NameInMap("policyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The audit logs of the policies in the cluster.</para>
        /// </summary>
        [NameInMap("admit_log")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyAdmitLog AdmitLog { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyAdmitLog : TeaModel {
            /// <summary>
            /// <para>The number of audit log entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            [NameInMap("log_store")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            [NameInMap("logs")]
            [Validation(Required=false)]
            public List<DescribePolicyGovernanceInClusterResponseBodyAdmitLogLogs> Logs { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyAdmitLogLogs : TeaModel {
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("constraint_action")]
                [Validation(Required=false)]
                public string ConstraintAction { get; set; }

                [NameInMap("constraint_api_version")]
                [Validation(Required=false)]
                public string ConstraintApiVersion { get; set; }

                [NameInMap("constraint_category")]
                [Validation(Required=false)]
                public string ConstraintCategory { get; set; }

                [NameInMap("constraint_group")]
                [Validation(Required=false)]
                public string ConstraintGroup { get; set; }

                [NameInMap("constraint_kind")]
                [Validation(Required=false)]
                public string ConstraintKind { get; set; }

                [NameInMap("constraint_name")]
                [Validation(Required=false)]
                public string ConstraintName { get; set; }

                [NameInMap("event_msg")]
                [Validation(Required=false)]
                public string EventMsg { get; set; }

                [NameInMap("event_type")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("request_uid")]
                [Validation(Required=false)]
                public string RequestUid { get; set; }

                [NameInMap("request_userinfo")]
                [Validation(Required=false)]
                public string RequestUserinfo { get; set; }

                [NameInMap("request_username")]
                [Validation(Required=false)]
                public string RequestUsername { get; set; }

                [NameInMap("resource_kind")]
                [Validation(Required=false)]
                public string ResourceKind { get; set; }

                [NameInMap("resource_name")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The status of the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Complete</c>: The query succeeded and the complete query result is returned.</description></item>
            /// <item><description><c>Incomplete</c>: The query succeeded but the query result is incomplete. To obtain the complete query result, you must repeat the request.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>Details about the policies of different severity levels that are enabled for the cluster.</para>
        /// </summary>
        [NameInMap("on_state")]
        [Validation(Required=false)]
        public List<DescribePolicyGovernanceInClusterResponseBodyOnState> OnState { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyOnState : TeaModel {
            /// <summary>
            /// <para>The number of policies that are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("enabled_count")]
            [Validation(Required=false)]
            public int? EnabledCount { get; set; }

            /// <summary>
            /// <para>The severity level of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The total number of policies of the severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyGovernanceInClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The policy violation information aggregated by severity level.</para>
        /// </summary>
        [NameInMap("Violation")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyViolation Violation { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyViolation : TeaModel {
            /// <summary>
            /// <para>The summary information.</para>
            /// </summary>
            [NameInMap("totalViolations")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolations TotalViolations { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolations : TeaModel {
                /// <summary>
                /// <para>The summary of block records.</para>
                /// </summary>
                [NameInMap("deny")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsDeny> Deny { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsDeny : TeaModel {
                    /// <summary>
                    /// <para>The severity level. Valid values: low, medium, and high.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>medium</para>
                    /// </summary>
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The number of violations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public string Violations { get; set; }

                }

                /// <summary>
                /// <para>The summary of alert records.</para>
                /// </summary>
                [NameInMap("warn")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsWarn> Warn { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationTotalViolationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The summary of severity levels.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The total number of violations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

            }

            /// <summary>
            /// <para>The violation records aggregated by policy name.</para>
            /// </summary>
            [NameInMap("violations")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationViolations Violations { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationViolations : TeaModel {
                /// <summary>
                /// <para>The summary of block records.</para>
                /// </summary>
                [NameInMap("deny")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationViolationsDeny> Deny { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationViolationsDeny : TeaModel {
                    /// <summary>
                    /// <para>The policy description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Prevent specific namespaces from being deleted.</para>
                    /// </summary>
                    [NameInMap("policyDescription")]
                    [Validation(Required=false)]
                    public string PolicyDescription { get; set; }

                    /// <summary>
                    /// <para>The policy name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACKNamespacesDeleteProtection</para>
                    /// </summary>
                    [NameInMap("policyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    /// <summary>
                    /// <para>The severity level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>medium</para>
                    /// </summary>
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The number of violations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

                /// <summary>
                /// <para>The summary of alert information.</para>
                /// </summary>
                [NameInMap("warn")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyViolationViolationsWarn> Warn { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyViolationViolationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The policy description.</para>
                    /// </summary>
                    [NameInMap("policyDescription")]
                    [Validation(Required=false)]
                    public string PolicyDescription { get; set; }

                    /// <summary>
                    /// <para>The policy name.</para>
                    /// </summary>
                    [NameInMap("policyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                    /// <summary>
                    /// <para>The severity level.</para>
                    /// </summary>
                    [NameInMap("severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// <para>The number of violations.</para>
                    /// </summary>
                    [NameInMap("violations")]
                    [Validation(Required=false)]
                    public long? Violations { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The policy governance audit logs of the current cluster.</para>
        /// </summary>
        [NameInMap("admit_log")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyAdmitLog AdmitLog { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyAdmitLog : TeaModel {
            /// <summary>
            /// <para>The total number of logs returned by the current query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The log project that stores policy action information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-log-clusterid</para>
            /// </summary>
            [NameInMap("log_project")]
            [Validation(Required=false)]
            public string LogProject { get; set; }

            /// <summary>
            /// <para>The Logstore that stores policy action information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policyadmit-clusterid</para>
            /// </summary>
            [NameInMap("log_store")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The log entries for policy violations.</para>
            /// </summary>
            [NameInMap("logs")]
            [Validation(Required=false)]
            public List<DescribePolicyGovernanceInClusterResponseBodyAdmitLogLogs> Logs { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyAdmitLogLogs : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hash code</para>
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The action taken by the policy, including alert (warn) and block (deny). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>warn: Only alerts on behaviors that violate the policy without actually blocking the request.</description></item>
                /// <item><description>deny: Blocks requests that violate the policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("constraint_action")]
                [Validation(Required=false)]
                public string ConstraintAction { get; set; }

                /// <summary>
                /// <para>The API version of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1beta1</para>
                /// </summary>
                [NameInMap("constraint_api_version")]
                [Validation(Required=false)]
                public string ConstraintApiVersion { get; set; }

                /// <summary>
                /// <para>The policy type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cis-k8s</para>
                /// </summary>
                [NameInMap("constraint_category")]
                [Validation(Required=false)]
                public string ConstraintCategory { get; set; }

                /// <summary>
                /// <para>The API group of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>constraints.gatekeeper.sh</para>
                /// </summary>
                [NameInMap("constraint_group")]
                [Validation(Required=false)]
                public string ConstraintGroup { get; set; }

                /// <summary>
                /// <para>The policy name in policy management.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACKNamespacesDeleteProtection</para>
                /// </summary>
                [NameInMap("constraint_kind")]
                [Validation(Required=false)]
                public string ConstraintKind { get; set; }

                /// <summary>
                /// <para>The policy instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace-delete-protection-jpjwv</para>
                /// </summary>
                [NameInMap("constraint_name")]
                [Validation(Required=false)]
                public string ConstraintName { get; set; }

                /// <summary>
                /// <para>The detailed information about the policy action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admission webhook \&quot;validation.gatekeeper.sh\&quot; denied request, Resource Namespace: , Constraint: namespace-delete-protection-jpjwv, Message: not allow to delete protection namespace test.</para>
                /// </summary>
                [NameInMap("event_msg")]
                [Validation(Required=false)]
                public string EventMsg { get; set; }

                /// <summary>
                /// <para>The type of event triggered by the policy, such as violation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>violation</para>
                /// </summary>
                [NameInMap("event_type")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hash code</para>
                /// </summary>
                [NameInMap("request_uid")]
                [Validation(Required=false)]
                public string RequestUid { get; set; }

                /// <summary>
                /// <para>The information about the user whose request violated the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>account id</para>
                /// </summary>
                [NameInMap("request_userinfo")]
                [Validation(Required=false)]
                public string RequestUserinfo { get; set; }

                /// <summary>
                /// <para>The name of the user whose request violated the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>account user name</para>
                /// </summary>
                [NameInMap("request_username")]
                [Validation(Required=false)]
                public string RequestUsername { get; set; }

                /// <summary>
                /// <para>The type of resource that violated the policy. For example, if a request to operate on a Namespace is rejected, this field is set to Namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Namespace</para>
                /// </summary>
                [NameInMap("resource_kind")]
                [Validation(Required=false)]
                public string ResourceKind { get; set; }

                /// <summary>
                /// <para>The name of the resource that violated the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("resource_name")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The time when the policy violation occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-27T11:31:40Z</para>
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The status of the query result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Complete</c>: The query is complete and the returned result is the complete result.</description></item>
            /// <item><description><c>Incomplete</c>: The query is complete but the returned result is incomplete. Repeat the request to obtain the complete result.</description></item>
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
        /// <para>The count of enabled policies at different severity levels in the current cluster.</para>
        /// </summary>
        [NameInMap("on_state")]
        [Validation(Required=false)]
        public List<DescribePolicyGovernanceInClusterResponseBodyOnState> OnState { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyOnState : TeaModel {
            /// <summary>
            /// <para>The number of enabled policy types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("enabled_count")]
            [Validation(Required=false)]
            public int? EnabledCount { get; set; }

            /// <summary>
            /// <para>The policy governance severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The total number of policy types at this severity level.</para>
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

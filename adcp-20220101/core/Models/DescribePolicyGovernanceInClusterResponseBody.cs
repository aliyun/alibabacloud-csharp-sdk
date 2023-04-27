// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyGovernanceInClusterResponseBody : TeaModel {
        [NameInMap("PolicyGovernances")]
        [Validation(Required=false)]
        public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernances> PolicyGovernances { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernances : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesCluster Cluster { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesCluster : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterSpec")]
                [Validation(Required=false)]
                public string ClusterSpec { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("PolicyGovernance")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernance PolicyGovernance { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernance : TeaModel {
                [NameInMap("AdmitLog")]
                [Validation(Required=false)]
                public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceAdmitLog AdmitLog { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceAdmitLog : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public string Count { get; set; }

                    [NameInMap("LogProject")]
                    [Validation(Required=false)]
                    public string LogProject { get; set; }

                    [NameInMap("LogStore")]
                    [Validation(Required=false)]
                    public string LogStore { get; set; }

                    [NameInMap("Logs")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, string>> Logs { get; set; }

                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                }

                [NameInMap("OnState")]
                [Validation(Required=false)]
                public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceOnState> OnState { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceOnState : TeaModel {
                    [NameInMap("EnabledCount")]
                    [Validation(Required=false)]
                    public long? EnabledCount { get; set; }

                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                }

                [NameInMap("Violation")]
                [Validation(Required=false)]
                public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolation Violation { get; set; }
                public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolation : TeaModel {
                    [NameInMap("TotalViolations")]
                    [Validation(Required=false)]
                    public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolations TotalViolations { get; set; }
                    public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolations : TeaModel {
                        [NameInMap("Deny")]
                        [Validation(Required=false)]
                        public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolationsDeny> Deny { get; set; }
                        public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolationsDeny : TeaModel {
                            [NameInMap("Severity")]
                            [Validation(Required=false)]
                            public string Severity { get; set; }

                            [NameInMap("Violations")]
                            [Validation(Required=false)]
                            public long? Violations { get; set; }

                        }

                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolationsWarn> Warn { get; set; }
                        public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationTotalViolationsWarn : TeaModel {
                            [NameInMap("Severity")]
                            [Validation(Required=false)]
                            public string Severity { get; set; }

                            [NameInMap("Violations")]
                            [Validation(Required=false)]
                            public string Violations { get; set; }

                        }

                    }

                    [NameInMap("Violations")]
                    [Validation(Required=false)]
                    public DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolations Violations { get; set; }
                    public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolations : TeaModel {
                        [NameInMap("Deny")]
                        [Validation(Required=false)]
                        public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolationsDeny> Deny { get; set; }
                        public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolationsDeny : TeaModel {
                            [NameInMap("PolicyDescription")]
                            [Validation(Required=false)]
                            public string PolicyDescription { get; set; }

                            [NameInMap("PolicyName")]
                            [Validation(Required=false)]
                            public string PolicyName { get; set; }

                            [NameInMap("Severity")]
                            [Validation(Required=false)]
                            public string Severity { get; set; }

                            [NameInMap("Violations")]
                            [Validation(Required=false)]
                            public long? Violations { get; set; }

                        }

                        [NameInMap("Warn")]
                        [Validation(Required=false)]
                        public List<DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolationsWarn> Warn { get; set; }
                        public class DescribePolicyGovernanceInClusterResponseBodyPolicyGovernancesPolicyGovernanceViolationViolationsWarn : TeaModel {
                            [NameInMap("PolicyDescription")]
                            [Validation(Required=false)]
                            public string PolicyDescription { get; set; }

                            [NameInMap("PolicyName")]
                            [Validation(Required=false)]
                            public string PolicyName { get; set; }

                            [NameInMap("Severity")]
                            [Validation(Required=false)]
                            public string Severity { get; set; }

                            [NameInMap("Violations")]
                            [Validation(Required=false)]
                            public long? Violations { get; set; }

                        }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

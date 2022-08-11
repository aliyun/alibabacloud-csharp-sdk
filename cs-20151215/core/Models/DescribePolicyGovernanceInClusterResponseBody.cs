// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyGovernanceInClusterResponseBody : TeaModel {
        [NameInMap("admit_log")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyAdmitLog AdmitLog { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyAdmitLog : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }
            [NameInMap("log")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyAdmitLogLog Log { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyAdmitLogLog : TeaModel {
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("constraint_kind")]
                [Validation(Required=false)]
                public string ConstraintKind { get; set; }

                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("resource_kind")]
                [Validation(Required=false)]
                public string ResourceKind { get; set; }

                [NameInMap("resource_name")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("resource_namespace")]
                [Validation(Required=false)]
                public string ResourceNamespace { get; set; }

            }
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        [NameInMap("on_state")]
        [Validation(Required=false)]
        public List<DescribePolicyGovernanceInClusterResponseBodyOnState> OnState { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyOnState : TeaModel {
            [NameInMap("enabled_count")]
            [Validation(Required=false)]
            public int? EnabledCount { get; set; }

            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("totalViolations")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyTotalViolations TotalViolations { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyTotalViolations : TeaModel {
            [NameInMap("deny")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyTotalViolationsDeny Deny { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyTotalViolationsDeny : TeaModel {
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
            [NameInMap("warn")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyTotalViolationsWarn Warn { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyTotalViolationsWarn : TeaModel {
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
        };

        [NameInMap("violations")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyViolations Violations { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyViolations : TeaModel {
            [NameInMap("deny")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationsDeny Deny { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationsDeny : TeaModel {
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
            public DescribePolicyGovernanceInClusterResponseBodyViolationsWarn Warn { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationsWarn : TeaModel {
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
        };

    }

}

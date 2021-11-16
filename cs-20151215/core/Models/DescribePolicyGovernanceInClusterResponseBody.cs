// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyGovernanceInClusterResponseBody : TeaModel {
        /// <summary>
        /// 集群当前策略治理审计日志
        /// </summary>
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
                /// <summary>
                /// 目标集群ID
                /// </summary>
                [NameInMap("cluster_id")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// 策略类型名称
                /// </summary>
                [NameInMap("constraint_kind")]
                [Validation(Required=false)]
                public string ConstraintKind { get; set; }

                /// <summary>
                /// 策略治理审计日志信息
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// 目标资源类型
                /// </summary>
                [NameInMap("resource_kind")]
                [Validation(Required=false)]
                public string ResourceKind { get; set; }

                /// <summary>
                /// 目标资源名称
                /// </summary>
                [NameInMap("resource_name")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// 目标资源命名空间
                /// </summary>
                [NameInMap("resource_namespace")]
                [Validation(Required=false)]
                public string ResourceNamespace { get; set; }

            }
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        /// <summary>
        /// 当前集群中开启的不同等级策略计数统计
        /// </summary>
        [NameInMap("on_state")]
        [Validation(Required=false)]
        public List<DescribePolicyGovernanceInClusterResponseBodyOnState> OnState { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyOnState : TeaModel {
            /// <summary>
            /// 当前开启的策略种类计数
            /// </summary>
            [NameInMap("enabled_count")]
            [Validation(Required=false)]
            public int? EnabledCount { get; set; }

            /// <summary>
            /// 策略治理等级
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// 该等级下策略种类总数
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// 集群中当前被拦截和告警两种处理类型下不同治理等级的违规计数。
        /// </summary>
        [NameInMap("totalViolations")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyTotalViolations TotalViolations { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyTotalViolations : TeaModel {
            [NameInMap("deny")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyTotalViolationsDeny Deny { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyTotalViolationsDeny : TeaModel {
                /// <summary>
                /// 策略治理等级
                /// </summary>
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// 被拦截的事件计数
                /// </summary>
                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
            [NameInMap("warn")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyTotalViolationsWarn Warn { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyTotalViolationsWarn : TeaModel {
                /// <summary>
                /// 策略治理等级
                /// </summary>
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// 告警的事件计数
                /// </summary>
                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
        };

        /// <summary>
        /// 集群中针对不同策略类型的拦截和告警的审计计数统计列表
        /// </summary>
        [NameInMap("violations")]
        [Validation(Required=false)]
        public DescribePolicyGovernanceInClusterResponseBodyViolations Violations { get; set; }
        public class DescribePolicyGovernanceInClusterResponseBodyViolations : TeaModel {
            [NameInMap("deny")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationsDeny Deny { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationsDeny : TeaModel {
                /// <summary>
                /// 策略描述
                /// </summary>
                [NameInMap("policyDescription")]
                [Validation(Required=false)]
                public string PolicyDescription { get; set; }

                /// <summary>
                /// 策略名称
                /// </summary>
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// 策略治理等级
                /// </summary>
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// 对应规则的事件计数
                /// </summary>
                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
            [NameInMap("warn")]
            [Validation(Required=false)]
            public DescribePolicyGovernanceInClusterResponseBodyViolationsWarn Warn { get; set; }
            public class DescribePolicyGovernanceInClusterResponseBodyViolationsWarn : TeaModel {
                /// <summary>
                /// 策略描述
                /// </summary>
                [NameInMap("policyDescription")]
                [Validation(Required=false)]
                public string PolicyDescription { get; set; }

                /// <summary>
                /// 策略名称
                /// </summary>
                [NameInMap("policyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// 策略治理等级
                /// </summary>
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// 对应规则的事件计数
                /// </summary>
                [NameInMap("violations")]
                [Validation(Required=false)]
                public long? Violations { get; set; }

            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetScalingRulesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScalingRulesResponseBodyData Data { get; set; }
        public class GetScalingRulesResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the cluster. Valid values:
            /// 
            /// *   0: regular Docker cluster
            /// *   1: Swarm cluster (deprecated)
            /// *   2: Elastic Compute Service (ECS) cluster
            /// *   3: self-managed Kubernetes cluster in EDAS
            /// *   4: cluster in which Pandora automatically registers applications
            /// *   5: Container Service for Kubernetes (ACK) clusters
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }

            /// <summary>
            /// The overcommit ratio supported by a Docker cluster. Valid values:
            /// 
            /// *   1: 1:1, which means that resources are not overcommitted.
            /// *   2: 1:2, which means that resources are overcommitted by 1:2.
            /// *   4: 1:4, which means that resources are overcommitted by 1:4.
            /// *   8: 1:8, which means that resources are overcommitted by 1:8.
            /// </summary>
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }

            /// <summary>
            /// The array data of the scaling rule.
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetScalingRulesResponseBodyDataRuleList RuleList { get; set; }
            public class GetScalingRulesResponseBodyDataRuleList : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<GetScalingRulesResponseBodyDataRuleListRule> Rule { get; set; }
                public class GetScalingRulesResponseBodyDataRuleListRule : TeaModel {
                    /// <summary>
                    /// The ID of the application.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The relationship among the conditions that trigger the scaling rule.
                    /// 
                    /// *   OR: one of the conditions
                    /// *   AND: all conditions
                    /// </summary>
                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    /// <summary>
                    /// The minimum CPU utilization that triggers the scaling rule.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    /// <summary>
                    /// The time when the scaling rule was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The duration of the scaling rule. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    /// <summary>
                    /// Indicates whether scale-ins or scale-outs are allowed. Valid values:
                    /// 
                    /// *   true: Scale-ins or scale-outs are allowed.
                    /// *   false: Scale-ins or scale-outs are disallowed.
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// The ID of the instance group to which the application is deployed.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The maximum number of instances in the group when a scale-out is performed, or the minimum number of instances in the group when a scale-in is performed.
                    /// </summary>
                    [NameInMap("InstNum")]
                    [Validation(Required=false)]
                    public int? InstNum { get; set; }

                    /// <summary>
                    /// The system load that triggers the scaling rule. The system load is evaluated based on the number of processes that are being executed by CPUs and the number of processes that wait to be executed by CPUs.
                    /// </summary>
                    [NameInMap("LoadNum")]
                    [Validation(Required=false)]
                    public int? LoadNum { get; set; }

                    /// <summary>
                    /// The type of the metric.
                    /// </summary>
                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    /// <summary>
                    /// The type of the scaling rule. Valid values:
                    /// 
                    /// *   SCALE_IN: scale-in rules
                    /// *   SCALE_OUT: scale-out rules
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// The policy of auto scaling across multiple zones. Valid values:
                    /// 
                    /// *   PRIORITY: The vSwitch that is first selected has the highest priority.
                    /// *   BALANCE: This policy evenly distributes instances across zones in which the vSwitches reside.
                    /// </summary>
                    [NameInMap("MultiAzPolicy")]
                    [Validation(Required=false)]
                    public string MultiAzPolicy { get; set; }

                    /// <summary>
                    /// The source of the instance that you want to add during a scale-out. Valid values:
                    /// 
                    /// *   NEW: Elastic resources are used.
                    /// *   AVAILABLE: The existing resources are used.
                    /// *   AVAILABLE_FIRST: The existing resources are used first.
                    /// </summary>
                    [NameInMap("ResourceFrom")]
                    [Validation(Required=false)]
                    public string ResourceFrom { get; set; }

                    /// <summary>
                    /// The service latency that triggers the scaling rule. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public int? Rt { get; set; }

                    /// <summary>
                    /// The ID of the specification.
                    /// </summary>
                    [NameInMap("SpecId")]
                    [Validation(Required=false)]
                    public string SpecId { get; set; }

                    /// <summary>
                    /// The number of instances that are added during each scale-out or removed during each scale-in.
                    /// </summary>
                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    /// <summary>
                    /// The ID of the launch template.
                    /// </summary>
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// The version of the launch template.
                    /// </summary>
                    [NameInMap("TemplateVersion")]
                    [Validation(Required=false)]
                    public int? TemplateVersion { get; set; }

                    /// <summary>
                    /// The time when the scaling rule was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// The IDs of the vSwitches. The IDs of multiple vSwitches are separated by commas (,).
                    /// </summary>
                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    /// <summary>
                    /// The ID of the VPC.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// The time when the scaling rule was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the scaling rule was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}

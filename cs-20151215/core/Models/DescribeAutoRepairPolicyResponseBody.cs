// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAutoRepairPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-xxx</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of resources affected by the auto-repair rule.</para>
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The subtype of the resource affected by the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The resource type affected by the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<DescribeAutoRepairPolicyResponseBodyRules> Rules { get; set; }
        public class DescribeAutoRepairPolicyResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The detected incidents that trigger the rule.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<DescribeAutoRepairPolicyResponseBodyRulesIncidents> Incidents { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesIncidents : TeaModel {
                /// <summary>
                /// <para>The incident name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node.FaultNeedReboot.HOST</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The incident type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The repair procedure, which contains a list of repair actions.</para>
            /// </summary>
            [NameInMap("repair_procedure")]
            [Validation(Required=false)]
            public List<DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure> RepairProcedure { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure : TeaModel {
                /// <summary>
                /// <para>The configuration parameters for the repair action.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The manual approval configuration.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention Intervention { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label you add to a node to approve a repair action. When ACK detects this label, it proceeds with the current repair step. After the action is complete, ACK automatically removes both the inquiring and approved labels. If you do not add this label promptly, the repair procedure is paused, and the node may remain unhealthy.</para>
                    /// </summary>
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel : TeaModel {
                        /// <summary>
                        /// <para>The label\&quot;s <c>key</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The label\&quot;s value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>approved</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable manual approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>When a repair procedure reaches this step, ACK applies this label to the affected node and pauses until you grant approval.</para>
                    /// </summary>
                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel : TeaModel {
                        /// <summary>
                        /// <para>The label key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The label value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>inquiring</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The manual approval type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>label</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The name of the repair action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuarantineGPU</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}

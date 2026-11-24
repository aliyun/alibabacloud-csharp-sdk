// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAutoRepairPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The self-healing rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-xxx</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the self-healing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of resources bound to the self-healing rule.</para>
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource subtype bound to the self-healing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The resource type bound to the self-healing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of self-healing sub-rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<DescribeAutoRepairPolicyResponseBodyRules> Rules { get; set; }
        public class DescribeAutoRepairPolicyResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The list of identified faults.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<DescribeAutoRepairPolicyResponseBodyRulesIncidents> Incidents { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesIncidents : TeaModel {
                /// <summary>
                /// <para>The name of the fault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node.FaultNeedReboot.HOST</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the fault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The repair procedure.</para>
            /// </summary>
            [NameInMap("repair_procedure")]
            [Validation(Required=false)]
            public List<DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure> RepairProcedure { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure : TeaModel {
                /// <summary>
                /// <para>The configuration parameters of the procedure.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The manual intervention procedure configuration.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention Intervention { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label configuration for authorization confirmation. When you add the following labels to the node, you authorize ACK to execute the action for this stage. After completing the action for this stage, ACK automatically removes the authorization inquiry and confirmation labels for this stage. If you do not add the following labels in time to grant authorization, ACK will not execute the action for this stage and subsequent actions, and the node may remain in a damaged state.</para>
                    /// </summary>
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel : TeaModel {
                        /// <summary>
                        /// <para>The key of the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>approved</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether manual approval is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The label configuration for authorization inquiry. When this stage is reached, ACK adds the following labels to your node and waits for your authorization to execute the action for this stage.</para>
                    /// </summary>
                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel : TeaModel {
                        /// <summary>
                        /// <para>The key of the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>inquiring</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of manual approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>label</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The name of the procedure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QuarantineGPU</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The rule type. Valid values (case-sensitive):</para>
        /// <list type="bullet">
        /// <item><description>custom: User-defined rule. Supports modification and deletion.</description></item>
        /// <item><description>builtin: System built-in rule. Read-only. Does not support creation, modification, or deletion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAutoRepairPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The auto-repair rule ID.</para>
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
        /// <para>The list of resources associated with the auto-repair rule.</para>
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The sub-type of resource associated with the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The type of resource associated with the auto-repair rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of auto-repair sub-rules.</para>
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
                /// <para>The fault name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node.FaultNeedReboot.HOST</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The fault type.</para>
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
                /// <para>The configuration for manual intervention in the procedure.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention Intervention { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label configuration for authorization approval. When you add the following label to the node, you authorize ACK to perform the action of this stage. After completing the action, ACK automatically removes the authorization inquiry and approval labels for this stage. If you do not add the following label for authorization in a timely manner, ACK will not perform the action of this stage or subsequent actions, and the node may remain in a damaged state.</para>
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
                    /// <para>Specifies whether to enable manual approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The label configuration for authorization inquiry. When this stage is reached, ACK adds the following label to your node and waits for your authorization to perform the action of this stage.</para>
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

    }

}

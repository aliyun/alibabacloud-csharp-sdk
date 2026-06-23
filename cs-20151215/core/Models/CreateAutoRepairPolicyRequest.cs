// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoRepairPolicyRequest : TeaModel {
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
        /// <para>The resource subtype that the self-healing rule can be bound to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The resource type that the self-healing rule can be bound to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of self-healing sub-rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;np-xxx&quot;]</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<CreateAutoRepairPolicyRequestRules> Rules { get; set; }
        public class CreateAutoRepairPolicyRequestRules : TeaModel {
            /// <summary>
            /// <para>The list of identified faults.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class CreateAutoRepairPolicyRequestRulesIncidents : TeaModel {
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
            public List<CreateAutoRepairPolicyRequestRulesRepairProcedure> RepairProcedure { get; set; }
            public class CreateAutoRepairPolicyRequestRulesRepairProcedure : TeaModel {
                /// <summary>
                /// <para>The configuration parameters of the repair procedure.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The configuration for manual intervention in the procedure.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label configuration for authorization confirmation. When you add the following label to the node, you authorize ACK to execute the action in this stage. After completing the action in this stage, ACK automatically removes the authorization inquiry and authorization confirmation labels for this stage. If you do not add the following label to authorize the action promptly, ACK does not execute the action in this stage or subsequent actions, and the node may remain in a damaged state.</para>
                    /// </summary>
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                    /// <para>The label configuration for authorization inquiry. When this stage is reached, ACK adds the following label to your node and waits for you to authorize the execution of the action in this stage.</para>
                    /// </summary>
                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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
                /// <para>Drain</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}

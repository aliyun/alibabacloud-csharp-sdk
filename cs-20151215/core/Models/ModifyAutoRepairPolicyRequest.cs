// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyAutoRepairPolicyRequest : TeaModel {
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
        /// <para>The list of self-healing sub-rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<ModifyAutoRepairPolicyRequestRules> Rules { get; set; }
        public class ModifyAutoRepairPolicyRequestRules : TeaModel {
            /// <summary>
            /// <para>The list of identified faults.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<ModifyAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class ModifyAutoRepairPolicyRequestRulesIncidents : TeaModel {
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
                /// <para>The type of manual approval.</para>
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
            public List<ModifyAutoRepairPolicyRequestRulesRepairProcedure> RepairProcedure { get; set; }
            public class ModifyAutoRepairPolicyRequestRulesRepairProcedure : TeaModel {
                /// <summary>
                /// <para>The parameter settings of the flow.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The configuration for manual intervention in the procedure.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public ModifyAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class ModifyAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label configuration for authorization confirmation. When you add the following labels to the node, you authorize ACK to perform the operations in this phase. After completing the phase operations, ACK automatically removes the authorization inquiry and authorization confirmation labels for this phase. If you do not promptly add the following labels for authorization, ACK does not perform the actions in this phase or subsequent phases, and the node may remain in a damaged state.</para>
                    /// </summary>
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel : TeaModel {
                        /// <summary>
                        /// <para>The label key value.</para>
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
                    /// <para>The label configuration for authorization inquiry. When this phase is reached, ACK adds the following labels to your node and waits for you to authorize the execution of the phase action.</para>
                    /// </summary>
                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel : TeaModel {
                        /// <summary>
                        /// <para>The label key value.</para>
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
                    /// <para>The type of approval.</para>
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

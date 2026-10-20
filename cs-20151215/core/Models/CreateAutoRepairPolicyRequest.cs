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
        /// <para>The resource subtype to which the self-healing rule can be bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The resource type to which the self-healing rule can be bound.</para>
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
            /// <para>The list of identified incidents.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class CreateAutoRepairPolicyRequestRulesIncidents : TeaModel {
                /// <summary>
                /// <para>The name of the incident.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node.FaultNeedReboot.HOST</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the incident.</para>
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
                /// <para>The configuration parameters for the repair procedure.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The manual intervention process.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label configuration for authorization confirmation. Adding the following labels to the node indicates that you authorize ACK to execute the action for this stage. After completing the action for this stage, ACK automatically removes the authorization inquiry and authorization confirmation labels corresponding to this stage. If you do not add the following labels in time to grant authorization, ACK will not execute the action for this stage and subsequent actions, and the node may remain in an impaired state.</para>
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
                    /// <para>The label configuration for authorization inquiry. When this stage is reached, ACK adds the following labels to your node and waits for your authorization to execute the action for this stage.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoRepairPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the auto repair policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource subtype to which the auto repair policy applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <para>The resource type to which the auto repair policy applies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The sub-rules for the auto repair policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;np-xxx&quot;]</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<CreateAutoRepairPolicyRequestRules> Rules { get; set; }
        public class CreateAutoRepairPolicyRequestRules : TeaModel {
            /// <summary>
            /// <para>The incidents that the rule detects.</para>
            /// </summary>
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class CreateAutoRepairPolicyRequestRulesIncidents : TeaModel {
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
            /// <para>The repair procedure.</para>
            /// </summary>
            [NameInMap("repair_procedure")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesRepairProcedure> RepairProcedure { get; set; }
            public class CreateAutoRepairPolicyRequestRulesRepairProcedure : TeaModel {
                /// <summary>
                /// <para>Configuration parameters for the repair step.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>Settings for manual intervention.</para>
                /// </summary>
                [NameInMap("intervention")]
                [Validation(Required=false)]
                public CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    /// <summary>
                    /// <para>The label that grants authorization for the repair step. To approve the step, add this label to the node. After the action is complete, ACK automatically removes both the inquiry and approval labels for this step. If this label is not added promptly, the repair procedure halts and the node remains impaired.</para>
                    /// </summary>
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                    /// <para>The label used to request authorization for the repair step. When this step begins, ACK applies this label to the node and waits for approval before performing the action.</para>
                    /// </summary>
                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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
                /// <para>The name of the repair step.</para>
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

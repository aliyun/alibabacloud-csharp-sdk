// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoRepairPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ess</para>
        /// </summary>
        [NameInMap("resource_sub_type")]
        [Validation(Required=false)]
        public string ResourceSubType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nodepool</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;np-xxx&quot;]</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<CreateAutoRepairPolicyRequestRules> Rules { get; set; }
        public class CreateAutoRepairPolicyRequestRules : TeaModel {
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class CreateAutoRepairPolicyRequestRulesIncidents : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<CreateAutoRepairPolicyRequestRulesIncidentsConditions> Conditions { get; set; }
                public class CreateAutoRepairPolicyRequestRulesIncidentsConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>False</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>KubeletReady</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("events")]
                [Validation(Required=false)]
                public List<CreateAutoRepairPolicyRequestRulesIncidentsEvents> Events { get; set; }
                public class CreateAutoRepairPolicyRequestRulesIncidentsEvents : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Node.FaultNeedReboot.HOST</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("repair_procedure")]
            [Validation(Required=false)]
            public List<CreateAutoRepairPolicyRequestRulesRepairProcedure> RepairProcedure { get; set; }
            public class CreateAutoRepairPolicyRequestRulesRepairProcedure : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                [NameInMap("intervention")]
                [Validation(Required=false)]
                public CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class CreateAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>approved</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("inquiring_label")]
                    [Validation(Required=false)]
                    public CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class CreateAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>k8s.aliyun.com/incident</para>
                        /// </summary>
                        [NameInMap("key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>inquiring</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>label</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
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

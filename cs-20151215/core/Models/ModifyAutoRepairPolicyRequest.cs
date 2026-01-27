// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyAutoRepairPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<ModifyAutoRepairPolicyRequestRules> Rules { get; set; }
        public class ModifyAutoRepairPolicyRequestRules : TeaModel {
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<ModifyAutoRepairPolicyRequestRulesIncidents> Incidents { get; set; }
            public class ModifyAutoRepairPolicyRequestRulesIncidents : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<ModifyAutoRepairPolicyRequestRulesIncidentsConditions> Conditions { get; set; }
                public class ModifyAutoRepairPolicyRequestRulesIncidentsConditions : TeaModel {
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
                public List<ModifyAutoRepairPolicyRequestRulesIncidentsEvents> Events { get; set; }
                public class ModifyAutoRepairPolicyRequestRulesIncidentsEvents : TeaModel {
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
            public List<ModifyAutoRepairPolicyRequestRulesRepairProcedure> RepairProcedure { get; set; }
            public class ModifyAutoRepairPolicyRequestRulesRepairProcedure : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                [NameInMap("intervention")]
                [Validation(Required=false)]
                public ModifyAutoRepairPolicyRequestRulesRepairProcedureIntervention Intervention { get; set; }
                public class ModifyAutoRepairPolicyRequestRulesRepairProcedureIntervention : TeaModel {
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                    public ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class ModifyAutoRepairPolicyRequestRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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
                /// <para>QuarantineGPU</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}

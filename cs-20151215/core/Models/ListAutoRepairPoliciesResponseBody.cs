// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAutoRepairPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The self-healing rules.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAutoRepairPoliciesResponseBodyItems> Items { get; set; }
        public class ListAutoRepairPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the self-healing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-xxxxx</para>
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
            public List<ListAutoRepairPoliciesResponseBodyItemsRules> Rules { get; set; }
            public class ListAutoRepairPoliciesResponseBodyItemsRules : TeaModel {
                /// <summary>
                /// <para>The list of identified incidents.</para>
                /// </summary>
                [NameInMap("incidents")]
                [Validation(Required=false)]
                public List<ListAutoRepairPoliciesResponseBodyItemsRulesIncidents> Incidents { get; set; }
                public class ListAutoRepairPoliciesResponseBodyItemsRulesIncidents : TeaModel {
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
                    /// <para>The diagnostic type.</para>
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
                public List<ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedure> RepairProcedure { get; set; }
                public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedure : TeaModel {
                    /// <summary>
                    /// <para>The configuration parameters of the procedure.</para>
                    /// </summary>
                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Config { get; set; }

                    /// <summary>
                    /// <para>The manual intervention configuration for the procedure.</para>
                    /// </summary>
                    [NameInMap("intervention")]
                    [Validation(Required=false)]
                    public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention Intervention { get; set; }
                    public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention : TeaModel {
                        /// <summary>
                        /// <para>The label configuration for authorization confirmation. When you add the following labels to a node, you authorize ACK to perform operations in this phase. After completing the operations in this phase, ACK automatically removes the inquiry and confirmation labels for this phase. If you do not add the following labels in time, ACK will not perform the actions in this phase and subsequent phases, and the node may remain in a damaged state.</para>
                        /// </summary>
                        [NameInMap("approved_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel : TeaModel {
                            /// <summary>
                            /// <para>The key value of the label.</para>
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
                        /// <para>The label configuration for authorization inquiry. When this phase is entered, ACK adds the following labels to your node and waits for your authorization to perform the actions in this phase.</para>
                        /// </summary>
                        [NameInMap("inquiring_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel : TeaModel {
                            /// <summary>
                            /// <para>The key value of the label.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>k8s.aliyun.com/incident</para>
                            /// </summary>
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// <para>The value of the taint.</para>
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
            /// <para>The rule type. The value is case-sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom: user-defined rules that support modification and deletion</description></item>
            /// <item><description>builtin: built-in system rules that are read-only and do not support creation, modification, or deletion</description></item>
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

}

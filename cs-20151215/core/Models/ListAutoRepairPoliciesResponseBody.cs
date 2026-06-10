// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAutoRepairPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of auto-repair rules.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAutoRepairPoliciesResponseBodyItems> Items { get; set; }
        public class ListAutoRepairPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the auto-repair rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-xxxxx</para>
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
            /// <para>The IDs of the resources that the auto-repair rule affects.</para>
            /// </summary>
            [NameInMap("resource_ids")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>The resource sub-type that the auto-repair rule affects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ess</para>
            /// </summary>
            [NameInMap("resource_sub_type")]
            [Validation(Required=false)]
            public string ResourceSubType { get; set; }

            /// <summary>
            /// <para>The resource type that the auto-repair rule affects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nodepool</para>
            /// </summary>
            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>A list of auto-repair sub-rules.</para>
            /// </summary>
            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<ListAutoRepairPoliciesResponseBodyItemsRules> Rules { get; set; }
            public class ListAutoRepairPoliciesResponseBodyItemsRules : TeaModel {
                /// <summary>
                /// <para>A list of identified incidents.</para>
                /// </summary>
                [NameInMap("incidents")]
                [Validation(Required=false)]
                public List<ListAutoRepairPoliciesResponseBodyItemsRulesIncidents> Incidents { get; set; }
                public class ListAutoRepairPoliciesResponseBodyItemsRulesIncidents : TeaModel {
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
                    /// <para>The diagnosis type.</para>
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
                    /// <para>The configuration parameters for the procedure step.</para>
                    /// </summary>
                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Config { get; set; }

                    /// <summary>
                    /// <para>The manual intervention settings for this procedure step.</para>
                    /// </summary>
                    [NameInMap("intervention")]
                    [Validation(Required=false)]
                    public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention Intervention { get; set; }
                    public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention : TeaModel {
                        /// <summary>
                        /// <para>The configuration for the approval label. Applying this label to the node authorizes Container Service for Kubernetes (ACK) to execute the action for this repair step. After the step is complete, ACK automatically removes both the inquiry and approval labels. If the approval label is not applied promptly, the repair process will not proceed, and the node may remain in an unhealthy state.</para>
                        /// </summary>
                        [NameInMap("approved_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                        /// <para>Determines whether manual approval is required for the repair step.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The configuration for the authorization inquiry label. When this repair step starts, Container Service for Kubernetes (ACK) applies this label to the node and pauses, awaiting approval before executing the step\&quot;s action.</para>
                        /// </summary>
                        [NameInMap("inquiring_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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
                    /// <para>The name of the procedure step.</para>
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

}

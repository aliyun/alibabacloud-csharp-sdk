// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListAutoRepairPoliciesResponseBody : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAutoRepairPoliciesResponseBodyItems> Items { get; set; }
        public class ListAutoRepairPoliciesResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>r-xxxxx</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("resource_ids")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

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

            [NameInMap("rules")]
            [Validation(Required=false)]
            public List<ListAutoRepairPoliciesResponseBodyItemsRules> Rules { get; set; }
            public class ListAutoRepairPoliciesResponseBodyItemsRules : TeaModel {
                [NameInMap("incidents")]
                [Validation(Required=false)]
                public List<ListAutoRepairPoliciesResponseBodyItemsRulesIncidents> Incidents { get; set; }
                public class ListAutoRepairPoliciesResponseBodyItemsRulesIncidents : TeaModel {
                    [NameInMap("conditions")]
                    [Validation(Required=false)]
                    public List<ListAutoRepairPoliciesResponseBodyItemsRulesIncidentsConditions> Conditions { get; set; }
                    public class ListAutoRepairPoliciesResponseBodyItemsRulesIncidentsConditions : TeaModel {
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
                    public List<ListAutoRepairPoliciesResponseBodyItemsRulesIncidentsEvents> Events { get; set; }
                    public class ListAutoRepairPoliciesResponseBodyItemsRulesIncidentsEvents : TeaModel {
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
                public List<ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedure> RepairProcedure { get; set; }
                public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedure : TeaModel {
                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Config { get; set; }

                    [NameInMap("intervention")]
                    [Validation(Required=false)]
                    public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention Intervention { get; set; }
                    public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureIntervention : TeaModel {
                        [NameInMap("approved_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                        public string Enable { get; set; }

                        [NameInMap("inquiring_label")]
                        [Validation(Required=false)]
                        public ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                        public class ListAutoRepairPoliciesResponseBodyItemsRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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

}

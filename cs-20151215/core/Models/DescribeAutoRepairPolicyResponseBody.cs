// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeAutoRepairPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>r-xxx</para>
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
        public List<DescribeAutoRepairPolicyResponseBodyRules> Rules { get; set; }
        public class DescribeAutoRepairPolicyResponseBodyRules : TeaModel {
            [NameInMap("incidents")]
            [Validation(Required=false)]
            public List<DescribeAutoRepairPolicyResponseBodyRulesIncidents> Incidents { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesIncidents : TeaModel {
                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<DescribeAutoRepairPolicyResponseBodyRulesIncidentsConditions> Conditions { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesIncidentsConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
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
                public List<DescribeAutoRepairPolicyResponseBodyRulesIncidentsEvents> Events { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesIncidentsEvents : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
                    /// </summary>
                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
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
            public List<DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure> RepairProcedure { get; set; }
            public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedure : TeaModel {
                [NameInMap("config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                [NameInMap("intervention")]
                [Validation(Required=false)]
                public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention Intervention { get; set; }
                public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureIntervention : TeaModel {
                    [NameInMap("approved_label")]
                    [Validation(Required=false)]
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel ApprovedLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionApprovedLabel : TeaModel {
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
                    public DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel InquiringLabel { get; set; }
                    public class DescribeAutoRepairPolicyResponseBodyRulesRepairProcedureInterventionInquiringLabel : TeaModel {
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

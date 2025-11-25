// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCdnLinkageRulesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>02FE96D9-C77B-5735-B36D-329E052C8047</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SchedulerRules")]
        [Validation(Required=false)]
        public List<DescribeCdnLinkageRulesResponseBodySchedulerRules> SchedulerRules { get; set; }
        public class DescribeCdnLinkageRulesResponseBodySchedulerRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CdnLinkageEnable")]
            [Validation(Required=false)]
            public int? CdnLinkageEnable { get; set; }

            [NameInMap("CdnLinkageRule")]
            [Validation(Required=false)]
            public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule CdnLinkageRule { get; set; }
            public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("Param")]
                [Validation(Required=false)]
                public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam Param { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam : TeaModel {
                    [NameInMap("ParamData")]
                    [Validation(Required=false)]
                    public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData ParamData { get; set; }
                    public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AccessQps")]
                        [Validation(Required=false)]
                        public long? AccessQps { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("UpstreamQps")]
                        [Validation(Required=false)]
                        public long? UpstreamQps { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cdn</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testDDos</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules> Rules { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>203.107.XX.XX</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public int? ValueType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

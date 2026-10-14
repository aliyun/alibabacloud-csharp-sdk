// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCdnLinkageRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02FE96D9-C77B-5735-B36D-329E052C8047</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The traffic scheduling rules.</para>
        /// </summary>
        [NameInMap("SchedulerRules")]
        [Validation(Required=false)]
        public List<DescribeCdnLinkageRulesResponseBodySchedulerRules> SchedulerRules { get; set; }
        public class DescribeCdnLinkageRulesResponseBodySchedulerRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether CDN interaction is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CdnLinkageEnable")]
            [Validation(Required=false)]
            public int? CdnLinkageEnable { get; set; }

            /// <summary>
            /// <para>The CDN interaction rule.</para>
            /// </summary>
            [NameInMap("CdnLinkageRule")]
            [Validation(Required=false)]
            public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule CdnLinkageRule { get; set; }
            public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRule : TeaModel {
                /// <summary>
                /// <para>The canonical name of the Anti-DDoS instance that is associated with the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The resource for interaction.</para>
                /// </summary>
                [NameInMap("Param")]
                [Validation(Required=false)]
                public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam Param { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParam : TeaModel {
                    /// <summary>
                    /// <para>The interaction conditions.</para>
                    /// </summary>
                    [NameInMap("ParamData")]
                    [Validation(Required=false)]
                    public DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData ParamData { get; set; }
                    public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleParamParamData : TeaModel {
                        /// <summary>
                        /// <para>The QPS threshold that triggers a resource switch.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("AccessQps")]
                        [Validation(Required=false)]
                        public long? AccessQps { get; set; }

                        /// <summary>
                        /// <para>A reserved field. The default value is 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("UpstreamQps")]
                        [Validation(Required=false)]
                        public long? UpstreamQps { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the resource for interaction. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>cdn</b>: Alibaba Cloud CDN</para>
                    /// </description></item>
                    /// <item><description><para><b>dcdn</b>: DCDN</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cdn</para>
                    /// </summary>
                    [NameInMap("ParamType")]
                    [Validation(Required=false)]
                    public string ParamType { get; set; }

                }

                /// <summary>
                /// <para>The name of the traffic scheduling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDDos</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The rule information.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules> Rules { get; set; }
                public class DescribeCdnLinkageRulesResponseBodySchedulerRulesCdnLinkageRuleRules : TeaModel {
                    /// <summary>
                    /// <para>The priority of the rule. Valid values: 0 to 100. A larger value indicates a higher priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                    /// <summary>
                    /// <para>The region ID. The default value is empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The status of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>0</b>: Inactive</para>
                    /// </description></item>
                    /// <item><description><para><b>1</b>: Active</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The format of the resource address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>A</b>: IPv4 address</para>
                    /// </description></item>
                    /// <item><description><para><b>AAAA</b>: IPv6 address</para>
                    /// </description></item>
                    /// <item><description><para><b>CNAME</b>: canonical name</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The resource address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>203.107.XX.XX</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The type of the resource address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>1</b>: Anti-DDoS IP</para>
                    /// </description></item>
                    /// <item><description><para><b>5</b>: Accelerated domain name for CDN interaction</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public int? ValueType { get; set; }

                }

            }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCustomizeRuleCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCustomizeRuleCountResponseBodyData Data { get; set; }
        public class DescribeCustomizeRuleCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>同类聚合规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AggregationRuleNum")]
            [Validation(Required=false)]
            public int? AggregationRuleNum { get; set; }

            /// <summary>
            /// <para>自定义规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CustomizeRuleNum")]
            [Validation(Required=false)]
            public int? CustomizeRuleNum { get; set; }

            /// <summary>
            /// <para>专家规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ExpertRuleNum")]
            [Validation(Required=false)]
            public int? ExpertRuleNum { get; set; }

            /// <summary>
            /// <para>图计算规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("GraphComputingRuleNum")]
            [Validation(Required=false)]
            public int? GraphComputingRuleNum { get; set; }

            /// <summary>
            /// <para>The number of rules that are used to identify high-risk threats.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("HighRuleNum")]
            [Validation(Required=false)]
            public int? HighRuleNum { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("InUseRuleNum")]
            [Validation(Required=false)]
            public int? InUseRuleNum { get; set; }

            /// <summary>
            /// <para>The number of rules that are used to identify low-risk threats.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LowRuleNum")]
            [Validation(Required=false)]
            public int? LowRuleNum { get; set; }

            /// <summary>
            /// <para>The number of rules that are used to identify medium-risk threats.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MediumRuleNum")]
            [Validation(Required=false)]
            public int? MediumRuleNum { get; set; }

            /// <summary>
            /// <para>预定义规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PredefinedRuleNum")]
            [Validation(Required=false)]
            public int? PredefinedRuleNum { get; set; }

            /// <summary>
            /// <para>告警透传规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SingleAlertRuleNum")]
            [Validation(Required=false)]
            public int? SingleAlertRuleNum { get; set; }

            /// <summary>
            /// <para>总规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalRuleNum")]
            [Validation(Required=false)]
            public int? TotalRuleNum { get; set; }

            /// <summary>
            /// <para>不产生事件规则数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnEventRuleNum")]
            [Validation(Required=false)]
            public int? UnEventRuleNum { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

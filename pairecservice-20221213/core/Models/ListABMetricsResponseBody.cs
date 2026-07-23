// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AB metrics.</para>
        /// </summary>
        [NameInMap("ABMetrics")]
        [Validation(Required=false)]
        public List<ListABMetricsResponseBodyABMetrics> ABMetrics { get; set; }
        public class ListABMetricsResponseBodyABMetrics : TeaModel {
            /// <summary>
            /// <para>The AB metric ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ABMetricId")]
            [Validation(Required=false)]
            public string ABMetricId { get; set; }

            /// <summary>
            /// <para>Indicates whether to aggregate data by user.</para>
            /// </summary>
            [NameInMap("AggregationByUser")]
            [Validation(Required=false)]
            public bool? AggregationByUser { get; set; }

            /// <summary>
            /// <para>The metric definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sum(click_cnt)</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The denominator of the derived metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv</para>
            /// </summary>
            [NameInMap("Denominator")]
            [Validation(Required=false)]
            public string Denominator { get; set; }

            /// <summary>
            /// <para>The metric description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv指标</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the metric follows a binomial distribution.</para>
            /// </summary>
            [NameInMap("IsBinomialDistribution")]
            [Validation(Required=false)]
            public bool? IsBinomialDistribution { get; set; }

            /// <summary>
            /// <para>The ID of the left-hand metric in the formula for the derived metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LeftMetricId")]
            [Validation(Required=false)]
            public string LeftMetricId { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether significance calculation is required.</para>
            /// </summary>
            [NameInMap("NeedSignificance")]
            [Validation(Required=false)]
            public bool? NeedSignificance { get; set; }

            /// <summary>
            /// <para>The numerator of the derived metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>click</para>
            /// </summary>
            [NameInMap("Numerator")]
            [Validation(Required=false)]
            public string Numerator { get; set; }

            /// <summary>
            /// <para>The operator used to calculate the derived metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Plus</c>: addition</para>
            /// </description></item>
            /// <item><description><para><c>Minus</c>: subtraction</para>
            /// </description></item>
            /// <item><description><para><c>Multiplication</c>: multiplication</para>
            /// </description></item>
            /// <item><description><para><c>Division</c>: division</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Division</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>Indicates whether the metric is a real-time metric.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The metric is calculated in real time.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The metric is not calculated in real time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Realtime")]
            [Validation(Required=false)]
            public string Realtime { get; set; }

            /// <summary>
            /// <para>The ID of the data source for the data table to which the results are written.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResultResourceId")]
            [Validation(Required=false)]
            public string ResultResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the data table to which the results are written.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResultTableMetaId")]
            [Validation(Required=false)]
            public string ResultTableMetaId { get; set; }

            /// <summary>
            /// <para>The ID of the right-hand metric in the formula for the derived metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RightMetricId")]
            [Validation(Required=false)]
            public string RightMetricId { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>The scene name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>home_feed</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatisticsCycle")]
            [Validation(Required=false)]
            public int? StatisticsCycle { get; set; }

            /// <summary>
            /// <para>The data table ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            /// <summary>
            /// <para>The metric type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Single</c>: a single metric.</para>
            /// </description></item>
            /// <item><description><para><c>Derived</c>: a derived metric.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Single</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of AB metrics returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

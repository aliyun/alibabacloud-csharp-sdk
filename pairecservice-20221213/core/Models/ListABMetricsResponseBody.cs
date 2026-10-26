// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AB test metrics.</para>
        /// </summary>
        [NameInMap("ABMetrics")]
        [Validation(Required=false)]
        public List<ListABMetricsResponseBodyABMetrics> ABMetrics { get; set; }
        public class ListABMetricsResponseBodyABMetrics : TeaModel {
            /// <summary>
            /// <para>The ID of the AB test metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ABMetricId")]
            [Validation(Required=false)]
            public string ABMetricId { get; set; }

            /// <summary>
            /// <para>Specifies whether to calculate significance based on the user dimension. The calculation can be based on users or samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>The denominator used for significance calculation.</para>
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
            /// <para>PV metric</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the current metric conforms to a binomial distribution when the metric type is a derived metric. If yes, the mean and variance of the metric are calculated based on the binomial distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsBinomialDistribution")]
            [Validation(Required=false)]
            public bool? IsBinomialDistribution { get; set; }

            /// <summary>
            /// <para>The ID of the left metric for the derived metric.</para>
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
            /// <para>Specifies whether to calculate significance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedSignificance")]
            [Validation(Required=false)]
            public bool? NeedSignificance { get; set; }

            /// <summary>
            /// <para>The numerator used for significance calculation.</para>
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
            /// <item><description><para>Plus: Addition.</para>
            /// </description></item>
            /// <item><description><para>Minus: Subtraction.</para>
            /// </description></item>
            /// <item><description><para>Multiplication: Multiplication.</para>
            /// </description></item>
            /// <item><description><para>Division: Division.</para>
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
            /// <para>Specifies whether the metric is a real-time metric. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
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
            /// <para>The ID of the data source for the write-back data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResultResourceId")]
            [Validation(Required=false)]
            public string ResultResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the data table to which data is written back.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResultTableMetaId")]
            [Validation(Required=false)]
            public string ResultTableMetaId { get; set; }

            /// <summary>
            /// <para>The ID of the right metric for the derived metric.</para>
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
            /// <para>The ID of the data table.</para>
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
            /// <item><description><para>Single: Single metric.</para>
            /// </description></item>
            /// <item><description><para>Derived: Derived metric.</para>
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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

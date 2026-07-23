// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetABMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether to aggregate metrics by user.</para>
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
        /// <para>The denominator of the derived metric formula.</para>
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
        /// <para>页面访问次数</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the metric follows a binomial distribution. This affects how significance is calculated.</para>
        /// </summary>
        [NameInMap("IsBinomialDistribution")]
        [Validation(Required=false)]
        public bool? IsBinomialDistribution { get; set; }

        /// <summary>
        /// <para>The ID of the left operand metric for a derived metric.</para>
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
        /// <para>Specifies whether significance testing is required for this metric.</para>
        /// </summary>
        [NameInMap("NeedSignificance")]
        [Validation(Required=false)]
        public bool? NeedSignificance { get; set; }

        /// <summary>
        /// <para>The numerator of the derived metric formula.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Numerator")]
        [Validation(Required=false)]
        public string Numerator { get; set; }

        /// <summary>
        /// <para>The operator for the derived metric. Valid values:</para>
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
        /// <para>Specifies whether the metric is real-time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The metric is real-time.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The metric is not real-time.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the data source for the results table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResultResourceId")]
        [Validation(Required=false)]
        public string ResultResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the results table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResultTableMetaId")]
        [Validation(Required=false)]
        public string ResultTableMetaId { get; set; }

        /// <summary>
        /// <para>The ID of the right operand metric for a derived metric.</para>
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
        /// <para>The statistics cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StatisticsCycle")]
        [Validation(Required=false)]
        public int? StatisticsCycle { get; set; }

        /// <summary>
        /// <para>The ID of the source table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TableMetaId")]
        [Validation(Required=false)]
        public string TableMetaId { get; set; }

        /// <summary>
        /// <para>The type of the metric. Valid values:</para>
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

}

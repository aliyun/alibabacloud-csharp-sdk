// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateABMetricRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to aggregate by user dimension when calculating significance. Two aggregation methods are supported: by user and by sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AggregationByUser")]
        [Validation(Required=false)]
        public bool? AggregationByUser { get; set; }

        /// <summary>
        /// <para>The metric definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum(click_cnt)</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The denominator used in significance calculation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv</para>
        /// </summary>
        [NameInMap("Denominator")]
        [Validation(Required=false)]
        public string Denominator { get; set; }

        /// <summary>
        /// <para>The metric description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv 指标</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current metric follows a binomial distribution when the metric type is a derived metric. If set to true, the mean and variance of the metric are calculated based on the binomial distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsBinomialDistribution")]
        [Validation(Required=false)]
        public bool? IsBinomialDistribution { get; set; }

        /// <summary>
        /// <para>The left metric ID of the derived metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LeftMetricId")]
        [Validation(Required=false)]
        public string LeftMetricId { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>True</para>
        /// </summary>
        [NameInMap("NeedSignificance")]
        [Validation(Required=false)]
        public bool? NeedSignificance { get; set; }

        /// <summary>
        /// <para>The numerator used in significance calculation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Numerator")]
        [Validation(Required=false)]
        public string Numerator { get; set; }

        /// <summary>
        /// <para>The operator for derived metric calculation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Plus: addition</para>
        /// </description></item>
        /// <item><description><para>Minus: subtraction</para>
        /// </description></item>
        /// <item><description><para>Multiplication: multiplication</para>
        /// </description></item>
        /// <item><description><para>Division: division</para>
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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Realtime")]
        [Validation(Required=false)]
        public bool? Realtime { get; set; }

        /// <summary>
        /// <para>The ID of the data source for the write-back data table. You can obtain it by calling the ListInstanceResources operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResultResourceId")]
        [Validation(Required=false)]
        public string ResultResourceId { get; set; }

        /// <summary>
        /// <para>The right metric ID of the derived metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RightMetricId")]
        [Validation(Required=false)]
        public string RightMetricId { get; set; }

        /// <summary>
        /// <para>The scene ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

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
        /// <para>The data table ID. You can obtain it by calling the ListTableMetas operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TableMetaId")]
        [Validation(Required=false)]
        public string TableMetaId { get; set; }

        /// <summary>
        /// <para>The metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Single: single metric.</para>
        /// </description></item>
        /// <item><description><para>Derived: derived metric.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

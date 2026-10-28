// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateABMetricRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to aggregate data by user dimension when calculating significance. There are two logic types: by user and by sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AggregationByUser")]
        [Validation(Required=false)]
        public bool? AggregationByUser { get; set; }

        /// <summary>
        /// <para>The definition of the metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum(click_cnt)</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The denominator for significance calculation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv</para>
        /// </summary>
        [NameInMap("Denominator")]
        [Validation(Required=false)]
        public string Denominator { get; set; }

        /// <summary>
        /// <para>The description of the metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PV metric</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can obtain instance ID by calling the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current metric follows a binomial distribution when the metric type is a derived metric. If yes, the mean and variance of the metric are calculated based on the binomial distribution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsBinomialDistribution")]
        [Validation(Required=false)]
        public bool? IsBinomialDistribution { get; set; }

        /// <summary>
        /// <para>The ID of the left metric for the derived metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LeftMetricId")]
        [Validation(Required=false)]
        public string LeftMetricId { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
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
        /// <para>The numerator for significance calculation.</para>
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
        /// <item><description>Plus: addition</description></item>
        /// <item><description>Minus: subtraction</description></item>
        /// <item><description>Multiplication: multiplication</description></item>
        /// <item><description>Division: division</description></item>
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
        /// <item><description>true: yes</description></item>
        /// <item><description>false: no</description></item>
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
        /// <para>The ID of the data source for the data table write-back. You can obtain the ID by calling the ListInstanceResources operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResultResourceId")]
        [Validation(Required=false)]
        public string ResultResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the right metric for the derived metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RightMetricId")]
        [Validation(Required=false)]
        public string RightMetricId { get; set; }

        /// <summary>
        /// <para>The ID of the scene. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation.</para>
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
        /// <para>The ID of the data table. You can obtain the ID by calling the ListTableMetas operation.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description>Single: single metric</description></item>
        /// <item><description>Derived: derived metric</description></item>
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

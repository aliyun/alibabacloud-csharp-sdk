// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateABMetricRequest : TeaModel {
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
        /// <para>pv指标</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID. Call the <a href="https://help.aliyun.com/document_detail/2411819.html">ListInstances</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsBinomialDistribution")]
        [Validation(Required=false)]
        public bool? IsBinomialDistribution { get; set; }

        /// <summary>
        /// <para>The ID of the left metric used to calculate the derived metric.</para>
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

        [NameInMap("NeedSignificance")]
        [Validation(Required=false)]
        public bool? NeedSignificance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Numerator")]
        [Validation(Required=false)]
        public string Numerator { get; set; }

        /// <summary>
        /// <para>The operator used to calculate the derived metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Plus</c>: Addition</para>
        /// </description></item>
        /// <item><description><para><c>Minus</c>: Subtraction</para>
        /// </description></item>
        /// <item><description><para><c>Multiplication</c>: Multiplication</para>
        /// </description></item>
        /// <item><description><para><c>Division</c>: Division</para>
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
        /// <item><description><para><c>true</c>: The metric is real-time.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The metric is not real-time.</para>
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
        /// <para>The data source ID to which the results are written back. Call the ListInstanceResources operation to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ResultResourceId")]
        [Validation(Required=false)]
        public string ResultResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the right metric used to calculate the derived metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RightMetricId")]
        [Validation(Required=false)]
        public string RightMetricId { get; set; }

        /// <summary>
        /// <para>The scene ID. Call the <a href="https://help.aliyun.com/document_detail/2402581.html">ListScenes</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

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
        /// <para>The data table ID. Call the ListTableMetas operation to obtain this ID.</para>
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
        /// <item><description><para><c>Single</c>: A single metric.</para>
        /// </description></item>
        /// <item><description><para><c>Derived</c>: A derived metric.</para>
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

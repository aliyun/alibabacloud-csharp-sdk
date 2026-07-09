// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metric configuration information of the resources.</para>
        /// </summary>
        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<DescribeMetricMetaListResponseBodyResources> Resources { get; set; }
        public class DescribeMetricMetaListResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS CPU Utilization</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The dimension description.</para>
            /// </summary>
            [NameInMap("dimensionDescription")]
            [Validation(Required=false)]
            public List<DescribeMetricMetaListResponseBodyResourcesDimensionDescription> DimensionDescription { get; set; }
            public class DescribeMetricMetaListResponseBodyResourcesDimensionDescription : TeaModel {
                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_id</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The resource filtering dimensions of CloudMonitor Basic.</para>
            /// </summary>
            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public List<string> Dimensions { get; set; }

            /// <summary>
            /// <para>The CloudMonitor labels. This parameter is returned only when metaFormat is set to CMS.</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The metadata source. CMS indicates CloudMonitor Basic monitoring metrics. PROM_BASIC indicates Prometheus CloudMonitor basic monitoring metrics.</para>
            /// <para>Sample value:
            /// CMS
            /// Valid values:
            /// CMS
            /// PROM_BASIC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROM_BASIC</para>
            /// </summary>
            [NameInMap("metaFormat")]
            [Validation(Required=false)]
            public string MetaFormat { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPUUtilization</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("periods")]
            [Validation(Required=false)]
            public string Periods { get; set; }

            /// <summary>
            /// <para>The statistical method of the metric. Example values:</para>
            /// <list type="bullet">
            /// <item><description>Maximum: the maximum value.</description></item>
            /// <item><description>Minimum: the minimum value.</description></item>
            /// <item><description>Average: the average value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Maximum</para>
            /// </summary>
            [NameInMap("statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The metric type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Gauge</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>%</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6370</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

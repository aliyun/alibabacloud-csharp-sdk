// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeMetricMetaListRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("aliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance theory</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>Filters resources by label. The existing labels are described as follows:</para>
        /// <list type="bullet">
        /// <item><description>metricCategory: the category description of the metric.</description></item>
        /// <item><description>alertEnable: specifies whether alerting is required.</description></item>
        /// <item><description>alertUnit: the recommended alert unit.</description></item>
        /// <item><description>unitFactor: the unit conversion factor.</description></item>
        /// <item><description>minAlertPeriod: the minimum alert period.</description></item>
        /// <item><description>productCategory: the product category.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<DescribeMetricMetaListRequestLabels> Labels { get; set; }
        public class DescribeMetricMetaListRequestLabels : TeaModel {
            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>productCategory</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The metadata source. Valid values: CMS for CloudMonitor Basic monitoring metrics, and PROM_BASIC for Prometheus CloudMonitor basic monitoring metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CMS</para>
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
        /// <para>The namespace used to distinguish products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

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
        /// <para>The number of entries per page. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

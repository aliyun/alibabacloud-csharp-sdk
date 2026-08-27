// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeMetricMetaListShrinkRequest : TeaModel {
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
        /// <para>The category.</para>
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
        /// <para>Filters resources by label. The following labels are available:</para>
        /// <list type="bullet">
        /// <item><description>metricCategory: the metric category description.</description></item>
        /// <item><description>alertEnable: specifies whether alerting is required.</description></item>
        /// <item><description>alertUnit: the recommended alert unit.</description></item>
        /// <item><description>unitFactor: the unit conversion factor.</description></item>
        /// <item><description>minAlertPeriod: the minimum alert period.</description></item>
        /// <item><description>productCategory: the product type category.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>The metadata source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CMS: CloudMonitor Basic monitoring metrics.</description></item>
        /// <item><description>PROM_BASIC: Prometheus CloudMonitor Basic monitoring metrics.</description></item>
        /// </list>
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
        /// <para>The namespace, which is used to distinguish between services.</para>
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

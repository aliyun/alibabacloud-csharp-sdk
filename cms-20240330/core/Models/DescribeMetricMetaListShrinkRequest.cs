// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeMetricMetaListShrinkRequest : TeaModel {
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The labels used to filter resources. The following labels are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><c>metricCategory</c>: The metric category.</para>
        /// </description></item>
        /// <item><description><para><c>alertEnable</c>: Indicates whether to enable alerts.</para>
        /// </description></item>
        /// <item><description><para><c>alertUnit</c>: The recommended unit for alerts.</para>
        /// </description></item>
        /// <item><description><para><c>unitFactor</c>: The unit conversion factor.</para>
        /// </description></item>
        /// <item><description><para><c>minAlertPeriod</c>: The minimum alert period.</para>
        /// </description></item>
        /// <item><description><para><c>productCategory</c>: The product category.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>The source of the metadata. Valid values: <c>CMS</c> for CloudMonitor metrics and <c>PROM_BASIC</c> for basic Prometheus metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CMS</para>
        /// </summary>
        [NameInMap("metaFormat")]
        [Validation(Required=false)]
        public string MetaFormat { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPUUtilization</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <c>2000</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

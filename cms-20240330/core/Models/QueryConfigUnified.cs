// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check for data completeness. A value of <c>true</c> enables the check.</para>
        /// </summary>
        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        /// <summary>
        /// <para>Specifies the domain of the entity, such as <c>acs</c> for Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>A list of entity fields to include in the response.</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<UmodelEntityField> EntityFields { get; set; }

        /// <summary>
        /// <para>A list of filters for selecting specific entities.</para>
        /// </summary>
        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<UmodelEntityFilter> EntityFilters { get; set; }

        /// <summary>
        /// <para>Specifies the type of the entity, such as <c>EcsInstance</c>.</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Specifies the expression to post-process query results.</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>A list of Application Performance Monitoring (APM) filter configurations.</para>
        /// </summary>
        [NameInMap("filterList")]
        [Validation(Required=false)]
        public List<ApmFilterConfig> FilterList { get; set; }

        /// <summary>
        /// <para>A list of filters that match labels.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<UmodelLabelFilter> LabelFilters { get; set; }

        /// <summary>
        /// <para>A list of APM measure configurations.</para>
        /// </summary>
        [NameInMap("measureList")]
        [Validation(Required=false)]
        public List<ApmMeasureConfig> MeasureList { get; set; }

        /// <summary>
        /// <para>Specifies the name of the metric to query.</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>Specifies the metric set that contains the metric.</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>Specifies the query string in Prometheus Query Language (PromQL).</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>A list of service IDs to query.</para>
        /// </summary>
        [NameInMap("serviceIdList")]
        [Validation(Required=false)]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

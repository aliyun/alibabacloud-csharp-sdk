// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        /// <summary>
        /// <para>是否启用数据完整性检查</para>
        /// </summary>
        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        /// <summary>
        /// <para>实体所属域</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>需要附带返回的实体字段</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<UmodelEntityField> EntityFields { get; set; }

        /// <summary>
        /// <para>实体过滤列表</para>
        /// </summary>
        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<UmodelEntityFilter> EntityFilters { get; set; }

        /// <summary>
        /// <para>实体类型</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>APM 过滤条件列表</para>
        /// </summary>
        [NameInMap("filterList")]
        [Validation(Required=false)]
        public List<ApmFilterConfig> FilterList { get; set; }

        /// <summary>
        /// <para>标签过滤条件</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<UmodelLabelFilter> LabelFilters { get; set; }

        /// <summary>
        /// <para>APM 度量配置列表</para>
        /// </summary>
        [NameInMap("measureList")]
        [Validation(Required=false)]
        public List<ApmMeasureConfig> MeasureList { get; set; }

        /// <summary>
        /// <para>指标名称（type=UMODEL_METRICSET_QUERY）</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>指标集名称（type=UMODEL_METRICSET_QUERY）</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>Prometheus 查询语句（type=PROMETHEUS_SINGLE_QUERY）</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>服务 ID 列表（type=APM_MULTI_QUERY）</para>
        /// </summary>
        [NameInMap("serviceIdList")]
        [Validation(Required=false)]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// <para>查询类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

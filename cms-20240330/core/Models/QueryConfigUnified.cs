// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<UmodelEntityField> EntityFields { get; set; }

        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<UmodelEntityFilter> EntityFilters { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("filterList")]
        [Validation(Required=false)]
        public List<ApmFilterConfig> FilterList { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<UmodelLabelFilter> LabelFilters { get; set; }

        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        [NameInMap("measureList")]
        [Validation(Required=false)]
        public List<ApmMeasureConfig> MeasureList { get; set; }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        [Obsolete]
        public string PromQl { get; set; }

        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<MetricSetNamedQueryEntry> Queries { get; set; }

        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("serviceIdList")]
        [Validation(Required=false)]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}

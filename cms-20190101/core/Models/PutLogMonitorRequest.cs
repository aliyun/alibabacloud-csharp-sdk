// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutLogMonitorRequest : TeaModel {
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("MetricExpress")]
        [Validation(Required=false)]
        public string MetricExpress { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ValueFilterRelation")]
        [Validation(Required=false)]
        public string ValueFilterRelation { get; set; }

        [NameInMap("Tumblingwindows")]
        [Validation(Required=false)]
        public string Tumblingwindows { get; set; }

        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("Aggregates")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestAggregates> Aggregates { get; set; }
        public class PutLogMonitorRequestAggregates : TeaModel {
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

        }

        [NameInMap("Groupbys")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestGroupbys> Groupbys { get; set; }
        public class PutLogMonitorRequestGroupbys : TeaModel {
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

        }

        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestValueFilter> ValueFilter { get; set; }
        public class PutLogMonitorRequestValueFilter : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

    }

}

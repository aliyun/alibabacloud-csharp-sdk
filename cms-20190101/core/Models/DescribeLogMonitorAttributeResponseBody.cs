// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeLogMonitorAttributeResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LogMonitor")]
        [Validation(Required=false)]
        public DescribeLogMonitorAttributeResponseBodyLogMonitor LogMonitor { get; set; }
        public class DescribeLogMonitorAttributeResponseBodyLogMonitor : TeaModel {
            [NameInMap("ValueFilterRelation")]
            [Validation(Required=false)]
            public string ValueFilterRelation { get; set; }
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }
            [NameInMap("ValueFilter")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter> ValueFilter { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorValueFilter : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
                public string Operator { get; set; }
            }
            [NameInMap("SlsRegionId")]
            [Validation(Required=false)]
            public string SlsRegionId { get; set; }
            [NameInMap("SlsLogstore")]
            [Validation(Required=false)]
            public string SlsLogstore { get; set; }
            [NameInMap("Aggregates")]
            [Validation(Required=false)]
            public List<DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates> Aggregates { get; set; }
            public class DescribeLogMonitorAttributeResponseBodyLogMonitorAggregates : TeaModel {
                public string Max { get; set; }
                public string FieldName { get; set; }
                public string Min { get; set; }
                public string Function { get; set; }
                public string Alias { get; set; }
            }
            [NameInMap("Tumblingwindows")]
            [Validation(Required=false)]
            public List<string> Tumblingwindows { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
            [NameInMap("Groupbys")]
            [Validation(Required=false)]
            public List<string> Groupbys { get; set; }
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }
            [NameInMap("MetricExpress")]
            [Validation(Required=false)]
            public string MetricExpress { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("SlsProject")]
            [Validation(Required=false)]
            public string SlsProject { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

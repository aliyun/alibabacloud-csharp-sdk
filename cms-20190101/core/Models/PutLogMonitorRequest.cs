// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutLogMonitorRequest : TeaModel {
        [NameInMap("Aggregates")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestAggregates> Aggregates { get; set; }
        public class PutLogMonitorRequestAggregates : TeaModel {
            /// <summary>
            /// The name of the Log Service project.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The alias of the aggregate function. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// The ID of the log monitoring metric.
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

        }

        /// <summary>
        /// The ID of the log monitoring metric.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("Groupbys")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestGroupbys> Groupbys { get; set; }
        public class PutLogMonitorRequestGroupbys : TeaModel {
            /// <summary>
            /// The function that is used to aggregate the monitoring data of logs within an aggregation period. Valid values of N: 1 to 10. Valid values:
            /// 
            /// *   count: counts the number.
            /// *   sum: calculates the total value.
            /// *   avg: calculates the average value.
            /// *   max: selects the maximum value.
            /// *   min: selects the minimum value.
            /// *   countps: calculates the counted number of the specified field divided by the total number of seconds of the aggregation period.
            /// *   sumps: calculates the total value of the specified field divided by the total number of seconds of the aggregation period.
            /// *   distinct: counts the number of logs where the specified field appears within the aggregation period.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        /// <summary>
        /// The extended field. The extended field allows you to perform basic operations on the aggregation results.
        /// 
        /// For example, if you have calculated TotalNumber and 5XXNumber by aggregating the data. TotalNumber indicates the total number of HTTP requests, and 5XXNumber indicates the number of HTTP requests whose status code is greater than 499. You can calculate the server error rate by adding the following formula to the extended field: 5XXNumber/TotalNumber\*100.
        /// 
        /// JSON format: {"extend":{"errorPercent":"5XXNumber/TotalNumber\*100"}}. Description:
        /// 
        /// *   extend: required.
        /// *   errorPercent: the alias of the field generated in the calculation result. You can specify the alias as needed.
        /// *   5XXNumber/TotalNumber\*100: the calculation expression.
        /// </summary>
        [NameInMap("MetricExpress")]
        [Validation(Required=false)]
        public string MetricExpress { get; set; }

        /// <summary>
        /// The returned message.
        /// 
        /// *   If the call is successful, the value `successful` is returned.
        /// *   If the call fails, an error message is returned. Example: `alias of aggreate must be set value.`
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the metric. For more information about the metrics for cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

        /// <summary>
        /// The name of the field that is specified as the dimension. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to PutLogMonitor.
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// The logical operator that is used between log filter conditions. Valid values:
        /// 
        /// *   and
        /// *   or
        /// 
        /// >  The ValueFilterRelation and `ValueFilter.N.Key` parameters must be used in pair.
        /// </summary>
        [NameInMap("Tumblingwindows")]
        [Validation(Required=false)]
        public string Tumblingwindows { get; set; }

        /// <summary>
        /// The region in which the Log Service project resides.
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestValueFilter> ValueFilter { get; set; }
        public class PutLogMonitorRequestValueFilter : TeaModel {
            /// <summary>
            /// The method that is used to match the field value. Valid values of N: 1 to 10. Valid values:
            /// 
            /// *   `contain`: contains
            /// *   `notContain`: does not contain
            /// *   `>`: be greater than
            /// *   `<`: be less than
            /// *   `>=`: be greater than or equal to
            /// *   `<=`: be less than or equal to
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The size of the tumbling window for calculation. Unit: seconds. CloudMonitor performs aggregation for each tumbling window.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The alias of the dimension based on which the data is grouped. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The field value to be matched in the filter condition. Valid values of N: 1 to 10.
        /// </summary>
        [NameInMap("ValueFilterRelation")]
        [Validation(Required=false)]
        public string ValueFilterRelation { get; set; }

    }

}

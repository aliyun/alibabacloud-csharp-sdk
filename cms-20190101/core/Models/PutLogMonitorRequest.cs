// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutLogMonitorRequest : TeaModel {
        /// <summary>
        /// The aggregation logic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Aggregates")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestAggregates> Aggregates { get; set; }
        public class PutLogMonitorRequestAggregates : TeaModel {
            /// <summary>
            /// The alias of the aggregate function. Valid values of N: 1 to 10.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The name of the field to be aggregated. Valid values of N: 1 to 10.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// The function that is used to aggregate log data within a statistical period. Valid values of N: 1 to 10. Valid values:
            /// 
            /// *   count: counts the number.
            /// *   sum: calculates the total value.
            /// *   avg: calculates the average value.
            /// *   max: calculates the maximum value.
            /// *   min: calculates the minimum value.
            /// *   countps: calculates the number of values of the specified field divided by the total number of seconds within a statistical period.
            /// *   sumps: calculates the sum of the values of the specified field divided by the total number of seconds within a statistical period.
            /// *   distinct: calculates the number of unique values of the specified field within a statistical period.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

        }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The dimension based on which the data is grouped. This parameter is equivalent to the GROUP BY clause in SQL statements. If no dimension is specified, all data is aggregated based on the aggregate function.
        /// </summary>
        [NameInMap("Groupbys")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestGroupbys> Groupbys { get; set; }
        public class PutLogMonitorRequestGroupbys : TeaModel {
            /// <summary>
            /// The alias of the dimension based on which the data is grouped. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The name of the field that is specified as the dimension. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

        /// <summary>
        /// The ID of the log monitoring metric.
        /// </summary>
        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        /// <summary>
        /// The extended field. The extended field allows you to perform basic operations on the aggregation results.
        /// 
        /// For example, you have calculated TotalNumber and 5XXNumber by aggregating the data. TotalNumber indicates the total number of HTTP requests, and 5XXNumber indicates the number of HTTP requests whose status code is greater than 499. You can calculate the server error rate by adding the following formula to the extended field: 5XXNumber/TotalNumber\\*100.
        /// 
        /// JSON format: {"extend":{"errorPercent":"5XXNumber/TotalNumber\\*100"}}. Description:
        /// 
        /// *   extend: required.
        /// *   errorPercent: the alias of the field generated in the calculation result. You can specify the alias as needed.
        /// *   5XXNumber/TotalNumber\\*100: the calculation expression.
        /// </summary>
        [NameInMap("MetricExpress")]
        [Validation(Required=false)]
        public string MetricExpress { get; set; }

        /// <summary>
        /// The metric name. For more information about the metrics for cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the Simple Log Service Logstore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SlsLogstore")]
        [Validation(Required=false)]
        public string SlsLogstore { get; set; }

        /// <summary>
        /// The name of the Simple Log Service project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SlsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// The region in which the Simple Log Service project resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// The size of the tumbling window for calculation. Unit: seconds. CloudMonitor performs aggregation for each tumbling window.
        /// </summary>
        [NameInMap("Tumblingwindows")]
        [Validation(Required=false)]
        public string Tumblingwindows { get; set; }

        /// <summary>
        /// The unit.
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// The condition that is used to filter logs. The ValueFilter and ValueFilterRelation parameters are used in pair. The filter condition is equivalent to the WHERE clause in SQL statements. If no filter condition is specified, all logs are processed. For example, logs contain the Level and Error fields. If you need to calculate the number of times that logs of the Error level appear every minute, you can set the filter condition to Level=Error and count the number of logs that meet this condition.
        /// </summary>
        [NameInMap("ValueFilter")]
        [Validation(Required=false)]
        public List<PutLogMonitorRequestValueFilter> ValueFilter { get; set; }
        public class PutLogMonitorRequestValueFilter : TeaModel {
            /// <summary>
            /// The name of the log field that is used for matching in the filter condition. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The method that is used to match the field value. Valid values of N: 1 to 10. Valid values:
            /// 
            /// *   `contain`: contains
            /// *   `notContain`: does not contain
            /// *   `>`: greater than
            /// *   `<`: less than
            /// *   `>=`: greater than or equal to
            /// *   `<=`: less than or equal to
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The field value to be matched in the filter condition. Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The logical operator that is used between log filter conditions. Valid values:
        /// 
        /// *   and
        /// *   or
        /// 
        /// >  The ValueFilterRelation and `ValueFilter.N.Key` parameters must be used in pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ValueFilterRelation")]
        [Validation(Required=false)]
        public string ValueFilterRelation { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters in the request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public EventCenterQueryEventsRequestBody Body { get; set; }
        public class EventCenterQueryEventsRequestBody : TeaModel {
            /// <summary>
            /// <para>The query parameters.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public EventCenterQueryEventsRequestBodyParameters Parameters { get; set; }
            public class EventCenterQueryEventsRequestBodyParameters : TeaModel {
                /// <summary>
                /// <para>Specifies whether to further split the data set based on the column name.</para>
                /// </summary>
                [NameInMap("Breakdowns")]
                [Validation(Required=false)]
                public List<string> Breakdowns { get; set; }

                /// <summary>
                /// <para>The operator that is used to calculate the specified column.</para>
                /// </summary>
                [NameInMap("Calculations")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersCalculations> Calculations { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersCalculations : TeaModel {
                    /// <summary>
                    /// <para>The column name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source</para>
                    /// </summary>
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    /// <summary>
                    /// <para>The operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>COUNT_DISTINCT</para>
                    /// </summary>
                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                }

                /// <summary>
                /// <para>The timestamp that specifies the end of the time range to query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687861201814</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The logic used to filter the combination of conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("FilterCombination")]
                [Validation(Required=false)]
                public string FilterCombination { get; set; }

                /// <summary>
                /// <para>The filter conditions.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersFilters> Filters { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersFilters : TeaModel {
                    /// <summary>
                    /// <para>The column name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source</para>
                    /// </summary>
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("NestedFilterCombination")]
                    [Validation(Required=false)]
                    public string NestedFilterCombination { get; set; }

                    [NameInMap("NestedFilters")]
                    [Validation(Required=false)]
                    public List<EventCenterQueryEventsRequestBodyParametersFiltersNestedFilters> NestedFilters { get; set; }
                    public class EventCenterQueryEventsRequestBodyParametersFiltersNestedFilters : TeaModel {
                        [NameInMap("Column")]
                        [Validation(Required=false)]
                        public string Column { get; set; }

                        [NameInMap("Op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        [NameInMap("Values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

                    /// <summary>
                    /// <para>The operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>=</para>
                    /// </summary>
                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                    /// <summary>
                    /// <para>The values that are used together with the operator.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The minimum time unit for querying time series data. Minimum value: 1. Unit: seconds. The value of this parameter is a recommended value. The actual value returned shall prevail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public int? Granularity { get; set; }

                /// <summary>
                /// <para>The maximum number of events to query. Valid values: 1 to 10000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <para>The offset of the start position for this query. The offset starts from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The order of the query results. This parameter is valid only if you set QueryType to table.</para>
                /// </summary>
                [NameInMap("Orders")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersOrders> Orders { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersOrders : TeaModel {
                    /// <summary>
                    /// <para>The column name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source</para>
                    /// </summary>
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to sort the query results in descending order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public bool? Desc { get; set; }

                    /// <summary>
                    /// <para>The operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVG</para>
                    /// </summary>
                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                }

                /// <summary>
                /// <para>The timestamp that specifies the beginning of the time range to query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687860901814</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The time range during which events are queried. Unit: milliseconds. Minimum value: 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("TimeRange")]
                [Validation(Required=false)]
                public long? TimeRange { get; set; }

            }

            /// <summary>
            /// <para>The query type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>timeseries</b>: queries time series data.</description></item>
            /// <item><description><b>table</b>: queries table data.</description></item>
            /// <item><description><b>timeseries_and_table</b>: queries time series data and table data at the same time.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeseries_and_table</para>
            /// </summary>
            [NameInMap("QueryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            /// <summary>
            /// <para>The schema ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs:GeneralSchema</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

        }

        /// <summary>
        /// <para>The name of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("BusName")]
        [Validation(Required=false)]
        public string BusName { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 0 to 10000. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>用来标记当前开始读取的位置。置空表示从头开始。</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

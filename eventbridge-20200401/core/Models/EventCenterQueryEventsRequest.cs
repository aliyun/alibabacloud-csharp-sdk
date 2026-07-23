// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
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
                /// <para>An array of column names to use as dimensions for splitting the dataset.</para>
                /// </summary>
                [NameInMap("Breakdowns")]
                [Validation(Required=false)]
                public List<string> Breakdowns { get; set; }

                /// <summary>
                /// <para>The calculations to perform on specified columns.</para>
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
                /// <para>The end timestamp for the event query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687861201814</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The logical operator for combining filter conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AND</para>
                /// </summary>
                [NameInMap("FilterCombination")]
                [Validation(Required=false)]
                public string FilterCombination { get; set; }

                /// <summary>
                /// <para>A list of filter conditions.</para>
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
                    /// <para>The logical operator for combining nested filters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AND</para>
                    /// </summary>
                    [NameInMap("NestedFilterCombination")]
                    [Validation(Required=false)]
                    public string NestedFilterCombination { get; set; }

                    /// <summary>
                    /// <para>A list of nested filters.</para>
                    /// </summary>
                    [NameInMap("NestedFilters")]
                    [Validation(Required=false)]
                    public List<EventCenterQueryEventsRequestBodyParametersFiltersNestedFilters> NestedFilters { get; set; }
                    public class EventCenterQueryEventsRequestBodyParametersFiltersNestedFilters : TeaModel {
                        /// <summary>
                        /// <para>The column name.</para>
                        /// </summary>
                        [NameInMap("Column")]
                        [Validation(Required=false)]
                        public string Column { get; set; }

                        /// <summary>
                        /// <para>The operator.</para>
                        /// </summary>
                        [NameInMap("Op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>A list of values to use with the operator.</para>
                        /// </summary>
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
                    /// <para>The values to use with the operator.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The time granularity, in seconds, for querying time series data. The minimum value is 1. This is a suggested value; the actual granularity is returned in the response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public int? Granularity { get; set; }

                /// <summary>
                /// <para>The maximum number of events to query. Valid values: 1 to 10,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                /// <summary>
                /// <para>The starting position of the query. The count starts from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The sort order for the query results. This parameter applies only when QueryType is set to table.</para>
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
                    /// <para>Specifies whether to sort the results in descending order.</para>
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
                /// <para>The start timestamp for the event query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1687860901814</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The time range. Unit: milliseconds. The minimum value is 1,000.</para>
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
            /// <item><description><para><b>timeseries</b>: queries time series data.</para>
            /// </description></item>
            /// <item><description><para><b>table</b>: queries table data.</para>
            /// </description></item>
            /// <item><description><para><b>timeseries_and_table</b>: queries both time series data and table data.</para>
            /// </description></item>
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
        /// <para>The maximum number of results to return. Valid values: 0 to 10,000. The default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

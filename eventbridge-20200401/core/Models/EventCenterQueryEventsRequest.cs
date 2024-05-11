// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public EventCenterQueryEventsRequestBody Body { get; set; }
        public class EventCenterQueryEventsRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public EventCenterQueryEventsRequestBodyParameters Parameters { get; set; }
            public class EventCenterQueryEventsRequestBodyParameters : TeaModel {
                [NameInMap("Breakdowns")]
                [Validation(Required=false)]
                public List<string> Breakdowns { get; set; }

                [NameInMap("Calculations")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersCalculations> Calculations { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersCalculations : TeaModel {
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public int? EndTime { get; set; }

                [NameInMap("FilterCombination")]
                [Validation(Required=false)]
                public string FilterCombination { get; set; }

                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersFilters> Filters { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersFilters : TeaModel {
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

                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public int? Granularity { get; set; }

                [NameInMap("Limit")]
                [Validation(Required=false)]
                public int? Limit { get; set; }

                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                [NameInMap("Orders")]
                [Validation(Required=false)]
                public List<EventCenterQueryEventsRequestBodyParametersOrders> Orders { get; set; }
                public class EventCenterQueryEventsRequestBodyParametersOrders : TeaModel {
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public bool? Desc { get; set; }

                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public int? StartTime { get; set; }

                [NameInMap("TimeRange")]
                [Validation(Required=false)]
                public int? TimeRange { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("QueryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            /// <summary>
            /// Schema ID。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

        }

        [NameInMap("BusName")]
        [Validation(Required=false)]
        public string BusName { get; set; }

        /// <summary>
        /// 本次读取的最大数据量，默认值为100。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 用来标记当前开始读取的位置。置空表示从头开始。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

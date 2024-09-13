// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryAllSwimmingLaneResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAllSwimmingLaneResponseBodyData> Data { get; set; }
        public class QueryAllSwimmingLaneResponseBodyData : TeaModel {
            [NameInMap("EntryRules")]
            [Validation(Required=false)]
            public List<QueryAllSwimmingLaneResponseBodyDataEntryRules> EntryRules { get; set; }
            public class QueryAllSwimmingLaneResponseBodyDataEntryRules : TeaModel {
                [NameInMap("condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<string> Paths { get; set; }

                [NameInMap("restItems")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataEntryRulesRestItems> RestItems { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataEntryRulesRestItems : TeaModel {
                    [NameInMap("cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("datum")]
                    [Validation(Required=false)]
                    public string Datum { get; set; }

                    [NameInMap("divisor")]
                    [Validation(Required=false)]
                    public int? Divisor { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    [NameInMap("operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("remainder")]
                    [Validation(Required=false)]
                    public int? Remainder { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("GatewaySwimmingLaneRoute")]
            [Validation(Required=false)]
            public QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRoute GatewaySwimmingLaneRoute { get; set; }
            public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRoute : TeaModel {
                [NameInMap("CanaryModel")]
                [Validation(Required=false)]
                public int? CanaryModel { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteConditions> Conditions { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteConditions : TeaModel {
                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("NameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public int? Percentage { get; set; }

                [NameInMap("RouteIdList")]
                [Validation(Required=false)]
                public List<long?> RouteIdList { get; set; }

                [NameInMap("RouteIndependentPercentageEnable")]
                [Validation(Required=false)]
                public string RouteIndependentPercentageEnable { get; set; }

                [NameInMap("RouteIndependentPercentageList")]
                [Validation(Required=false)]
                public List<QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteRouteIndependentPercentageList> RouteIndependentPercentageList { get; set; }
                public class QueryAllSwimmingLaneResponseBodyDataGatewaySwimmingLaneRouteRouteIndependentPercentageList : TeaModel {
                    [NameInMap("Percentage")]
                    [Validation(Required=false)]
                    public string Percentage { get; set; }

                    [NameInMap("RouteId")]
                    [Validation(Required=false)]
                    public string RouteId { get; set; }

                }

            }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("MessageQueueFilterSide")]
            [Validation(Required=false)]
            public string MessageQueueFilterSide { get; set; }

            [NameInMap("MessageQueueGrayEnable")]
            [Validation(Required=false)]
            public bool? MessageQueueGrayEnable { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("PathIndependentPercentageEnable")]
            [Validation(Required=false)]
            public bool? PathIndependentPercentageEnable { get; set; }

            [NameInMap("RecordCanaryDetail")]
            [Validation(Required=false)]
            public bool? RecordCanaryDetail { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("enableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

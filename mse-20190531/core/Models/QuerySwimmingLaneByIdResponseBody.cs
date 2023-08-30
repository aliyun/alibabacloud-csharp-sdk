// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QuerySwimmingLaneByIdResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySwimmingLaneByIdResponseBodyData Data { get; set; }
        public class QuerySwimmingLaneByIdResponseBodyData : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("enableRules")]
            [Validation(Required=false)]
            public bool? EnableRules { get; set; }

            [NameInMap("entryRule")]
            [Validation(Required=false)]
            public string EntryRule { get; set; }

            [NameInMap("entryRules")]
            [Validation(Required=false)]
            public List<QuerySwimmingLaneByIdResponseBodyDataEntryRules> EntryRules { get; set; }
            public class QuerySwimmingLaneByIdResponseBodyDataEntryRules : TeaModel {
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
                public List<QuerySwimmingLaneByIdResponseBodyDataEntryRulesRestItems> RestItems { get; set; }
                public class QuerySwimmingLaneByIdResponseBodyDataEntryRulesRestItems : TeaModel {
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

            [NameInMap("gatewaySwimmingLaneRouteJson")]
            [Validation(Required=false)]
            public string GatewaySwimmingLaneRouteJson { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineConfigsResponseBodyData Data { get; set; }
        public class ListBaselineConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// The list of baselines.
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselineConfigsResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselineConfigsResponseBodyDataBaselines : TeaModel {
                /// <summary>
                /// The baseline ID.
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// The name of the baseline.
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                /// <summary>
                /// The type of the baseline. Valid values: DAILY and HOURLY.
                /// </summary>
                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                /// <summary>
                /// The hour in the alerting time of the day-level baseline. Valid values: [0, 47].
                /// </summary>
                [NameInMap("ExpHour")]
                [Validation(Required=false)]
                public int? ExpHour { get; set; }

                /// <summary>
                /// The minute in the alerting time of the day-level baseline. Valid values: [0, 59].
                /// </summary>
                [NameInMap("ExpMinu")]
                [Validation(Required=false)]
                public int? ExpMinu { get; set; }

                /// <summary>
                /// The alerting time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
                /// </summary>
                [NameInMap("HourExpDetail")]
                [Validation(Required=false)]
                public string HourExpDetail { get; set; }

                /// <summary>
                /// The committed completion time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
                /// </summary>
                [NameInMap("HourSlaDetail")]
                [Validation(Required=false)]
                public string HourSlaDetail { get; set; }

                /// <summary>
                /// Indicates whether the baseline is a default baseline of the workspace. Valid values: true and false.
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs can be specified. The IDs are separated by commas (,).
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The priority of the baseline. Valid values: {1,3,5,7,8}.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The ID of the workspace to which the baseline belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The hour in the committed completion time of the day-level baseline. Valid values: [0, 47].
                /// </summary>
                [NameInMap("SlaHour")]
                [Validation(Required=false)]
                public int? SlaHour { get; set; }

                /// <summary>
                /// The minute in the alerting time of the day-level baseline. Valid values: [0, 59].
                /// </summary>
                [NameInMap("SlaMinu")]
                [Validation(Required=false)]
                public int? SlaMinu { get; set; }

                /// <summary>
                /// Indicates whether the baseline is enabled. Valid values: true and false.
                /// </summary>
                [NameInMap("UseFlag")]
                [Validation(Required=false)]
                public bool? UseFlag { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of baselines returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

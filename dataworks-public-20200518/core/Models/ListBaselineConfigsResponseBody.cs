// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineConfigsResponseBody : TeaModel {
        /// <summary>
        /// The return results of the request.
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
                /// The ID of the baseline.
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
                /// The type of the baseline. Valid values: DAILY and HOURLY. A value of DAILY indicates that the baseline is a day-level baseline. A value of HOURLY indicates that the baseline is an hour-level baseline.
                /// </summary>
                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                /// <summary>
                /// The hour in the alert time of the day-level baseline. Valid values: 0 to 47.
                /// </summary>
                [NameInMap("ExpHour")]
                [Validation(Required=false)]
                public int? ExpHour { get; set; }

                /// <summary>
                /// The minute in the alert time of the day-level baseline. Valid values: 0 to 59.
                /// </summary>
                [NameInMap("ExpMinu")]
                [Validation(Required=false)]
                public int? ExpMinu { get; set; }

                /// <summary>
                /// The alert time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.
                /// </summary>
                [NameInMap("HourExpDetail")]
                [Validation(Required=false)]
                public string HourExpDetail { get; set; }

                /// <summary>
                /// The committed time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: 0 to 47. Valid values of mm: 0 to 59.
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
                /// The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs are separated by commas (,).
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The priority of the baseline. Valid values: 1, 3, 5, 7, and 8.
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
                /// The hour in the committed time of the day-level baseline. Valid values: 0 to 47.
                /// </summary>
                [NameInMap("SlaHour")]
                [Validation(Required=false)]
                public int? SlaHour { get; set; }

                /// <summary>
                /// The minute in the alert time of the day-level baseline. Valid values: 0 to 59.
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
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
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
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The unique ID of the request. You can troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

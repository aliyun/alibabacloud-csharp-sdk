// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselinesResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselinesResponseBodyData Data { get; set; }
        public class ListBaselinesResponseBodyData : TeaModel {
            /// <summary>
            /// The baselines.
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselinesResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselinesResponseBodyDataBaselines : TeaModel {
                /// <summary>
                /// Indicates whether the alerting feature is enabled. Valid values: true and false.
                /// </summary>
                [NameInMap("AlertEnabled")]
                [Validation(Required=false)]
                public bool? AlertEnabled { get; set; }

                /// <summary>
                /// The alert margin threshold for the baseline instance. Unit: minutes.
                /// </summary>
                [NameInMap("AlertMarginThreshold")]
                [Validation(Required=false)]
                public int? AlertMarginThreshold { get; set; }

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
                /// Indicates whether the baseline is enabled. Valid values: true and false.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The settings of the committed completion time of the baseline.
                /// </summary>
                [NameInMap("OverTimeSettings")]
                [Validation(Required=false)]
                public List<ListBaselinesResponseBodyDataBaselinesOverTimeSettings> OverTimeSettings { get; set; }
                public class ListBaselinesResponseBodyDataBaselinesOverTimeSettings : TeaModel {
                    /// <summary>
                    /// The cycle that corresponds to the committed completion time. For a day-level baseline, the value of this parameter is 1. For an hour-level baseline, the value of this parameter cannot exceed 24.
                    /// </summary>
                    [NameInMap("Cycle")]
                    [Validation(Required=false)]
                    public int? Cycle { get; set; }

                    /// <summary>
                    /// The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs can be specified. The IDs are separated by commas (,).
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The priority of the baseline. Valid values: {1,2,5,7,8}.
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

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// The total number of baselines returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

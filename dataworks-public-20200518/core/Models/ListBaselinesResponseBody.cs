// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselinesResponseBodyData Data { get; set; }
        public class ListBaselinesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The baselines.</para>
            /// </summary>
            [NameInMap("Baselines")]
            [Validation(Required=false)]
            public List<ListBaselinesResponseBodyDataBaselines> Baselines { get; set; }
            public class ListBaselinesResponseBodyDataBaselines : TeaModel {
                /// <summary>
                /// <para>Indicates whether the alerting feature is enabled. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AlertEnabled")]
                [Validation(Required=false)]
                public bool? AlertEnabled { get; set; }

                /// <summary>
                /// <para>The alert margin threshold for the baseline instance. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AlertMarginThreshold")]
                [Validation(Required=false)]
                public int? AlertMarginThreshold { get; set; }

                /// <summary>
                /// <para>The baseline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The name of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BaselineName</para>
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                /// <summary>
                /// <para>The type of the baseline. Valid values: DAILY and HOURLY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY</para>
                /// </summary>
                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                /// <summary>
                /// <para>Indicates whether the baseline is enabled. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The settings of the committed completion time of the baseline.</para>
                /// </summary>
                [NameInMap("OverTimeSettings")]
                [Validation(Required=false)]
                public List<ListBaselinesResponseBodyDataBaselinesOverTimeSettings> OverTimeSettings { get; set; }
                public class ListBaselinesResponseBodyDataBaselinesOverTimeSettings : TeaModel {
                    /// <summary>
                    /// <para>The cycle that corresponds to the committed completion time. For a day-level baseline, the value of this parameter is 1. For an hour-level baseline, the value of this parameter cannot exceed 24.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cycle")]
                    [Validation(Required=false)]
                    public int? Cycle { get; set; }

                    /// <summary>
                    /// <para>The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>00:00</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs can be specified. The IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The priority of the baseline. Valid values: {1,2,5,7,8}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the baseline belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of baselines returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103630001</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The user does not exist. 276571706358178756</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795279527ab****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

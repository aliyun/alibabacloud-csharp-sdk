// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of baseline instances returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBaselineStatusesResponseBodyData Data { get; set; }
        public class ListBaselineStatusesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of baseline instances.</para>
            /// </summary>
            [NameInMap("BaselineStatuses")]
            [Validation(Required=false)]
            public List<ListBaselineStatusesResponseBodyDataBaselineStatuses> BaselineStatuses { get; set; }
            public class ListBaselineStatusesResponseBodyDataBaselineStatuses : TeaModel {
                /// <summary>
                /// <para>The ID of the baseline.</para>
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
                /// <para>BaselineType</para>
                /// </summary>
                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                /// <summary>
                /// <para>The business date timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The buffer time of the baseline instance, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("Buffer")]
                [Validation(Required=false)]
                public long? Buffer { get; set; }

                /// <summary>
                /// <para>The estimated completion time of the baseline instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The warning time of the baseline instance.</para>
                /// <para>The format is a 13-digit number, such as <c>1553531400000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("ExpTime")]
                [Validation(Required=false)]
                public long? ExpTime { get; set; }

                /// <summary>
                /// <para>The completion status of the baseline instance. Valid values: UNFINISH and FINISH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UNFINISH</para>
                /// </summary>
                [NameInMap("FinishStatus")]
                [Validation(Required=false)]
                public string FinishStatus { get; set; }

                /// <summary>
                /// <para>The completion timestamp of the baseline instance. This parameter is returned only when FinishStatus is FINISH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The cycle number of the baseline instance. The value is 1 for daily baselines. The value ranges from 1 to 24 for hourly baselines.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the baseline owner. Separate multiple owners with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The priority of the baseline. Valid values: 1, 3, 5, 7, and 8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the workspace where the baseline resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The actual completion time of the baseline instance.</para>
                /// <para>The format is a 13-digit number, such as <c>1553531400000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("SlaTime")]
                [Validation(Required=false)]
                public long? SlaTime { get; set; }

                /// <summary>
                /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGEROUS, and OVER.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAFE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of baseline instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
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
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

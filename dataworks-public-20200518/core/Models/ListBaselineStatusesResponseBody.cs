// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
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
                /// <para>Baseline name</para>
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                /// <summary>
                /// <para>The type of the baseline, including DAILY and HOURLY. Separate multiple types with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>DAILY,HOURLY</para>
                /// </summary>
                [NameInMap("BaselineType")]
                [Validation(Required=false)]
                public string BaselineType { get; set; }

                /// <summary>
                /// <para>The data timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553443200000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The margin of the baseline instance. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("Buffer")]
                [Validation(Required=false)]
                public long? Buffer { get; set; }

                /// <summary>
                /// <para>The timestamp of the predicted time when the baseline instance finished running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                /// <summary>
                /// <para>The timestamp of the alerting time of the baseline instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("ExpTime")]
                [Validation(Required=false)]
                public long? ExpTime { get; set; }

                /// <summary>
                /// <para>The status of the baseline instance. Valid values: UNFINISH and FINISH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UNFINISH</para>
                /// </summary>
                [NameInMap("FinishStatus")]
                [Validation(Required=false)]
                public string FinishStatus { get; set; }

                /// <summary>
                /// <para>The timestamp of the actual time when the baseline instance finished running. This parameter is returned if the value of the FinishStatus parameter is FINISH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the cycle of the baseline instance. Valid values of the ID of an hour-level cycle: [1,24]. The ID of a day-level cycle is 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The priority of the baseline. Valid values: {1,3,5,7,8}.</para>
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
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The timestamp of the actual time when the baseline instance finished running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553531400000</para>
                /// </summary>
                [NameInMap("SlaTime")]
                [Validation(Required=false)]
                public long? SlaTime { get; set; }

                /// <summary>
                /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGEROUS, and OVER. The value ERROR indicates that no nodes are associated with the baseline, or all nodes associated with the baseline are suspended. The value SAFE indicates that nodes are run before the alert duration begins. The value DANGEROUS indicates that nodes are still running after the alert duration ends but the committed completion time does not arrive. The value OVER indicates that nodes are still running after the committed completion time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAFE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

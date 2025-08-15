// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDeliveryHistoryJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of historical event delivery tasks.</para>
        /// </summary>
        [NameInMap("DeliveryHistoryJobs")]
        [Validation(Required=false)]
        public List<ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs> DeliveryHistoryJobs { get; set; }
        public class ListDeliveryHistoryJobsResponseBodyDeliveryHistoryJobs : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-26T03:17:04Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the task ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-26T03:22:04Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The home region of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16602</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The task is initializing.</description></item>
            /// <item><description>1: The task is delivering historical events.</description></item>
            /// <item><description>2: The task is complete.</description></item>
            /// <item><description>3: The task fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <para>The time when the task started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-26T03:17:04Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The name of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trail-name</para>
            /// </summary>
            [NameInMap("TrailName")]
            [Validation(Required=false)]
            public string TrailName { get; set; }

            /// <summary>
            /// <para>The time when the task was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-26T03:20:08Z</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B190816C-6DCA-4DC5-9B8E-EE0367B57CFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of historical event delivery tasks returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

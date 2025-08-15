// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetDeliveryHistoryJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T07:15:03Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the task ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T07:20:03Z</para>
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
        /// <para>The ID of the task.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAFEC427-A00D-5653-B837-D0FA52220D8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the task started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-26T07:15:03Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>A list of task statuses in each region.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<GetDeliveryHistoryJobResponseBodyStatus> Status { get; set; }
        public class GetDeliveryHistoryJobResponseBodyStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The task status in each region. Valid values:</para>
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The name of the trail based on which the task delivers events.</para>
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
        /// <para>2021-05-27T07:28:47Z</para>
        /// </summary>
        [NameInMap("UpdatedTime")]
        [Validation(Required=false)]
        public string UpdatedTime { get; set; }

    }

}

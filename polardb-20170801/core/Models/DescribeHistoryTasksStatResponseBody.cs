// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description><para>Scheduled: The task is waiting to be executed.</para>
            /// </description></item>
            /// <item><description><para>Running: The task is running.</para>
            /// </description></item>
            /// <item><description><para>Succeed: The task is successful.</para>
            /// </description></item>
            /// <item><description><para>Failed: The task failed.</para>
            /// </description></item>
            /// <item><description><para>Cancelling: The task is being canceled.</para>
            /// </description></item>
            /// <item><description><para>Canceled: The task is canceled.</para>
            /// </description></item>
            /// <item><description><para>Waiting: The task is waiting for a scheduled time.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

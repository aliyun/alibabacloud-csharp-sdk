// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The task objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduled: The task is waiting to be executed.</description></item>
            /// <item><description>Running: The task is running.</description></item>
            /// <item><description>Succeed: The task is successful.</description></item>
            /// <item><description>Failed: The task failed.</description></item>
            /// <item><description>Cancelling: The task is being terminated.</description></item>
            /// <item><description>Canceled: The task has been terminated.</description></item>
            /// <item><description>Waiting: The task is waiting for scheduled time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The number of tasks in a specified state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC724D23-XXXX-XXXX-ABB1-606C935AE7FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

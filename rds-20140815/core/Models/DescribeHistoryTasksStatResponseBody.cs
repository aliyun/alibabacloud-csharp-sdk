// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryTasksStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of task information.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeHistoryTasksStatResponseBodyItems> Items { get; set; }
        public class DescribeHistoryTasksStatResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b>: Waiting to be executed.</description></item>
            /// <item><description><b>Running</b>: Running.</description></item>
            /// <item><description><b>Succeed</b>: Succeeded.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// <item><description><b>Cancelling</b>: Being stopped.</description></item>
            /// <item><description><b>Canceled</b>: Stopped.</description></item>
            /// <item><description><b>Waiting</b>: Waiting for the scheduled time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeed,Waiting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

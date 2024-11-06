// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0C2EF95-B1EC-4C93-855E-2059A7DA2B7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of prefetch or refresh tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeDcdnRefreshTaskByIdResponseBodyTasks> Tasks { get; set; }
        public class DescribeDcdnRefreshTaskByIdResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-10T08:54:23Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error returned when the refresh or prefetch task failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internal Error</b>: An internal error occurred.</description></item>
            /// <item><description><b>Origin Timeout</b>: The response from the origin server timed out.</description></item>
            /// <item><description><b>Origin Return StatusCode 5XX</b>: The origin server returned a 5XX error.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internal Error</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The path of the refresh or prefetch object.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/image_01.png">http://example.com/image_01.png</a></para>
            /// </summary>
            [NameInMap("ObjectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

            /// <summary>
            /// <para>The type of the refresh or prefetch task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b>: refreshes an individual file.</description></item>
            /// <item><description><b>directory</b>: refreshes files under the specified directory.</description></item>
            /// <item><description><b>preload</b>: prefetches an individual file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The progress of the task, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Complete</b>: The task is complete.</description></item>
            /// <item><description><b>Pending</b>: The task is pending.</description></item>
            /// <item><description><b>Refreshing</b>: The task is running.</description></item>
            /// <item><description><b>Failed</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>113681**</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribePreloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribePreloadTasksResponseBodyTasks> Tasks { get; set; }
        public class DescribePreloadTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The prefetched content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://a.com/1.jpg?b=2">http://a.com/1.jpg?b=2</a></para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-28 14:28:57</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned upon a prefetch task failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Internal Error</b></description></item>
            /// <item><description><b>Origin Timeout</b></description></item>
            /// <item><description><b>Origin Return StatusCode 5XX</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internal Error</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The task status.</para>
            /// <list type="bullet">
            /// <item><description><b>Complete</b>: The task is complete.</description></item>
            /// <item><description><b>Refreshing</b>: The task is in progress.</description></item>
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
            /// <para>The ID of the queried task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1597854579687428</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174F6032-AA26-470D-****-36F0EB205BEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the returned tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeVodRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeVodRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeVodRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeVodRefreshTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>The time when the task was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-11-27T08:23:22Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The type of error returned when the refresh or prefetch task failed. Valid values: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Internal Error</b>: An internal error occurred.</description></item>
                /// <item><description><b>Origin Timeout</b>: The response from the origin server timed out.</description></item>
                /// <item><description><b>Origin Return StatusCode 5XX</b>: The origin server returned an HTTP status code 5xx.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Internal Error</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the object refreshed.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/****.txt">http://example.com/****.txt</a></para>
                /// </summary>
                [NameInMap("ObjectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

                /// <summary>
                /// <para>The type of the task. Default value: file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>file</b>: refreshes one or more files.</description></item>
                /// <item><description><b>directory</b>: refreshes files in the specified directory.</description></item>
                /// <item><description><b>preload</b>: prefetches one or more files.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The progress of the task in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Complete</b>: The task is complete.</description></item>
                /// <item><description><b>Refreshing</b>: The task is in progress.</description></item>
                /// <item><description><b>Failed</b>: The task failed.</description></item>
                /// <item><description><b>Pending</b>: The task is pending.</description></item>
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
                /// <para>704225667</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174F6032-AA26-470D-B90E-36F0EB205BEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDcdnRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDcdnRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDcdnRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDcdnRefreshTasksResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>The time when the task was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-11-27T08:23:22Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The type of error returned when the refresh or prefetch task has failed.</para>
                /// <list type="bullet">
                /// <item><description><b>InternalError</b>: An internal error occurred.</description></item>
                /// <item><description><b>OriginTimeout</b>: The response from the origin server timed out.</description></item>
                /// <item><description><b>OriginReturn StatusCode 5XX</b>: The origin server returned a 5XX error.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InternalError</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the object refreshed.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com/examplefile.txt">http://example.com/examplefile.txt</a></para>
                /// </summary>
                [NameInMap("ObjectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

                /// <summary>
                /// <para>The type of the task.</para>
                /// <list type="bullet">
                /// <item><description><b>file</b>: URL-based refresh</description></item>
                /// <item><description><b>path</b>: directory-based refresh</description></item>
                /// <item><description><b>preload</b>: URL-based prefetch</description></item>
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
                /// <para>10</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
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
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

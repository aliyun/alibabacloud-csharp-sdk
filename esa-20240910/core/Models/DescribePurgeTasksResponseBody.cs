// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribePurgeTasksResponseBody : TeaModel {
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribePurgeTasksResponseBodyTasks> Tasks { get; set; }
        public class DescribePurgeTasksResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The purged content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://a.com/1.jpg?b=1">http://a.com/1.jpg?b=1</a></para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-07-26T01:56:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error description returned when the purge task failed.</para>
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
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16346513304</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the purge task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b> (default): purges the cache by file.</description></item>
            /// <item><description><b>cachetag</b>: purges the cache by cache tag.</description></item>
            /// <item><description><b>directory</b>: purges the cache by directory.</description></item>
            /// <item><description><b>ignoreParams</b>: purges the cache by URL with specified parameters ignored.</description></item>
            /// <item><description><b>hostname</b>: purges the cache by hostname.</description></item>
            /// <item><description><b>purgeall</b>: purges all cache.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

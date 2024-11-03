// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0C2EF95-B1EC-4C93-855E-2059A7DA2B7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeRefreshTaskByIdResponseBodyTasks> Tasks { get; set; }
        public class DescribeRefreshTaskByIdResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-03T08:54:23Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The error returned when the refresh or prefetch task failed. Valid values:</para>
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
            /// <para>The path of the object refreshed by the refresh task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com/abc.jpg">http://example.com/abc.jpg</a></para>
            /// </summary>
            [NameInMap("ObjectPath")]
            [Validation(Required=false)]
            public string ObjectPath { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b>: refreshes an individual file.</description></item>
            /// <item><description><b>directory</b>: refreshes files in the specified directory.</description></item>
            /// <item><description><b>preload</b>: prefetches an individual file.</description></item>
            /// <item><description><b>regex</b>: refreshes content based on a regular expression.</description></item>
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
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Complete</b></description></item>
            /// <item><description><b>Pending</b></description></item>
            /// <item><description><b>Refreshing</b></description></item>
            /// <item><description><b>Failed</b></description></item>
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
            /// <para>24840</para>
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

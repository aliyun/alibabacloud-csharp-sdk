// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("CDNTask")]
            [Validation(Required=false)]
            public List<DescribeRefreshTasksResponseBodyTasksCDNTask> CDNTask { get; set; }
            public class DescribeRefreshTasksResponseBodyTasksCDNTask : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ObjectPath")]
                [Validation(Required=false)]
                public string ObjectPath { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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

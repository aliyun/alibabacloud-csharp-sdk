// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeLoadTasksRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp2590j****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The list of task information.</para>
        /// </summary>
        [NameInMap("LoadTasksRecords")]
        [Validation(Required=false)]
        public List<DescribeLoadTasksRecordsResponseBodyLoadTasksRecords> LoadTasksRecords { get; set; }
        public class DescribeLoadTasksRecordsResponseBodyLoadTasksRecords : TeaModel {
            /// <summary>
            /// <para>The start time of the task, accurate to milliseconds. The time is in the <i>yyyy-MM-ddTHH:mm:ss.SSSZ</i> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-18 18:47:27.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the database involved in the import or export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021051818472717201616624903453******</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021051818472717201616624903453******</para>
            /// </summary>
            [NameInMap("ProcessID")]
            [Validation(Required=false)]
            public string ProcessID { get; set; }

            /// <summary>
            /// <para>The number of data rows processed by the asynchronous import or export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ProcessRows")]
            [Validation(Required=false)]
            public long? ProcessRows { get; set; }

            /// <summary>
            /// <para>The SQL statement used in the asynchronous import or export task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>insert overwrite into courses_external_table\nselect * from courses</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the task status was updated, accurate to milliseconds. The time is in the <i>yyyy-MM-ddTHH:mm:ss.SSSZ</i> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-18 18:47:31.0</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C60B05DB-2B77-421A-98E9-92C20E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the SQL tasks.</para>
        /// </summary>
        [NameInMap("DBTaskSQLJobList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobResponseBodyDBTaskSQLJobList> DBTaskSQLJobList { get; set; }
        public class ListDBTaskSQLJobResponseBodyDBTaskSQLJobList : TeaModel {
            /// <summary>
            /// <para>The description of the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the SQL task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-18 17:49:20</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43214523</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The name that is used to search for the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test@xxx:3306【test】</para>
            /// </summary>
            [NameInMap("DbSearchName")]
            [Validation(Required=false)]
            public string DbSearchName { get; set; }

            /// <summary>
            /// <para>The ID of the SQL task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4324132</para>
            /// </summary>
            [NameInMap("DbTaskGroupId")]
            [Validation(Required=false)]
            public long? DbTaskGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123435</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The type of the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRUCT_SYNC</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The time when the SQL task was last executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-18 17:49:31</para>
            /// </summary>
            [NameInMap("LastExecTime")]
            [Validation(Required=false)]
            public string LastExecTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The database is a logical database.</description></item>
            /// <item><description><b>false</b>: The database is a logical database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>The state of the SQL task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The SQL task was initialized.</description></item>
            /// <item><description><b>PENDING</b>: The SQL task waited to be run.</description></item>
            /// <item><description><b>BE_SCHEDULED</b>: The SQL task waited to be scheduled.</description></item>
            /// <item><description><b>FAIL</b>: The SQL task failed.</description></item>
            /// <item><description><b>SUCCESS</b>: The SQL task was successful.</description></item>
            /// <item><description><b>PAUSE</b>: The SQL task was paused.</description></item>
            /// <item><description><b>DELETE</b>: The SQL task was deleted.</description></item>
            /// <item><description><b>RUNNING</b>: The SQL task was being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL task is executed as a transaction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The SQL task is executed as a transaction.</description></item>
            /// <item><description><b>false</b>: The SQL task is not executed as a transaction.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Transactional")]
            [Validation(Required=false)]
            public bool? Transactional { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6C47680-8D2D-43A4-8902-F2740D71A398</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of the SQL tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

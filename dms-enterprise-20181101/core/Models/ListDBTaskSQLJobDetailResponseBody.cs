// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of SQL tasks.</para>
        /// </summary>
        [NameInMap("DBTaskSQLJobDetailList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList> DBTaskSQLJobDetailList { get; set; }
        public class ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList : TeaModel {
            /// <summary>
            /// <para>The number of rows affected by the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// <para>The SQL statement that was executed in the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>update a set id = 1 where id  = 1;</para>
            /// </summary>
            [NameInMap("CurrentSql")]
            [Validation(Required=false)]
            public string CurrentSql { get; set; }

            /// <summary>
            /// <para>The ID of the physical database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1988****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The point in time when the SQL task ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-16 00:00:01</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of times that the SQL statement was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// <para>The ID of the details of the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24723****</para>
            /// </summary>
            [NameInMap("JobDetailId")]
            [Validation(Required=false)]
            public long? JobDetailId { get; set; }

            /// <summary>
            /// <para>The ID of the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1276****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The details of the operational log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>log_info</para>
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// <para>Indicates whether the database is a logical database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The database is a logical database.</description></item>
            /// <item><description><b>false</b>: The database is a physical database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement was skipped. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The SQL statement was skipped.</description></item>
            /// <item><description><b>false</b>: The SQL statement was not skipped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_TABLE</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The point in time when the SQL task started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-16 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the SQL task. Valid values:</para>
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
            /// <para>The duration of the SQL task. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("TimeDelay")]
            [Validation(Required=false)]
            public long? TimeDelay { get; set; }

        }

        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingJobId</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobId is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F044E33-FE09-58F1-8C61-A0F612EC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of SQL tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

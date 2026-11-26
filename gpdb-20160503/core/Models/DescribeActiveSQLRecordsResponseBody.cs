// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeActiveSQLRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp12ga6v69h86****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The query details.</para>
        /// </summary>
        [NameInMap("Queries")]
        [Validation(Required=false)]
        public List<DescribeActiveSQLRecordsResponseBodyQueries> Queries { get; set; }
        public class DescribeActiveSQLRecordsResponseBodyQueries : TeaModel {
            /// <summary>
            /// <para>The client address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0</para>
            /// </summary>
            [NameInMap("ClientAddr")]
            [Validation(Required=false)]
            public string ClientAddr { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xg_analyse</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6164</para>
            /// </summary>
            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            /// <summary>
            /// <para>The SQL text of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Select * from t1,t2 where t1.id=t2.id;</para>
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// <para>The execution duration of the query, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("QueryDuration")]
            [Validation(Required=false)]
            public string QueryDuration { get; set; }

            /// <summary>
            /// <para>The start time of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-07T06:59Z</para>
            /// </summary>
            [NameInMap("QueryStart")]
            [Validation(Required=false)]
            public string QueryStart { get; set; }

            /// <summary>
            /// <para>The ID of the session to which the query belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6612</para>
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            /// <summary>
            /// <para>Specifies whether the SQL statement is truncated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SqlTruncated")]
            [Validation(Required=false)]
            public string SqlTruncated { get; set; }

            /// <summary>
            /// <para>The truncation threshold for the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SqlTruncatedThreshold")]
            [Validation(Required=false)]
            public string SqlTruncatedThreshold { get; set; }

            /// <summary>
            /// <para>The execution status of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: Running.</description></item>
            /// <item><description><b>block</b>: Blocked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

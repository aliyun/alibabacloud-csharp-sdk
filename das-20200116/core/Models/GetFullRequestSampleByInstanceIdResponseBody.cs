// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestSampleByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetFullRequestSampleByInstanceIdResponseBodyData> Data { get; set; }
        public class GetFullRequestSampleByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbtest</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The number of rows fetched by PolarDB-X 2.0 compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Frows")]
            [Validation(Required=false)]
            public long? Frows { get; set; }

            /// <summary>
            /// <para>The lock wait duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0137</para>
            /// </summary>
            [NameInMap("LockWaitTime")]
            [Validation(Required=false)]
            public double? LockWaitTime { get; set; }

            /// <summary>
            /// <para>The number of logical reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165848</para>
            /// </summary>
            [NameInMap("LogicalRead")]
            [Validation(Required=false)]
            public double? LogicalRead { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.17.XX.XX</para>
            /// </summary>
            [NameInMap("OriginHost")]
            [Validation(Required=false)]
            public string OriginHost { get; set; }

            /// <summary>
            /// <para>The number of physical asynchronous reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PhysicalAsyncRead")]
            [Validation(Required=false)]
            public double? PhysicalAsyncRead { get; set; }

            /// <summary>
            /// <para>The number of physical synchronous reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PhysicalSyncRead")]
            [Validation(Required=false)]
            public double? PhysicalSyncRead { get; set; }

            /// <summary>
            /// <para>The number of rows updated or returned on PolarDB-X 2.0 compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public long? Rows { get; set; }

            /// <summary>
            /// <para>The total number of scanned rows.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2048576</para>
            /// </summary>
            [NameInMap("RowsExamined")]
            [Validation(Required=false)]
            public long? RowsExamined { get; set; }

            /// <summary>
            /// <para>The number of rows returned by the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("RowsReturned")]
            [Validation(Required=false)]
            public long? RowsReturned { get; set; }

            /// <summary>
            /// <para>The amount of time consumed to execute the SQL statement. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.409789</para>
            /// </summary>
            [NameInMap("Rt")]
            [Validation(Required=false)]
            public double? Rt { get; set; }

            /// <summary>
            /// <para>The number of scanned rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScanRows")]
            [Validation(Required=false)]
            public long? ScanRows { get; set; }

            /// <summary>
            /// <para>The number of requests sent from PolarDB-X 2.0 compute nodes to data nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Scnt")]
            [Validation(Required=false)]
            public long? Scnt { get; set; }

            /// <summary>
            /// <para>The sample SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from testdb01 where ****</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public string Sql { get; set; }

            /// <summary>
            /// <para>The SQL statement ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>651b56fe9418d48edb8fdf0980ec****</para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement. Valid values: <b>SELECT</b>, <b>INSERT</b>, <b>UPDATE</b>, <b>DELETE</b>, <b>LOGIN</b>, <b>LOGOUT</b>, <b>MERGE</b>, <b>ALTER</b>, <b>CREATEINDEX</b>, <b>DROPINDEX</b>, <b>CREATE</b>, <b>DROP</b>, <b>SET</b>, <b>DESC</b>, <b>REPLACE</b>, <b>CALL</b>, <b>BEGIN</b>, <b>DESCRIBE</b>, <b>ROLLBACK</b>, <b>FLUSH</b>, <b>USE</b>, <b>SHOW</b>, <b>START</b>, <b>COMMIT</b>, and <b>RENAME</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The time when the SQL statement was executed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660100753556</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// <para>The number of updated rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UpdateRows")]
            [Validation(Required=false)]
            public long? UpdateRows { get; set; }

            /// <summary>
            /// <para>The name of the user who executes the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message that contains information such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A74B755-98B7-59DB-8724-1321B394****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

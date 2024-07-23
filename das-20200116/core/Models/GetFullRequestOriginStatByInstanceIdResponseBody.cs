// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestOriginStatByInstanceIdResponseBody : TeaModel {
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFullRequestOriginStatByInstanceIdResponseBodyData Data { get; set; }
        public class GetFullRequestOriginStatByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the full request data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetFullRequestOriginStatByInstanceIdResponseBodyDataList> List { get; set; }
            public class GetFullRequestOriginStatByInstanceIdResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The average number of scanned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("AvgExaminedRows")]
                [Validation(Required=false)]
                public double? AvgExaminedRows { get; set; }

                /// <summary>
                /// <para>The average number of rows that are fetched from data nodes by compute nodes on the PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgFetchRows")]
                [Validation(Required=false)]
                public long? AvgFetchRows { get; set; }

                /// <summary>
                /// <para>The average lock wait duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.00009589874265269765</para>
                /// </summary>
                [NameInMap("AvgLockWaitTime")]
                [Validation(Required=false)]
                public double? AvgLockWaitTime { get; set; }

                /// <summary>
                /// <para>The average number of logical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>654.4470327860251</para>
                /// </summary>
                [NameInMap("AvgLogicalRead")]
                [Validation(Required=false)]
                public double? AvgLogicalRead { get; set; }

                /// <summary>
                /// <para>The average number of physical asynchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgPhysicalAsyncRead")]
                [Validation(Required=false)]
                public long? AvgPhysicalAsyncRead { get; set; }

                /// <summary>
                /// <para>The average number of physical synchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgPhysicalSyncRead")]
                [Validation(Required=false)]
                public double? AvgPhysicalSyncRead { get; set; }

                /// <summary>
                /// <para>The average number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("AvgReturnedRows")]
                [Validation(Required=false)]
                public double? AvgReturnedRows { get; set; }

                /// <summary>
                /// <para>The average number of rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgRows")]
                [Validation(Required=false)]
                public long? AvgRows { get; set; }

                /// <summary>
                /// <para>The average execution duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.499</para>
                /// </summary>
                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public double? AvgRt { get; set; }

                /// <summary>
                /// <para>The average number of SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("AvgSqlCount")]
                [Validation(Required=false)]
                public long? AvgSqlCount { get; set; }

                /// <summary>
                /// <para>The average number of updated rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for MySQL and PolarDB-X 2.0 databases.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("AvgUpdatedRows")]
                [Validation(Required=false)]
                public double? AvgUpdatedRows { get; set; }

                /// <summary>
                /// <para>The total number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The percentage of the total number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0586</para>
                /// </summary>
                [NameInMap("CountRate")]
                [Validation(Required=false)]
                public double? CountRate { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbtest01</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The number of failed executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public long? ErrorCount { get; set; }

                /// <summary>
                /// <para>The total number of scanned rows.</para>
                /// <remarks>
                /// <para>This parameter is returned only for ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL databases.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ExaminedRows")]
                [Validation(Required=false)]
                public long? ExaminedRows { get; set; }

                /// <summary>
                /// <para>The number of rows that are fetched from data nodes by compute nodes on the PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("FetchRows")]
                [Validation(Required=false)]
                public long? FetchRows { get; set; }

                /// <summary>
                /// <para>The network address of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6dyi58dm6****.mysql.rds.aliy****.com</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The IP address of the client that executes the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.26.6****</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The lock wait duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1089.4177720290281</para>
                /// </summary>
                [NameInMap("LockWaitTime")]
                [Validation(Required=false)]
                public double? LockWaitTime { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.434573266E9</para>
                /// </summary>
                [NameInMap("LogicalRead")]
                [Validation(Required=false)]
                public long? LogicalRead { get; set; }

                /// <summary>
                /// <para>The IP address of the client that executes the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.26.6****</para>
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
                public long? PhysicalAsyncRead { get; set; }

                /// <summary>
                /// <para>The number of physical synchronous reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicalSyncRead")]
                [Validation(Required=false)]
                public long? PhysicalSyncRead { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The total number of rows updated or returned by the compute nodes of the PolarDB-X 2.0 instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that take longer than 1 second to execute.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RtGreaterThanOneSecondCount")]
                [Validation(Required=false)]
                public long? RtGreaterThanOneSecondCount { get; set; }

                /// <summary>
                /// <para>The execution duration percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1384</para>
                /// </summary>
                [NameInMap("RtRate")]
                [Validation(Required=false)]
                public double? RtRate { get; set; }

                /// <summary>
                /// <para>The number of SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SqlCount")]
                [Validation(Required=false)]
                public long? SqlCount { get; set; }

                /// <summary>
                /// <para>The total number of updated rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("SumUpdatedRows")]
                [Validation(Required=false)]
                public long? SumUpdatedRows { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zentqj1sk4qmolci****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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
        /// <para>7172BECE-588A-5961-8126-C216E16B****</para>
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

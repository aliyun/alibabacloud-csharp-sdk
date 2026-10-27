// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestStatResultByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
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
        public GetFullRequestStatResultByInstanceIdResponseBodyData Data { get; set; }
        public class GetFullRequestStatResultByInstanceIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the request failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public bool? Fail { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request is completed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: no.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The returned full request data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetFullRequestStatResultByInstanceIdResponseBodyDataResult Result { get; set; }
            public class GetFullRequestStatResultByInstanceIdResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The list of full request data.</para>
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<GetFullRequestStatResultByInstanceIdResponseBodyDataResultList> List { get; set; }
                public class GetFullRequestStatResultByInstanceIdResponseBodyDataResultList : TeaModel {
                    /// <summary>
                    /// <para>The average number of scanned rows.</para>
                    /// <remarks>
                    /// <para>This field is supported by the following databases: ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("AvgExaminedRows")]
                    [Validation(Required=false)]
                    public double? AvgExaminedRows { get; set; }

                    /// <summary>
                    /// <para>The average number of rows pulled by the compute node from the data node in the PolarDB-X 2.0 database instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvgFetchRows")]
                    [Validation(Required=false)]
                    public long? AvgFetchRows { get; set; }

                    /// <summary>
                    /// <para>The average lock wait time, in seconds.</para>
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
                    public long? AvgPhysicalSyncRead { get; set; }

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
                    /// <para>The average time to execute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.499</para>
                    /// </summary>
                    [NameInMap("AvgRt")]
                    [Validation(Required=false)]
                    public double? AvgRt { get; set; }

                    /// <summary>
                    /// <para>The average SQL count.</para>
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
                    /// <para>This field is supported by the following databases: ApsaraDB RDS for MySQL and PolarDB-X 2.0.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("AvgUpdatedRows")]
                    [Validation(Required=false)]
                    public long? AvgUpdatedRows { get; set; }

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
                    /// <para>The proportion of times the statements execute.</para>
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
                    /// <para>The number of execution errors.</para>
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
                    /// <para>This field is supported by the following databases: ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("ExaminedRows")]
                    [Validation(Required=false)]
                    public long? ExaminedRows { get; set; }

                    /// <summary>
                    /// <para>The number of rows pulled by the compute node from the data node in the PolarDB-X 2.0 database instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FetchRows")]
                    [Validation(Required=false)]
                    public long? FetchRows { get; set; }

                    /// <summary>
                    /// <para>The network address of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-uf6dyi58dm6****.mysql.rds.aliy****.com</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <para>The lock wait time, in seconds.</para>
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
                    /// <para>The port number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// <para>The SQL template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select * from dbtest01 where ****</para>
                    /// </summary>
                    [NameInMap("Psql")]
                    [Validation(Required=false)]
                    public string Psql { get; set; }

                    /// <summary>
                    /// <para>The total number of rows updated or returned by the compute node in the PolarDB-X 2.0 database instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// <para>The number of SQL statements whose execution time is greater than 1 second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("RtGreaterThanOneSecondCount")]
                    [Validation(Required=false)]
                    public long? RtGreaterThanOneSecondCount { get; set; }

                    /// <summary>
                    /// <para>The execution time proportion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.499</para>
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
                    /// <para>The SQL ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d71f82be1eef72bd105128204d2e****</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <para>The total number of changed rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SumUpdatedRows")]
                    [Validation(Required=false)]
                    public long? SumUpdatedRows { get; set; }

                    /// <summary>
                    /// <para>The name of the database table.</para>
                    /// </summary>
                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                    /// <summary>
                    /// <para>The version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public long? Version { get; set; }

                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zentqj1sk4qmolci****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The total amount of data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>The ID of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9CB97BC4-6479-55D0-B9D0-EA925AFE****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The execution status of the asynchronous request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RUNNING</b>: running.</para>
            /// </description></item>
            /// <item><description><para><b>SUCCESS</b>: successful.</para>
            /// </description></item>
            /// <item><description><para><b>FAIL</b>: failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The execution time. The time is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1645668213000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message such as an error code is returned.</para>
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
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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

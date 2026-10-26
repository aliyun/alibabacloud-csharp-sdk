// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceReplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether native replication mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Enabled.</description></item>
        /// <item><description><b>OFF</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("ExternalReplication")]
        [Validation(Required=false)]
        public string ExternalReplication { get; set; }

        /// <summary>
        /// <para>The executed global transaction identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bd2a34b9-8b8d-11ef-8917-00163e1298b9:1-20567</para>
        /// </summary>
        [NameInMap("GtidExecuted")]
        [Validation(Required=false)]
        public string GtidExecuted { get; set; }

        /// <summary>
        /// <para>The import status, which indicates whether full data is successfully imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("ImportStatus")]
        [Validation(Required=false)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// <para>The current replication delay, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReplicationDelay")]
        [Validation(Required=false)]
        public string ReplicationDelay { get; set; }

        /// <summary>
        /// <para>The replication error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Got fatal error 1236 from master when reading data from binary log...</para>
        /// </summary>
        [NameInMap("ReplicationErrorMessage")]
        [Validation(Required=false)]
        public string ReplicationErrorMessage { get; set; }

        /// <summary>
        /// <para>The IP address of the replication endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.x</para>
        /// </summary>
        [NameInMap("ReplicationIp")]
        [Validation(Required=false)]
        public string ReplicationIp { get; set; }

        /// <summary>
        /// <para>The port of the replication endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("ReplicationPort")]
        [Validation(Required=false)]
        public string ReplicationPort { get; set; }

        /// <summary>
        /// <para>The replication source for native replication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("ReplicationSource")]
        [Validation(Required=false)]
        public string ReplicationSource { get; set; }

        /// <summary>
        /// <para>The current replication state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Connecting</b>: Connecting.</description></item>
        /// <item><description><b>Stopped</b>: Stopped.</description></item>
        /// <item><description><b>Error</b>: Error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("ReplicationState")]
        [Validation(Required=false)]
        public string ReplicationState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>847BA085-B377-4BFA-8267-F82345ECE1D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The replication status information returned by the SHOW SLAVE STATUS statement for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SlaveIoRunning&quot;: &quot;Yes&quot;, &quot;SlaveSqlRunning&quot;: &quot;Yes&quot;, &quot;SecondsBehindMaster&quot;: 0, &quot;SlaveIoState&quot;: &quot;Waiting for master to send event&quot;, &quot;SlaveSqlRunningState&quot;: &quot;Slave has read all relay log; waiting for more updates&quot;, &quot;ExecutedGtidSet&quot;: &quot;bd2a34b9-8b8d-11ef-8917-00163e1298b9:1-20567&quot;, &quot;MasterHost&quot;: &quot;192.168.10.100&quot;, &quot;MasterUser&quot;: &quot;repl_user&quot;, &quot;MasterUuid&quot;: &quot;bd2a34b9-8b8d-11ef-8917-00163e1298b9&quot;, &quot;LastErrno&quot;: 0, &quot;LastSqlErrno&quot;: 0, &quot;LastIoErrno&quot;: 0, &quot;LastSqlError&quot;: &quot;&quot;, &quot;LastIoError&quot;: &quot;&quot;, &quot;ChannelName&quot;: &quot;my_test_channel&quot;, &quot;ReplicateDoDb&quot;: &quot;test_db,test_db_1&quot;, &quot;ReplicateIgnoreDb&quot;: &quot;information_schema,performance_schema&quot;, &quot;ReplicateDoTable&quot;: &quot;test_table,test_table_1&quot;, &quot;ReplicateIgnoreTable&quot;: &quot;temp_table,temp_table_1&quot;, &quot;ReplicateWildDoTable&quot;: &quot;test_table.%&quot;, &quot;ReplicateWildIgnoreTable&quot;: &quot;temp_table.%&quot;}]</para>
        /// </summary>
        [NameInMap("SlaveStatusList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceReplicationResponseBodySlaveStatusList> SlaveStatusList { get; set; }
        public class DescribeDBInstanceReplicationResponseBodySlaveStatusList : TeaModel {
            /// <summary>
            /// <para>The name of the replication channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_test_channel</para>
            /// </summary>
            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The executed GTID set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bd2a34b9-8b8d-11ef-8917-00163e1298b9:1-20567</para>
            /// </summary>
            [NameInMap("ExecutedGtidSet")]
            [Validation(Required=false)]
            public string ExecutedGtidSet { get; set; }

            /// <summary>
            /// <para>The last error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LastErrno")]
            [Validation(Required=false)]
            public int? LastErrno { get; set; }

            /// <summary>
            /// <para>The last error code of the I/O thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LastIoErrno")]
            [Validation(Required=false)]
            public int? LastIoErrno { get; set; }

            /// <summary>
            /// <para>The last error message of the I/O thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error connecting to master \&quot;<a href="mailto:user@192.0.2.1">user@192.0.2.1</a>:3306\&quot; - retry-time: 60  retries: 5</para>
            /// </summary>
            [NameInMap("LastIoError")]
            [Validation(Required=false)]
            public string LastIoError { get; set; }

            /// <summary>
            /// <para>The last error code of the SQL thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LastSqlErrno")]
            [Validation(Required=false)]
            public int? LastSqlErrno { get; set; }

            /// <summary>
            /// <para>The last error message of the SQL thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Coordinator stopped because there were error(s) in the worker(s). The most recent failure being: Worker 1 failed executing transaction \&quot;00000000-0000-0000-0000-000000000000:1\&quot; at source log mysql-bin.000001, end_log_pos 12345. See error log and/or performance_schema.replication_applier_status_by_worker table for more details about this failure or others, if any.</para>
            /// </summary>
            [NameInMap("LastSqlError")]
            [Validation(Required=false)]
            public string LastSqlError { get; set; }

            /// <summary>
            /// <para>The address of the primary database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.100</para>
            /// </summary>
            [NameInMap("MasterHost")]
            [Validation(Required=false)]
            public string MasterHost { get; set; }

            /// <summary>
            /// <para>The account of the primary database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>repl_user</para>
            /// </summary>
            [NameInMap("MasterUser")]
            [Validation(Required=false)]
            public string MasterUser { get; set; }

            /// <summary>
            /// <para>The UUID of the primary database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bd2a34b9-8b8d-11ef-8917-00163e1298b9</para>
            /// </summary>
            [NameInMap("MasterUuid")]
            [Validation(Required=false)]
            public string MasterUuid { get; set; }

            /// <summary>
            /// <para>The databases included in replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db,test_db_1</para>
            /// </summary>
            [NameInMap("ReplicateDoDb")]
            [Validation(Required=false)]
            public string ReplicateDoDb { get; set; }

            /// <summary>
            /// <para>The tables included in replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table,test_table_1</para>
            /// </summary>
            [NameInMap("ReplicateDoTable")]
            [Validation(Required=false)]
            public string ReplicateDoTable { get; set; }

            /// <summary>
            /// <para>The databases ignored in replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>information_schema,performance_schema</para>
            /// </summary>
            [NameInMap("ReplicateIgnoreDb")]
            [Validation(Required=false)]
            public string ReplicateIgnoreDb { get; set; }

            /// <summary>
            /// <para>The tables ignored in replication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>temp_table,temp_table_1</para>
            /// </summary>
            [NameInMap("ReplicateIgnoreTable")]
            [Validation(Required=false)]
            public string ReplicateIgnoreTable { get; set; }

            /// <summary>
            /// <para>The tables included in replication. Wildcards are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table.%</para>
            /// </summary>
            [NameInMap("ReplicateWildDoTable")]
            [Validation(Required=false)]
            public string ReplicateWildDoTable { get; set; }

            /// <summary>
            /// <para>The tables ignored in replication. Wildcards are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>temp_table.%</para>
            /// </summary>
            [NameInMap("ReplicateWildIgnoreTable")]
            [Validation(Required=false)]
            public string ReplicateWildIgnoreTable { get; set; }

            /// <summary>
            /// <para>The data delay, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecondsBehindMaster")]
            [Validation(Required=false)]
            public int? SecondsBehindMaster { get; set; }

            /// <summary>
            /// <para>The running status of the replication I/O thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("SlaveIoRunning")]
            [Validation(Required=false)]
            public string SlaveIoRunning { get; set; }

            /// <summary>
            /// <para>The state of the replication I/O thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Waiting for master to send event</para>
            /// </summary>
            [NameInMap("SlaveIoState")]
            [Validation(Required=false)]
            public string SlaveIoState { get; set; }

            /// <summary>
            /// <para>The running status of the replication SQL thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yes</para>
            /// </summary>
            [NameInMap("SlaveSqlRunning")]
            [Validation(Required=false)]
            public string SlaveSqlRunning { get; set; }

            /// <summary>
            /// <para>The running status of the replication SQL thread.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Slave has read all relay log; waiting for more updates</para>
            /// </summary>
            [NameInMap("SlaveSqlRunningState")]
            [Validation(Required=false)]
            public string SlaveSqlRunningState { get; set; }

        }

    }

}

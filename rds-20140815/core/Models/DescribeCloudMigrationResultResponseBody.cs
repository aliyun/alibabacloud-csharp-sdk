// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCloudMigrationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud migration tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeCloudMigrationResultResponseBodyItems> Items { get; set; }
        public class DescribeCloudMigrationResultResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The migration details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Check rds empty]\nCheck rds databases: success\n[Check source connectivity]\nCheck ip connectable: success\nCheck port connectable: success\nCheck database connectable: success\nCheck account replication privilege: success\nCheck account createrole privilege: success\nCheck account monitor privilege: success\n[Check source version]\nCheck major version consistent: success\n[Check source glibc version]\nCheck source glibc version compatible: warning(warning:source glibc version is not compatible with rds pg)\n[Check disk size]\nCheck disk size enough: success\n[Check wal keep size]\nCheck wal keep size large enough: success\n[Check spec params]\nCheck if spec params too large: success\n[Start RDS instance]\n2022-02-25 17:00:29 --- Start RDS instance as slave for data replication\n[Synchronize data]\n2022-02-25 17:01:05 --- Synchronize data from source to RDS by streaming replication \n</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-25T08:53:13Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-01T06:39:51Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The migration stage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>precheck</b>: Precheck.</description></item>
            /// <item><description><b>basebackup</b>: Full backup.</description></item>
            /// <item><description><b>startup</b>: Link setup.</description></item>
            /// <item><description><b>increment</b>: Incremental synchronization.</description></item>
            /// <item><description><b>switch</b>: Cloud switchover.</description></item>
            /// <item><description><b>success</b>: Migration completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>switch</para>
            /// </summary>
            [NameInMap("MigrateStage")]
            [Validation(Required=false)]
            public string MigrateStage { get; set; }

            /// <summary>
            /// <para>The replication task information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Status\&quot;:\&quot;streaming\&quot;,\&quot;ReceiveStartLsn\&quot;:\&quot;0/3000000\&quot;,\&quot;ReceivedTli\&quot;:\&quot;1\&quot;,\&quot;LatestEndTime\&quot;:\&quot;2022-02-25 17:03:59.3344+08\&quot;,\&quot;Synced\&quot;:\&quot;true\&quot;,\&quot;IsSlave\&quot;:\&quot;true\&quot;,\&quot;ReplayTimestamp\&quot;:\&quot;null\&quot;,\&quot;LastMsgSendTime\&quot;:\&quot;2022-03-01 14:42:57.967537+08\&quot;,\&quot;Conninfo\&quot;:\&quot;user=migratetest password=******** channel_binding=prefer dbname=replication host=172.16.254.203 port=5432 application_name=rds_db_instance fallback_application_name=walreceiver sslmode=prefer sslcompression=1 sslsni=1 ssl_min_protocol_version=TLSv1.2 gssencmode=prefer krbsrvname=postgres target_session_attrs=any\&quot;,\&quot;LastMsgReceiptTime\&quot;:\&quot;2022-03-01 14:42:57.96727+08\&quot;,\&quot;LatestEndLsn\&quot;:\&quot;0/3000148\&quot;,\&quot;ReceivedLsn\&quot;:\&quot;0/3000148\&quot;,\&quot;ReplayLsn\&quot;:\&quot;0/3000148\&quot;,\&quot;ReceiveStartTli\&quot;:\&quot;1\&quot;,\&quot;ReplayLag\&quot;:\&quot;0\&quot;}</para>
            /// </summary>
            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            /// <summary>
            /// <para>The replication status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>unstarted</b>: Not started.</description></item>
            /// <item><description><b>catchup</b>: Catching up.</description></item>
            /// <item><description><b>streaming</b>: Streaming.</description></item>
            /// <item><description><b>disconnect</b>: Disconnected.</description></item>
            /// <item><description><b>finish</b>: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>streaming</para>
            /// </summary>
            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>migratetest</para>
            /// </summary>
            [NameInMap("SourceAccount")]
            [Validation(Required=false)]
            public string SourceAccount { get; set; }

            /// <summary>
            /// <para>The type of the self-managed PostgreSQL database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>idcOnVpc</b>: A self-managed PostgreSQL database in an IDC that is connected to a VPC.</description></item>
            /// <item><description><b>ecsOnVpc</b>: A self-managed PostgreSQL database on an Alibaba Cloud ECS instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecsonvpc</para>
            /// </summary>
            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            /// <summary>
            /// <para>The internal IP address of the self-managed PostgreSQL database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("SourceIpAddress")]
            [Validation(Required=false)]
            public string SourceIpAddress { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("SourcePassword")]
            [Validation(Required=false)]
            public string SourcePassword { get; set; }

            /// <summary>
            /// <para>The port of the self-managed PostgreSQL database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            /// <summary>
            /// <para>The switchover time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-01T06:40:51Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// <para>A reserved parameter. The query result is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("TargetEip")]
            [Validation(Required=false)]
            public string TargetEip { get; set; }

            /// <summary>
            /// <para>The instance ID of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp102g323jd4****</para>
            /// </summary>
            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>440437220</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>362c6c7a-4d20-4eac-898c-1495ceab374c</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B983C48-9793-5EAA-8F7F-00EAEC517675</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}

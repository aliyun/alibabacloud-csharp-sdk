// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReplicationLinkLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1trqb4p1xd****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The records.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeReplicationLinkLogsResponseBodyItems> Items { get; set; }
        public class DescribeReplicationLinkLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The task details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Check rds empty]\nCheck rds databases: success\n[Check source connectivity]\nCheck ip connectable: success\nCheck port connectable: success\nCheck database connectable: success\nCheck account replication privilege: success\nCheck account createrole privilege: success\nCheck account monitor privilege: success\n[Check source version]\nCheck major version consistent: success\n[Check source glibc version]\nCheck source glibc version compatible: warning(warning:source glibc version is not compatible with rds pg)\n[Check disk size]\nCheck disk size enough: success\n[Check wal keep size]\nCheck wal keep size large enough: success\n[Check spec params]\nCheck if spec params too large: success\n [Check triggers]\nCheck triggers compatible: success\n[Check user functions]\nCheck user functions compatible: success\n<em>Migrate check success</em></para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-25T06:57:41Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-01T06:39:51Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The synchronization information. This is a reserved field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            /// <summary>
            /// <para>The synchronization status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>steaming</b>: Synchronizing.</description></item>
            /// <item><description><b>finish</b>: Completed.</description></item>
            /// <item><description><b>disconnect</b>: Disconnected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            /// <summary>
            /// <para>The database account used for data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdbuser</para>
            /// </summary>
            [NameInMap("ReplicatorAccount")]
            [Validation(Required=false)]
            public string ReplicatorAccount { get; set; }

            /// <summary>
            /// <para>The password of the synchronization account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testpassword</para>
            /// </summary>
            [NameInMap("ReplicatorPassword")]
            [Validation(Required=false)]
            public string ReplicatorPassword { get; set; }

            /// <summary>
            /// <para>The address of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-****.pg.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("SourceAddress")]
            [Validation(Required=false)]
            public string SourceAddress { get; set; }

            /// <summary>
            /// <para>The category of the source instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>other: Other.</description></item>
            /// <item><description>aliyunRDS: ApsaraDB RDS instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyunRDS</para>
            /// </summary>
            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            /// <summary>
            /// <para>The port of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            /// <summary>
            /// <para>The ID of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1l4dutw453****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8413252</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task stage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>precheck</b>: Dry run.</description></item>
            /// <item><description><b>basebackup</b>: Basic backup.</description></item>
            /// <item><description><b>startup</b>: Startup.</description></item>
            /// <item><description><b>increment</b>: Incremental synchronization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>increment</para>
            /// </summary>
            [NameInMap("TaskStage")]
            [Validation(Required=false)]
            public string TaskStage { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: Succeeded.</description></item>
            /// <item><description><b>failure</b>: Failed.</description></item>
            /// <item><description><b>running</b>: Running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>create</b>: Create a replication link.</description></item>
            /// <item><description><b>create-dryrun</b>: Dry run for creating a replication link.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>create</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16C62438-491B-5C02-9B49-BA924A1372A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}

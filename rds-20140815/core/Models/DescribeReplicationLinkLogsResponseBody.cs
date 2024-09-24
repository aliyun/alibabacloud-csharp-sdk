// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeReplicationLinkLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pgm-bp1trqb4p1xd****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The items.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeReplicationLinkLogsResponseBodyItems> Items { get; set; }
        public class DescribeReplicationLinkLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The details of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Check rds empty]\nCheck rds databases: success\n[Check source connectivity]\nCheck ip connectable: success\nCheck port connectable: success\nCheck database connectable: success\nCheck account replication privilege: success\nCheck account createrole privilege: success\nCheck account monitor privilege: success\n[Check source version]\nCheck major version consistent: success\n[Check source glibc version]\nCheck source glibc version compatible: warning(warning:source glibc version is not compatible with rds pg)\n[Check disk size]\nCheck disk size enough: success\n[Check wal keep size]\nCheck wal keep size large enough: success\n[Check spec params]\nCheck if spec params too large: success\n [Check triggers]\nCheck triggers compatible: success\n[Check user functions]\nCheck user functions compatible: success\n<em>Migrate check success</em></para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The creation time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-25T06:57:41Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The modification time. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-01T06:39:51Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The synchronization information. This parameter is a reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("ReplicationInfo")]
            [Validation(Required=false)]
            public string ReplicationInfo { get; set; }

            /// <summary>
            /// <para>The status of the synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>steaming</b>: The synchronization is in progress.</description></item>
            /// <item><description><b>finish</b>: The synchronization is complete.</description></item>
            /// <item><description><b>disconnect</b>: The synchronization is disconnected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("ReplicationState")]
            [Validation(Required=false)]
            public string ReplicationState { get; set; }

            /// <summary>
            /// <para>The account of the database that is used for data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdbuser</para>
            /// </summary>
            [NameInMap("ReplicatorAccount")]
            [Validation(Required=false)]
            public string ReplicatorAccount { get; set; }

            /// <summary>
            /// <para>The password of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testpassword</para>
            /// </summary>
            [NameInMap("ReplicatorPassword")]
            [Validation(Required=false)]
            public string ReplicatorPassword { get; set; }

            /// <summary>
            /// <para>The endpoint of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-****.pg.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("SourceAddress")]
            [Validation(Required=false)]
            public string SourceAddress { get; set; }

            /// <summary>
            /// <para>The type of the source instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>other: other instances</description></item>
            /// <item><description>aliyunRDS: an ApsaraDB RDS instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyunRDS</para>
            /// </summary>
            [NameInMap("SourceCategory")]
            [Validation(Required=false)]
            public string SourceCategory { get; set; }

            /// <summary>
            /// <para>The port number of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5432</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public long? SourcePort { get; set; }

            /// <summary>
            /// <para>The destination instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pgm-bp1l4dutw453****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8413252</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The stage of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>precheck</b>: the precheck stage.</description></item>
            /// <item><description><b>basebackup</b>: the basic backup stage.</description></item>
            /// <item><description><b>startup</b>: the startup stage.</description></item>
            /// <item><description><b>increment</b>: the incremental synchronization stage.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>increment</para>
            /// </summary>
            [NameInMap("TaskStage")]
            [Validation(Required=false)]
            public string TaskStage { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>failure</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>create</b>: creates a synchronization link.</description></item>
            /// <item><description><b>create-dryrun</b>: performs a precheck before a synchronization link is created.</description></item>
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

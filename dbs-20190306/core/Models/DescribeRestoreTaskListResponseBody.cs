// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backup schedule.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRestoreTaskListResponseBodyItems Items { get; set; }
        public class DescribeRestoreTaskListResponseBodyItems : TeaModel {
            [NameInMap("RestoreTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail> RestoreTaskDetail { get; set; }
            public class DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail : TeaModel {
                /// <summary>
                /// <para>The ID of the backup gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>324234332</para>
                /// </summary>
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public long? BackupGatewayId { get; set; }

                /// <summary>
                /// <para>The ID of the backup schedule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dbs1hvb0wXXXX</para>
                /// </summary>
                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                /// <summary>
                /// <para>The ID of the full backup set that is used in the restore task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1ibh2f5uXXX</para>
                /// </summary>
                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                /// <summary>
                /// <para>The restore progress of the incremental log files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ContinuousRestoreProgress")]
                [Validation(Required=false)]
                public int? ContinuousRestoreProgress { get; set; }

                /// <summary>
                /// <para>The unique ID (UID) of the Alibaba Cloud account to which the backup schedule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2xxx7778xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("CrossAliyunId")]
                [Validation(Required=false)]
                public string CrossAliyunId { get; set; }

                /// <summary>
                /// <para>The name of the RAM role that can be used to perform backups across Alibaba Cloud accounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("CrossRoleName")]
                [Validation(Required=false)]
                public string CrossRoleName { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DestinationEndpointDatabaseName")]
                [Validation(Required=false)]
                public string DestinationEndpointDatabaseName { get; set; }

                /// <summary>
                /// <para>The ID of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1p8c2947XXX</para>
                /// </summary>
                [NameInMap("DestinationEndpointInstanceID")]
                [Validation(Required=false)]
                public string DestinationEndpointInstanceID { get; set; }

                /// <summary>
                /// <para>The location of the database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RDS</description></item>
                /// <item><description>ECS</description></item>
                /// <item><description>Express: The database is connected to DBS by using Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
                /// <item><description>Agent: The database is connected to DBS over a DBS backup gateway.</description></item>
                /// <item><description>DDS: The database is an ApsaraDB for MongoDB database.</description></item>
                /// <item><description>Other: The database is connected to DBS by using the IP address and port of the database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("DestinationEndpointInstanceType")]
                [Validation(Required=false)]
                public string DestinationEndpointInstanceType { get; set; }

                /// <summary>
                /// <para>The endpoint that is used to connect to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.X.X.10:33204</para>
                /// </summary>
                [NameInMap("DestinationEndpointIpPort")]
                [Validation(Required=false)]
                public string DestinationEndpointIpPort { get; set; }

                /// <summary>
                /// <para>The SID of the Oracle database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DestinationEndpointOracleSID")]
                [Validation(Required=false)]
                public string DestinationEndpointOracleSID { get; set; }

                /// <summary>
                /// <para>The region in which the database is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("DestinationEndpointRegion")]
                [Validation(Required=false)]
                public string DestinationEndpointRegion { get; set; }

                /// <summary>
                /// <para>The username of the account that is used to connect to the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DestinationEndpointUserName")]
                [Validation(Required=false)]
                public string DestinationEndpointUserName { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NULL</para>
                /// </summary>
                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                /// <summary>
                /// <para>The restore progress of the full backup data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("FullDataRestoreProgress")]
                [Validation(Required=false)]
                public int? FullDataRestoreProgress { get; set; }

                /// <summary>
                /// <para>The progress of schema restore after full data restore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("FullStruAfterRestoreProgress")]
                [Validation(Required=false)]
                public int? FullStruAfterRestoreProgress { get; set; }

                /// <summary>
                /// <para>The progress of schema restore before full data restore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FullStruforeRestoreProgress")]
                [Validation(Required=false)]
                public int? FullStruforeRestoreProgress { get; set; }

                /// <summary>
                /// <para>The directory of the destination database to which the objects were restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.X.X.10:33204</para>
                /// </summary>
                [NameInMap("RestoreDir")]
                [Validation(Required=false)]
                public string RestoreDir { get; set; }

                /// <summary>
                /// <para>The objects to be restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[     {         \&quot;DBName\&quot;:\&quot;test\&quot;       } ]</para>
                /// </summary>
                [NameInMap("RestoreObjects")]
                [Validation(Required=false)]
                public string RestoreObjects { get; set; }

                /// <summary>
                /// <para>The status of the restore task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>init: The restore task is not started or does not pass the precheck.</description></item>
                /// <item><description>running: The restore task is running.</description></item>
                /// <item><description>stop: The restore task failed.</description></item>
                /// <item><description>pause: The restore task is stopped.</description></item>
                /// <item><description>check_pass: The restore task passed the precheck.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The time when the restore task was created, such as 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("RestoreTaskCreateTime")]
                [Validation(Required=false)]
                public long? RestoreTaskCreateTime { get; set; }

                /// <summary>
                /// <para>The time when the restore task was complete, such as 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("RestoreTaskFinishTime")]
                [Validation(Required=false)]
                public long? RestoreTaskFinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the restore task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s1XXXXXX</para>
                /// </summary>
                [NameInMap("RestoreTaskId")]
                [Validation(Required=false)]
                public string RestoreTaskId { get; set; }

                /// <summary>
                /// <para>The name of the restore task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("RestoreTaskName")]
                [Validation(Required=false)]
                public string RestoreTaskName { get; set; }

                /// <summary>
                /// <para>The time to run the restore task, such as 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("RestoreTime")]
                [Validation(Required=false)]
                public long? RestoreTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C397502-B4F2-4E22-AD97-C81F0049F3F3</para>
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
        /// <para>The total number of restore tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

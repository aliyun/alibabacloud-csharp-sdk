// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudbenchTaskResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information, including the error codes and the number of entries that are returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudbenchTaskResponseBodyData Data { get; set; }
        public class DescribeCloudbenchTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the archiving task.
            /// </summary>
            [NameInMap("ArchiveJobId")]
            [Validation(Required=false)]
            public string ArchiveJobId { get; set; }

            /// <summary>
            /// The name of the table that was archived to Object Storage Service (OSS).
            /// </summary>
            [NameInMap("ArchiveOssTableName")]
            [Validation(Required=false)]
            public string ArchiveOssTableName { get; set; }

            /// <summary>
            /// The archiving state of the file that stores the analysis result of full SQL statistics. Valid values:
            /// 
            /// *   **0**: The file archiving is not started.
            /// *   **1**: The file is archived.
            /// *   **2**: An error occurred.
            /// *   **3**: The file is being archived.
            /// *   **4**: The archived file does not need to be downloaded.
            /// </summary>
            [NameInMap("ArchiveState")]
            [Validation(Required=false)]
            public int? ArchiveState { get; set; }

            /// <summary>
            /// The ID of the backup set. You can call the [DescribeBackups](https://help.aliyun.com/document_detail/26273.html) operation to query the ID of the backup set.
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// The backup type. Valid values:
            /// 
            /// *   **TIMESTAMP**
            /// *   **BACKUPID**
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// The substep in the stress testing task. Valid values:
            /// 
            /// *   **NEW**: initializes the stress testing task.
            /// *   **WAIT_BUY_ECS**: purchases an ECS instance.
            /// *   **WAIT_START_ECS**: starts an ECS instance.
            /// *   **WAIT_INSTALL_JDK**: installs the Java Development Kit (JDK).
            /// *   **WAIT_INSTALL_DBGATEWAY**: installs the database gateway (DBGateway).
            /// *   **ADD_SECURITY_IPS_STEP**: configure a security group whitelist.
            /// *   **ARCHIVE**: archives the full SQL statistics.
            /// *   **DOWNLOAD**: downloads the file that stores the analysis result of full SQL statistics.
            /// *   **PROCEED**: preprocesses the file that stores the analysis result of full SQL statistics.
            /// *   **PRE_LOAD**: preloads the file that stores the analysis result of full SQL statistics.
            /// *   **VALIDATE**: verifies the functionality of stress testing.
            /// *   **PRESSURE**: starts the stress testing task.
            /// </summary>
            [NameInMap("BenchStep")]
            [Validation(Required=false)]
            public string BenchStep { get; set; }

            /// <summary>
            /// The status that indicates the substep performed on the stress testing task. Valid values:
            /// 
            /// *   **NEW**: The task is being initialized.
            /// *   **RUNNING**: The task is running.
            /// *   **FAILED**: The task failed.
            /// *   **FINISHED**: The task is complete.
            /// *   **Terminated**: The task is terminated.
            /// *   **Deleted**: The task is deleted.
            /// </summary>
            [NameInMap("BenchStepStatus")]
            [Validation(Required=false)]
            public string BenchStepStatus { get; set; }

            /// <summary>
            /// The DBGateway ID of the stress testing client.
            /// </summary>
            [NameInMap("ClientGatewayId")]
            [Validation(Required=false)]
            public string ClientGatewayId { get; set; }

            /// <summary>
            /// The type of the stress testing client. Valid values:
            /// 
            /// *   **ECS**: indicates that you must create the [DBGateway](https://help.aliyun.com/document_detail/64905.html).
            /// *   **DAS_ECS**: indicates that DAS automatically purchases and deploys an ECS instance for stress testing.
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// The description of the stress testing task.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The UUID of the destination instance.
            /// </summary>
            [NameInMap("DstInstanceUuid")]
            [Validation(Required=false)]
            public string DstInstanceUuid { get; set; }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// The port number of the destination instance.
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// The type of the identifier that is used to indicate the destination instance. Valid values:
            /// 
            /// *   **Instance** (default): the instance ID.
            /// *   **ConnectionString**: the endpoint of the instance.
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public string DstType { get; set; }

            /// <summary>
            /// The specification of the DTS task.
            /// </summary>
            [NameInMap("DtsJobClass")]
            [Validation(Required=false)]
            public string DtsJobClass { get; set; }

            /// <summary>
            /// The ID of the DTS migration task.
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// The name of the Data Transmission Service (DTS) task.
            /// </summary>
            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            /// <summary>
            /// The state of the DTS task. Valid values:
            /// 
            /// *   **NOT_STARTED**: The task is not started.
            /// *   **PRE_CHECKING**: The task is in precheck.
            /// *   **PRE_CHECK_FAILED**: The precheck failed.
            /// *   **CHECKING**: The task is being checked.
            /// *   **MIGRATING**: The data is being migrated.
            /// *   **CATCHED**: The data is migrated from the source instance to the destination instance.
            /// *   **SUSPENDING**: The task is suspended.
            /// *   **MIGRATION_FAILED**: The data failed to be migrated.
            /// *   **FINISHED**: The task is complete.
            /// *   **INITIALIZING**: The synchronization is being initialized.
            /// *   **INITIALIZE_FAILED**: The synchronization failed to be initialized.
            /// *   **SYNCHRONIZING**: The data is being synchronized.
            /// *   **MODIFYING**: The objects to be synchronized are being changed.
            /// *   **SWITCHING**: The roles of the instances are being switched.
            /// *   **FAILED**: The task failed.
            /// </summary>
            [NameInMap("DtsJobState")]
            [Validation(Required=false)]
            public int? DtsJobState { get; set; }

            /// <summary>
            /// The state of the DTS task. Valid values:
            /// 
            /// *   **NOT_STARTED**: The task is not started.
            /// *   **PRE_CHECKING**: The task is in precheck.
            /// *   **PRE_CHECK_FAILED**: The precheck failed.
            /// *   **CHECKING**: The task is being checked.
            /// *   **MIGRATING**: The data is being migrated.
            /// *   **CATCHED**: The data is migrated from the source instance to the destination instance.
            /// *   **SUSPENDING**: The task is suspended.
            /// *   **MIGRATION_FAILED**: The data failed to be migrated.
            /// *   **FINISHED**: The task is complete.
            /// *   **INITIALIZING**: The synchronization is being initialized.
            /// *   **INITIALIZE_FAILED**: The synchronization failed to be initialized.
            /// *   **SYNCHRONIZING**: The data is being synchronized.
            /// *   **MODIFYING**: The objects to be synchronized are being changed.
            /// *   **SWITCHING**: The roles of the instances are being switched.
            /// *   **FAILED**: The task failed.
            /// </summary>
            [NameInMap("DtsJobStatus")]
            [Validation(Required=false)]
            public string DtsJobStatus { get; set; }

            /// <summary>
            /// The ID of the Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The state that specifies the last operation that is performed for the stress testing task. Valid values:
            /// 
            /// *   **WAIT_TARGET**: prepares the destination instance.
            /// *   **WAIT_DBGATEWAY**: prepares the DBGateway.
            /// *   **WAIT_SQL**: prepares the full SQL statistics.
            /// *   **WAIT_LOGIC**: prepares to replay the traffic.
            /// 
            /// >  When the state of a stress testing task changes to the state that is specified by the EndState parameter, the stress testing task becomes completed.
            /// </summary>
            [NameInMap("EndState")]
            [Validation(Required=false)]
            public string EndState { get; set; }

            /// <summary>
            /// The error code returned for the substep of the stress testing task.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message returned if the request failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public string External { get; set; }

            /// <summary>
            /// The rate at which the stress testing task replayed the traffic. The value is a positive integer. Valid values:**1** to **30**. Default value: **1**.
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public long? Rate { get; set; }

            /// <summary>
            /// The duration of the stress testing task for which traffic was captured from the source instance.
            /// </summary>
            [NameInMap("RequestDuration")]
            [Validation(Required=false)]
            public long? RequestDuration { get; set; }

            /// <summary>
            /// The duration of the stress testing task for which the traffic was generated on the destination instance. Unit: milliseconds.
            /// </summary>
            [NameInMap("SmartPressureTime")]
            [Validation(Required=false)]
            public int? SmartPressureTime { get; set; }

            /// <summary>
            /// The source of the task. Valid values:
            /// 
            /// *   **DAS**
            /// *   **OPEN_API**
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The reuse information about the analysis result of full SQL statistics.
            /// </summary>
            [NameInMap("SqlCompleteReuse")]
            [Validation(Required=false)]
            public string SqlCompleteReuse { get; set; }

            /// <summary>
            /// The database type of the source instance. Valid values:
            /// </summary>
            [NameInMap("SrcInstanceArea")]
            [Validation(Required=false)]
            public string SrcInstanceArea { get; set; }

            /// <summary>
            /// The UUID of the source instance.
            /// </summary>
            [NameInMap("SrcInstanceUuid")]
            [Validation(Required=false)]
            public string SrcInstanceUuid { get; set; }

            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("SrcPublicIp")]
            [Validation(Required=false)]
            public string SrcPublicIp { get; set; }

            /// <summary>
            /// The state that indicates the operation performed for the stress testing task. Valid values:
            /// 
            /// *   **WAIT_TARGET**: prepares the destination instance.
            /// *   **WAIT_DBGATEWAY**: prepares the DBGateway.
            /// *   **WAIT_SQL**: prepares the full SQL statistics.
            /// *   **WAIT_LOGIC**: prepares to replay the traffic.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The state of the stress testing task. Valid values:
            /// 
            /// *   **SUCCESS**: The task is successful.
            /// *   **IGNORED**: The task is ignored.
            /// *   **RUNNING**: The task is running.
            /// *   **EXCEPTION**: An error occurred.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the table that is used for stress testing.
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of the stress testing task. Valid values:
            /// 
            /// *   **pressure test** (default): A task of this type replays the traffic that is captured from the source instance on the destination instance at the maximum playback rate that is supported by the destination instance.
            /// *   **smart pressure test**: A task of this type analyzes the traffic that is captured from the source instance over a short period of time and generates traffic on the destination instance for continuous stress testing. The business model based on which the traffic is generated on the destination instance and the traffic distribution are consistent with those on the source instance. Stress testing tasks of this type can help you reduce the amount of time that is consumed to collect data from the source instance and reduce storage costs and performance overheads.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// The topic that contains the consumed data. This topic is a topic in Message Queue for Apache Kafka.
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The version of the stress testing task. Valid values:
            /// 
            /// *   **V2.0**
            /// *   **V3.0**
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The temporary directory generated for stress testing.
            /// </summary>
            [NameInMap("WorkDir")]
            [Validation(Required=false)]
            public string WorkDir { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

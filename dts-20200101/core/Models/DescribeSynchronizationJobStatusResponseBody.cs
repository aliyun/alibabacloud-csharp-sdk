// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// The UNIX timestamp generated when the latest data record was synchronized.
        /// 
        /// >  You can use a search engine to obtain a UNIX timestamp converter.
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// Indicates whether full data synchronization is performed. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public string DataInitialization { get; set; }

        /// <summary>
        /// The status of full data synchronization.
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if full data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of full data synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of records that have been synchronized during full data synchronization.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of full data synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Full data synchronization is not started.
            /// *   **Migrating**: Full data synchronization is in progress.
            /// *   **Failed**: Full data synchronization failed.
            /// *   **Finished**: Full data synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The status of incremental data synchronization.
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// The UNIX timestamp generated when the latest data record was synchronized.
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// The synchronization latency, in seconds.
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// The synchronization latency, in milliseconds.
            /// </summary>
            [NameInMap("DelayMillis")]
            [Validation(Required=false)]
            public long? DelayMillis { get; set; }

            /// <summary>
            /// The error message returned if incremental data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of incremental data synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The status of incremental data synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Incremental data synchronization is not started.
            /// *   **Migrating**: Incremental data synchronization is in progress.
            /// *   **Failed**: Incremental data synchronization failed.
            /// *   **Finished**: Incremental data synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The synchronization latency, in seconds.
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public string Delay { get; set; }

        /// <summary>
        /// The synchronization delay, in milliseconds.
        /// </summary>
        [NameInMap("DelayMillis")]
        [Validation(Required=false)]
        public long? DelayMillis { get; set; }

        /// <summary>
        /// The connection settings of the destination instance.
        /// </summary>
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint : TeaModel {
            /// <summary>
            /// The database type of the destination instance.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the destination instance.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the destination instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The database service port of the destination instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The database account of the destination instance.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The error message returned if data synchronization failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The time when the data synchronization instance expires. The time is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format in UTC.
        /// 
        /// >  This parameter is returned only if the return value of the **PayType** parameter is **PrePaid**.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// The billing method of the data synchronization instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The performance of the data synchronization instance.
        /// </summary>
        [NameInMap("Performance")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPerformance Performance { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPerformance : TeaModel {
            /// <summary>
            /// The data traffic that is synchronized per second. Unit: MB/s.
            /// </summary>
            [NameInMap("FLOW")]
            [Validation(Required=false)]
            public string FLOW { get; set; }

            /// <summary>
            /// The number of times SQL statements are synchronized per second, including BEGIN, COMMIT, DML, and DDL statements. DML statements include INSERT, DELETE, and UPDATE.
            /// </summary>
            [NameInMap("RPS")]
            [Validation(Required=false)]
            public string RPS { get; set; }

        }

        /// <summary>
        /// The precheck status.
        /// </summary>
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// The result of each precheck item.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
                /// <summary>
                /// The precheck result. Valid values:
                /// 
                /// *   **Success**: The task passed the precheck.
                /// *   **Failed**: The task failed to pass the precheck.
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// The error message returned if the task failed to pass the precheck.
                /// 
                /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is **Failed**.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the precheck item.
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// The method to fix the precheck failure.
                /// 
                /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is **Failed**.
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

            }

            /// <summary>
            /// The precheck progress. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The precheck result. Valid values:
            /// 
            /// *   **Success**: The task passed the precheck.
            /// *   **Failed**: The task failed to pass the precheck.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The connection settings of the source instance.
        /// </summary>
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySourceEndpoint : TeaModel {
            /// <summary>
            /// The database type of the source instance.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the source instance.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the source instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the source instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The database service port of the source instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The database account of the source instance.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The status of the data synchronization task. Valid values:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **Initializing**: The task is performing initial synchronization.
        /// *   **InitializeFailed**: Initial synchronization failed.
        /// *   **Synchronizing**: The task is synchronizing data.
        /// *   **Failed**: The task failed to synchronize data.
        /// *   **Suspending**: The task is paused.
        /// *   **Modifying**: The objects in the task are being modified.
        /// *   **Finished**: The task is completed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether schema synchronization is performed. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public string StructureInitialization { get; set; }

        /// <summary>
        /// The status of schema synchronization.
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if schema synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of schema synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of tables whose schemas have been synchronized.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of schema synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Schema synchronization is not started.
            /// *   **Migrating**: Schema synchronization is in progress.
            /// *   **Failed**: Schema synchronization failed.
            /// *   **Finished**: Schema synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**
        /// *   **Reverse**
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// The specification of the data synchronization instance.
        /// </summary>
        [NameInMap("SynchronizationJobClass")]
        [Validation(Required=false)]
        public string SynchronizationJobClass { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance.
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// The name of the data synchronization task.
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        /// <summary>
        /// The objects that are synchronized by the task.
        /// </summary>
        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjects> SynchronizationObjects { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjects : TeaModel {
            /// <summary>
            /// The database name that is used in the destination instance.
            /// </summary>
            [NameInMap("NewSchemaName")]
            [Validation(Required=false)]
            public string NewSchemaName { get; set; }

            /// <summary>
            /// The name of the synchronized database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The source tables that are excluded from the data synchronization task.
            /// </summary>
            [NameInMap("TableExcludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes> TableExcludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes : TeaModel {
                /// <summary>
                /// The name of the excluded table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The tables that are synchronized by the task.
            /// </summary>
            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes> TableIncludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes : TeaModel {
                /// <summary>
                /// The name of the synchronized table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

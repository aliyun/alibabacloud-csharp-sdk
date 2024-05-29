// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusResponseBody : TeaModel {
        [NameInMap("AnalysisJobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyAnalysisJobProgress> AnalysisJobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyAnalysisJobProgress : TeaModel {
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyAnalysisJobProgressLogs : TeaModel {
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The task code that indicates the subtask type. Valid values:
        /// 
        /// *   **01**: precheck
        /// *   **02**: schema migration or initial schema synchronization
        /// *   **03**: full data migration or initial full data synchronization
        /// *   **04**: incremental data migration or synchronization
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorAnalysisItem")]
        [Validation(Required=false)]
        public int? ErrorAnalysisItem { get; set; }

        /// <summary>
        /// The total number of subtask failures.
        /// </summary>
        [NameInMap("ErrorItem")]
        [Validation(Required=false)]
        public int? ErrorItem { get; set; }

        [NameInMap("FullNetCheckJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatus> FullNetCheckJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatus : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestRegionCidr")]
            [Validation(Required=false)]
            public string DestRegionCidr { get; set; }

            [NameInMap("DestinationEndpointType")]
            [Validation(Required=false)]
            public string DestinationEndpointType { get; set; }

            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            [NameInMap("HostRegion")]
            [Validation(Required=false)]
            public string HostRegion { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgress : TeaModel {
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodyFullNetCheckJobStatusJobProgressLogs : TeaModel {
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            [NameInMap("SourceEndpointType")]
            [Validation(Required=false)]
            public string SourceEndpointType { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcRegionCidr")]
            [Validation(Required=false)]
            public string SrcRegionCidr { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the data migration or synchronization task.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The name of the subtask.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The list of subtasks and the progress of each subtask.
        /// </summary>
        [NameInMap("JobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyJobProgress> JobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyJobProgress : TeaModel {
            /// <summary>
            /// The time when the subtask was started. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.
            /// </summary>
            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            /// <summary>
            /// Indicates whether the subtask can be ignored if it fails.
            /// </summary>
            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            /// <summary>
            /// The number of the subtasks that are running.
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public string Current { get; set; }

            /// <summary>
            /// The DDL statements.
            /// </summary>
            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            /// <summary>
            /// The latency of incremental data migration or synchronization.
            /// 
            /// >  For data migration tasks, the unit of this parameter is milliseconds. For data synchronization tasks, the unit of this parameter is seconds.
            /// </summary>
            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            /// <summary>
            /// The name of the database to which the object in the destination instance belongs.
            /// </summary>
            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            /// <summary>
            /// This parameter will be removed in the future.
            /// </summary>
            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            /// <summary>
            /// The error details of the subtask failure.
            /// </summary>
            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            /// <summary>
            /// The error message of the subtask failure.
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// The time when the subtask was complete. The time is displayed in the yyyy-MM-ddTHH:mm:ssZ format in UTC.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The ID recorded in the metadatabase.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// Indicates whether DTS ignores the subtask and proceeds with the next subtask. Valid values:
            /// 
            /// *   **N**: no
            /// *   **Y**: yes
            /// </summary>
            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            /// <summary>
            /// The shortened name of the subtask.
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// The ID of the subtask.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The logs of subtask failures.
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyJobProgressLogs : TeaModel {
                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                /// <summary>
                /// The error message returned when an error occurs on the subtask.
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// The error type.
                /// </summary>
                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

                /// <summary>
                /// The level of logs.
                /// </summary>
                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

            }

            /// <summary>
            /// The name of the subtask.
            /// </summary>
            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            /// <summary>
            /// The serial number of the subtask.
            /// </summary>
            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            /// <summary>
            /// This parameter will be removed in the future.
            /// </summary>
            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            /// <summary>
            /// The method to fix the subtask failure.
            /// </summary>
            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            /// <summary>
            /// Indicates whether the subtask is ignored if it fails. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The name of the database to which the object in the source instance belongs.
            /// </summary>
            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            /// <summary>
            /// The status of the subtask. Valid values:
            /// 
            /// *   **NotStarted**: The subtask is not started.
            /// *   **Checking**: The subtask is being checked.
            /// *   **Migrating**: The subtask is in progress. Data is being migrated.
            /// *   **Failed**: The subtask failed.
            /// *   **Warning**: The subtask encounters an exception.
            /// *   **Success**: The subtask is complete.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The sub-item progress of the subtask.
            /// 
            /// >  If **[]** is returned, the subtask has no sub-items.
            /// </summary>
            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            /// <summary>
            /// The names of the objects that are migrated or synchronized.
            /// </summary>
            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            /// <summary>
            /// The total number of subtasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("NetworkDiagnosisResult")]
        [Validation(Required=false)]
        public DescribePreCheckStatusResponseBodyNetworkDiagnosisResult NetworkDiagnosisResult { get; set; }
        public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResult : TeaModel {
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis> Diagnosis { get; set; }
            public class DescribePreCheckStatusResponseBodyNetworkDiagnosisResultDiagnosis : TeaModel {
                [NameInMap("CnDocUrl")]
                [Validation(Required=false)]
                public string CnDocUrl { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                [NameInMap("InternationalDocUrl")]
                [Validation(Required=false)]
                public string InternationalDocUrl { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            [NameInMap("ModelVersion")]
            [Validation(Required=false)]
            public string ModelVersion { get; set; }

        }

        /// <summary>
        /// The number of the page returned. The value is an integer that is greater than **0** and does not exceed the maximum value of the Integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the subtask. Valid values:
        /// 
        /// *   **NotStarted**: The subtask is not started.
        /// *   **Suspending**: The subtask is paused.
        /// *   **Checking**: The subtask is being checked.
        /// *   **Migrating**: The subtask is in progress. Data is being migrated.
        /// *   **Failed**: The subtask failed.
        /// *   **Catched**: The subtask is in progress. Incremental data is being migrated or synchronized.
        /// *   **Finished**: The subtask is complete.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The state of the distributed subtask.
        /// </summary>
        [NameInMap("SubDistributedJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodySubDistributedJobStatus> SubDistributedJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodySubDistributedJobStatus : TeaModel {
            /// <summary>
            /// The task code that indicates the subtask type. Valid values:
            /// 
            /// *   **01**: precheck
            /// *   **02**: schema migration or initial schema synchronization
            /// *   **03**: full data migration or initial full data synchronization
            /// *   **04**: incremental data migration or synchronization
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The number of subtasks that failed.
            /// </summary>
            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            /// <summary>
            /// The ID of the subtask.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The name of distributed subtasks associated with the subtask.
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// The list of subtasks and the progress of each subtask.
            /// </summary>
            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress : TeaModel {
                /// <summary>
                /// The time when the subtask was started. The time is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format in UTC.
                /// </summary>
                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                /// <summary>
                /// Indicates whether the subtask can be ignored if it fails. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// The number of the subtasks that are running.
                /// </summary>
                [NameInMap("Current")]
                [Validation(Required=false)]
                public string Current { get; set; }

                /// <summary>
                /// The DDL statements.
                /// </summary>
                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                /// <summary>
                /// The latency of incremental data migration or synchronization.
                /// </summary>
                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                /// <summary>
                /// The name of the database to which the object in the destination instance belongs.
                /// </summary>
                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                /// <summary>
                /// This parameter will be removed in the future.
                /// </summary>
                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                /// <summary>
                /// The error details of the subtask failure.
                /// </summary>
                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                /// <summary>
                /// The error message of the subtask failure.
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// The time when the instance was created. The time is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format in UTC.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The ID of the entry in the metadatabase.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Indicates whether DTS ignores the subtask and proceeds with the next subtask. Valid values:
                /// 
                /// *   **N**: no
                /// *   **Y**: yes
                /// </summary>
                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                /// <summary>
                /// The name of the subtask.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                /// <summary>
                /// The ID of the subtask.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The operations logs of errors.
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs : TeaModel {
                    /// <summary>
                    /// The record of errors.
                    /// </summary>
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    /// <summary>
                    /// The error type.
                    /// </summary>
                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                    /// <summary>
                    /// The level of logs.
                    /// </summary>
                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                }

                /// <summary>
                /// The name of the subtask.
                /// </summary>
                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                /// <summary>
                /// The serial number of the subtask.
                /// </summary>
                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                /// <summary>
                /// This parameter will be removed in the future.
                /// </summary>
                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                /// <summary>
                /// The method used to fix a precheck failure.
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                /// <summary>
                /// Indicates whether the subtask was skipped. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// The name of the database to which the object in the source instance belongs.
                /// </summary>
                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// The status of the subtask. Valid values:
                /// 
                /// *   **NotStarted**: The subtask is not started.
                /// *   **Suspending**: The subtask is paused.
                /// *   **Checking**: The subtask is being checked.
                /// *   **Migrating**: The subtask is in progress. Data is being migrated.
                /// *   **Failed**: The subtask failed.
                /// *   **Catched**: The subtask is in progress. Incremental data is being migrated or synchronized.
                /// *   **Finished**: The subtask is complete.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The sub-item progress of the subtask.
                /// 
                /// >  If **[]** is returned, the subtask has no sub-items.
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                /// <summary>
                /// The names of the objects that are migrated or synchronized.
                /// </summary>
                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                /// <summary>
                /// The total number of subtasks.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// The status of the subtask. Valid values:
            /// 
            /// *   **NotStarted**: The subtask is not started.
            /// *   **Suspending**: The subtask is paused.
            /// *   **Checking**: The subtask is being checked.
            /// *   **Migrating**: The subtask is in progress. Data is being migrated.
            /// *   **Failed**: The subtask failed.
            /// *   **Catched**: The subtask is in progress. Incremental data is being migrated or synchronized.
            /// *   **Finished**: The subtask is complete.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of subtasks.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// The total number of returned records.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOmsOpenAPIProjectStepsResponseBody : TeaModel {
        /// <summary>
        /// The suggestions (old).
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// The error code (old).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time spent in processing the request, in seconds.
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        /// <summary>
        /// The business data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOmsOpenAPIProjectStepsResponseBodyData> Data { get; set; }
        public class DescribeOmsOpenAPIProjectStepsResponseBodyData : TeaModel {
            /// <summary>
            /// The estimated time remained.
            /// </summary>
            [NameInMap("EstimatedRemainingSeconds")]
            [Validation(Required=false)]
            public long? EstimatedRemainingSeconds { get; set; }

            /// <summary>
            /// The additional information. The value is a JSON string.
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfo : TeaModel {
                /// <summary>
                /// The error code, such as AUTHENTICATION_ERROR, PARAM_ERROR, PARAM_ERROR_MESSAGE, NOT_IMPLEMENTED_ERROR, SHARD_COLUMNS_CONFLICT_MESSAGE, FAILED_PARSE_TOKEN_MESSAGE, CONNECT_CHECK_ERROR, NOT_SUPPORT_ERROR, CE_NOT_SUPPORT_ERROR, NOT_FOUND_ERROR, SHARDING_COLUMN_NOT_INCLUDED_ERROR, INNER_ERROR, DB_QUERY_ERROR, DATAHUB_QUERY_ERROR, USER_LACK_SYS_PRIV_ERROR, USER_LACK_TABLE_PRIV_ERROR, RM_API_ERROR, RM_TASK_ERROR, CM_API_ERROR, CM_API_NOT_SUCCESS, BAGUALU_API_ERROR, IDB_API_ERROR, SUPERVISOR_API_ERROR, OCP_API_ERROR, OCP_SERVICE_ERROR, OCP_QUERY_VERSION_FAILED, OCP_VERSION_INCORRECT_ERROR, OCP_VERSION_NOT_SUPPORTED_ERROR, OCP_API_USER_PASSWORD_INCORRECT_ERROR, OBSCHEMA_ERROR, EXECUTOR_THREAD_POOL_BUSY, NO_TABLE_SELECTED, NO_VIEW_SELECTED, SOURCE_CRAWLER_START_FAILED, SOURCE_CRAWLER_START_FAILED_DATA_EXPIRED, SOURCE_CRAWLER_START_TIMEOUT, DEST_WRITER_START_FAILED, WRITER_UNKNOWN_STATUS, DRC_TOPIC_EXISTS_ERROR, TOPIC_EMPTY_ERROR, REACH_WRITER_LIMIT_ERROR, FOUND_NO_FEASIBLE_STORE_ERROR, TOO_MANY_STORES_FOR_SUBTOPIC, TIMEOUT_EXCEPTION, KIPP_API_ERROR, KIPP_API_RESOURCE_NOT_FOUND, KIPP_API_INVALID_PARAM, KIPP_API_UNKNOWN_ERROR, KIPP_API_INTERNAL_ERROR, KIPP_API_SERVICE_UNAVAILABLE, OMS_AGENT_API_ERROR, KMS_API_ERROR, OMS_ENCRYPT_API_ERROR, OMS_DECRYPT_API_ERROR, ALIYUN_SDK_ERROR, YAOCHI_API_ERROR, RESOURCE_WITHOUT_STOCK_ERROR, RESOURCE_NO_AVAILABLE_ZONE, CM_SDK_ERROR, MIGRATION_PROJECT_STEP_PRECHECK_FAILED, PRE_CHECK_ERROR, FAILURES_CORRECT_ERROR, EXECUTE_DDL_FAILURE, EXECUTE_DDL_UNSUPPORTED_OR_FAILURE, STRUCT_RECORD_DDL_NOT_FOUND, STRUCT_RECORD_INDEX_NOT_FOUND, STRUCT_RECORD_NOT_FOUND, STRUCT_RECORD_NOT_FOUND_IN_DBCAT, SCHEMA_OBJECT_TYPE_NOT_SUPPORT_ERROR, POLAR_MYSQL_NETWORK_TYPE_NOT_SUPPORT_ERROR, RDS_NETWORK_TYPE_NOT_SUPPORT_ERROR, RDS_VPC_NETWORK_NOT_SUPPORT_ERROR, DB_TYPE_NOT_SUPPORT_ERROR, SYNC_TYPE_NOT_SUPPORT_ERROR, SLAVE_OPERATION_STEP_NOT_SUPPORT_ERROR, BYTE_USED_TYPE_NOT_SUPPORT_ERROR, MANY_TO_ONE_SCHEMA_TABLE_REVERSE_INCR_NOT_SUPPORT_ERROR, DUPLICATE_SCHEMA_TABLE_ERROR, OMS_STEP_NOT_SUPPORT_ERROR, ORACLE_DATABASE_ROLE_NOT_SUPPORT_ERROR, OLD_PRE_CHECK_NOT_SUPPORT_ERROR, SCHEMA_ONE_TO_MANY_NOT_SUPPORT_ERROR, PROJECT_NOT_FOUND_ERROR, ENDPOINT_NOT_FOUND_ERROR, ENDPOINT_NAME_ALREADY_EXIST_ERROR, ENDPOINT_QUERY_ERROR, ENDPOINT_SQL_QUERY_ERROR, PROJECT_NAME_ALREADY_EXIST_ERROR, CHECKER_NOT_FOUND_ERROR, CHECKER_FAILED_ERROR, CHECKER_STATUS_UNEXPECTED_ERROR, CHECKER_NO_TASK_TYPE_ERROR, WORKER_INSTANCE_NOT_FOUND_ERROR, WORKER_INSTANCE_ALLOCATING_ERROR, LOG_SERVICE_TOPIC_NOT_FOUND_ERROR, CLUSTER_NOT_FOUND_ERROR, TENANT_NOT_FOUND_ERROR, DATABASE_NOT_FOUND_ERROR, TABLE_NOT_FOUND_ERROR, COLUMN_NOT_FOUND_ERROR, TABLE_META_NOT_FOUND_ERROR, SYBASE_CHARSET_NOT_FOUND_ERROR, OCP_NOT_FOUND_ERROR, REGION_NOT_FOUND_ERROR, OCP_ALREADY_EXIST_ERROR, ALARM_CHANNEL_NAME_ALREADY_EXIST_ERROR, SEND_MARKDOWN_TEXT_TO_WEBHOOK_FAILED_EXCEPTION_RESPONSE, SEND_MARKDOWN_TEXT_TO_WEBHOOK_FAILED_EXCEPTION_STATUS, LABEL_ALREADY_EXIST_ERROR, LABEL_NOT_EXIST_ERROR, OCP_ALREADY_USED_ERROR, REGION_INFO_INCONSISTENT_ERROR, OCP_NAME_EMPTY_ERROR, MASTER_SLAVE_ENDPOINT_NAME_INCONSISTENT_ERROR, LOG_FILE_NOT_FOUND_ERROR, OPERATION_NOT_ALLOWED_ERROR, PROJECT_OPERATION_NOT_ALLOWED_ERROR, PROJECT_RELEASE_FAILED, STRUCT_MIGRATION_RETRY_NOT_ALLOWED_ERROR, WORKER_INSTANCE_OPERATION_NOT_ALLOWED_ERROR, USER_OPERATION_NOT_ALLOWED_ERROR, OCP_NAME_OR_REGION_NOT_ALLOWED_UPDATE, UPDATE_CONFIG_WITH_NEWLINE_NOT_ALLOWED, EXIST_UNRELEASED_PROJECT_ERROR, EXIST_UNRELEASED_TOPIC_ERROR, LABEL_CREATE_NOT_ALLOWED_ERROR, LABEL_UPDATE_NOT_ALLOWED_ERROR, LABEL_DELETE_NOT_ALLOWED_ERROR, TOPIC_NAME_INVALID_ERROR, INVALID_STATUS_ERROR, INVALID_CSV_HEAD_ERROR, INVALID_CSV_BODY_ERROR, DUPLICATE_SCHEMA_TABLE_SETTING_ERROR, PROJECT_INVALID_STATUS_ERROR, PROJECT_INVALID_CONNECTOR_COUNT_ERROR, WORKER_INSTANCE_INVALID_STATUS_ERROR, LOG_SERVICE_INVALID_STATUS_ERROR, STEP_INVALID_STATUS_ERROR, UPDATE_ALLOW_DEST_TABLE_NOT_EMPTY_NOT_ALLOWED_ERROR, EXIST_INCONSISTENCY_ERROR, OMS_SWITCH_SUBSTEP_FAILED_ERROR, ENDPOINT_ID_INVALID_ERROR, DB_QUERY_VERSION_EMPTY_ERROR, ENDPOINT_NAME_INVALID_ERROR, ENDPOINT_SCHEMA_NOT_ALLOWED_ERROR, ENDPOINT_SCHEMA_CHAR_NOT_ALLOWED_ERROR, NAME_HAS_SPACE_EXCEPTION, CONFIG_CONVERT_VALUE_ERROR, CONFIG_VALUE_EXCEEDS_LIMIT_ERROR, CONFIG_KEY_NOT_FOUND_KEY_ERROR, CONFIG_VALUE_NOT_EMPTY_ERROR, SCHEMA_HAS_CONVERT_INFO, TIME_SERIES_QUERY_SERVICE_ERROR, ETL_VERIFY_ERROR, ETL_SYNTAX_UNSUPPORTED, ETL_FIELD_NOTFOUND, ETL_FAILED_PARSE_SQL, ETL_VAL_TYPE_ERROR, NOT_SUPPORT_GENERATE_COLUMNS, NOT_SUPPORT_UPDATE_ETL, LOCK_FAILED, OMS_USER_EXIST_ERROR, OMS_USER_NOT_FOUND_ERROR, OMS_USER_NAME_LENGTH_CONSTRAINT, OMS_USER_PASSWORD_ERROR, USER_NAME_OR_PASSWORD_ERROR, OMS_USER_PASSWORD_VALIDATION_ERROR, OMS_USER_PASSWORD_DEFAULT_ERROR, OMS_USER_PERMISSION_DENIED_ERROR, OMS_USER_EDIT_ADMIN_ROLE_INFO_PERMISSION_DENIED_ERROR, OMS_USER_ILLEGAL_DELETED_ERROR, CONNECTOR_TASK_NOT_FOUND_ERROR, CONNECTOR_TASK_NUM_LIMIT_ERROR, CONNECTOR_TASK_DELETE_ERROR, METRIC_SERVICE_ERROR, SYNC_PROJECT_TYPE_INVALID_ERROR, SYNC_SHARDING_COLUMNS_INVALID_ERROR, SYNC_PROJECT_PRODUCER_GROUP_INVALID_ERROR, SYNC_PROJECT_PRODUCER_GROUP_LIMIT_EXCEEDS_ERROR, SYNC_PROJECT_COMPLEMENT_CONFIG_ERROR, META_SCHEMA_CREATE_FAILED, RESUME_STEP_FAILED, SCHEMA_INCONSISTENCY, SCHEMA_CASCADE_MAPPING_NOT_SUPPORT_ERROR, SCHEMA_NOT_EXISTED, SCHEMA_EXISTED, SCHEMA_NOT_EXIST, BLACK_LIST_MATCH_ALL, BLACK_LIST_CONTAIN_NON_WHITE_SCHEMA, BLACK_WHITE_LIST_PARAM_INVALID_ERROR, OPERATOR_ERROR, OPERATOR_DIMENSION_NOT_SUPPORT, OPERATOR_PULL_LOG_ERROR, OPERATOR_UPDATE_CONFIG_NOT_SUPPORT, KAFKA_CREATE_TOPIC_ERROR, KAFKA_QUERY_TOPIC_ERROR, KAFKA_BUILD_PROPERTIES_ERROR, ROCKETMQ_CREATE_TOPIC_ERROR, ROCKETMQ_QUERY_TOPIC_ERROR, SYNC_OBJECT_EMPTY_ERROR, WRITER_NUMBER_NOT_UNIQUE, WRITER_NOT_ACTIVE, PROJECT_NAME_DUPLICATE_ERROR, EMPTY_FAILED_STRUCT_MIGRATION_TABLES_ERROR, LOGIC_TABLE_NOT_SUPPORT_UPDATE_OBJECT_ERROR, LOGIC_REQUEST_ERROR, LOGIC_DTO_BUILD_ERROR, UNEXPECTED_REMOTE_API_RESULT, OCEANBASE_USER_UNEXPECTED, STORE_CREATE_FAILED_ERROR, STORE_START_FAILED, STORE_NOT_PULL_LOG_ERROR, ALL_HOSTS_STATUS_ERROR, WORKER_ECS_NOT_FOUND_ERROR, WORKER_ECS_NOT_FOUND_FOR_USER_ERROR, WORKER_POD_NOT_FOUND_ERROR, WORKER_POD_NOT_FOUND_FOR_USER_ERROR, WORKER_INSTANCE_NOT_FOUND_ERROR_V2, and WORKER_INSTANCE_NOT_FOUND_FOR_USER_ERROR.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The error details.
                /// </summary>
                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfoErrorDetails> ErrorDetails { get; set; }
                public class DescribeOmsOpenAPIProjectStepsResponseBodyDataExtraInfoErrorDetails : TeaModel {
                    /// <summary>
                    /// The error code.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// Valid values: CRITICAL, ERROR, and WARN.
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// The suggestions.
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// The error related parameters.
                /// </summary>
                [NameInMap("ErrorParam")]
                [Validation(Required=false)]
                public Dictionary<string, string> ErrorParam { get; set; }

                /// <summary>
                /// The time when the error occurred.
                /// </summary>
                [NameInMap("FailedTime")]
                [Validation(Required=false)]
                public string FailedTime { get; set; }

            }

            /// <summary>
            /// The end time, in the format of "2020-05-22T17:04:18".
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// Indicates whether the current step must be confirmed by the user, rather than scheduled in the backend.
            /// </summary>
            [NameInMap("Interactive")]
            [Validation(Required=false)]
            public bool? Interactive { get; set; }

            /// <summary>
            /// The start time, in the format of "2020-05-22T17:04:18".
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The description of the step, for example, schema migration, full migration, full verification, incremental log pull, incremental synchronization, or incremental verification.
            /// </summary>
            [NameInMap("StepDescription")]
            [Validation(Required=false)]
            public string StepDescription { get; set; }

            /// <summary>
            /// The step details. The value is a JSON string.
            /// </summary>
            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfo StepInfo { get; set; }
            public class DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfo : TeaModel {
                /// <summary>
                /// The estimated total number of rows.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// The checkpoint. The value is a unix timestamp in seconds.
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// The full synchronization progress.
                /// </summary>
                [NameInMap("ConnectorFullProgressOverview")]
                [Validation(Required=false)]
                public DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfoConnectorFullProgressOverview ConnectorFullProgressOverview { get; set; }
                public class DescribeOmsOpenAPIProjectStepsResponseBodyDataStepInfoConnectorFullProgressOverview : TeaModel {
                    /// <summary>
                    /// The estimated maximum time remained, in seconds.
                    /// </summary>
                    [NameInMap("EstimatedRemainingTimeOfSec")]
                    [Validation(Required=false)]
                    public long? EstimatedRemainingTimeOfSec { get; set; }

                    /// <summary>
                    /// The estimated amount of data to migrate.
                    /// </summary>
                    [NameInMap("EstimatedTotalCount")]
                    [Validation(Required=false)]
                    public long? EstimatedTotalCount { get; set; }

                    /// <summary>
                    /// The amount of data migrated.
                    /// </summary>
                    [NameInMap("FinishedCount")]
                    [Validation(Required=false)]
                    public long? FinishedCount { get; set; }

                    /// <summary>
                    /// finishedCount / estimatedTotalCount
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                }

                /// <summary>
                /// The resource deployment ID.
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public string DeployId { get; set; }

                /// <summary>
                /// The read/write throughput of the destination data source, in bytes per second.
                /// </summary>
                [NameInMap("DstIops")]
                [Validation(Required=false)]
                public long? DstIops { get; set; }

                /// <summary>
                /// The read/write RPS of the destination data source.
                /// </summary>
                [NameInMap("DstRps")]
                [Validation(Required=false)]
                public long? DstRps { get; set; }

                /// <summary>
                /// The read/write RPS baseline of the destination data source.
                /// </summary>
                [NameInMap("DstRpsRef")]
                [Validation(Required=false)]
                public long? DstRpsRef { get; set; }

                /// <summary>
                /// The read/write RT per record of the destination data source, in ms.
                /// </summary>
                [NameInMap("DstRt")]
                [Validation(Required=false)]
                public long? DstRt { get; set; }

                /// <summary>
                /// The read/write RT baseline of the destination data source.
                /// </summary>
                [NameInMap("DstRtRef")]
                [Validation(Required=false)]
                public long? DstRtRef { get; set; }

                /// <summary>
                /// The checkpoint collection time. The value is a unix timestamp in seconds.
                /// </summary>
                [NameInMap("Gmt")]
                [Validation(Required=false)]
                public long? Gmt { get; set; }

                /// <summary>
                /// The amount of inconsistent data found during full verification.
                /// </summary>
                [NameInMap("Inconsistencies")]
                [Validation(Required=false)]
                public long? Inconsistencies { get; set; }

                /// <summary>
                /// The checkpoint in incremental synchronization. The value is a unix timestamp in seconds.
                /// </summary>
                [NameInMap("IncrTimestampCheckpoint")]
                [Validation(Required=false)]
                public long? IncrTimestampCheckpoint { get; set; }

                /// <summary>
                /// The job ID.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The number of migrated rows.
                /// </summary>
                [NameInMap("ProcessedRecords")]
                [Validation(Required=false)]
                public long? ProcessedRecords { get; set; }

                /// <summary>
                /// A sub-status that indicates whether this step is skipped.
                /// </summary>
                [NameInMap("Skipped")]
                [Validation(Required=false)]
                public bool? Skipped { get; set; }

                /// <summary>
                /// The read throughput of the source data source, in bytes per second.
                /// </summary>
                [NameInMap("SrcIops")]
                [Validation(Required=false)]
                public long? SrcIops { get; set; }

                /// <summary>
                /// The read throughput baseline of the source data source.
                /// </summary>
                [NameInMap("SrcIopsRef")]
                [Validation(Required=false)]
                public long? SrcIopsRef { get; set; }

                /// <summary>
                /// The read requests per second (RPS) of the source data source.
                /// </summary>
                [NameInMap("SrcRps")]
                [Validation(Required=false)]
                public long? SrcRps { get; set; }

                /// <summary>
                /// The read RPS baseline of the source data source.
                /// </summary>
                [NameInMap("SrcRpsRef")]
                [Validation(Required=false)]
                public long? SrcRpsRef { get; set; }

                /// <summary>
                /// The read response time (RT) per record of the source data source, in ms.
                /// </summary>
                [NameInMap("SrcRt")]
                [Validation(Required=false)]
                public long? SrcRt { get; set; }

                /// <summary>
                /// The read RT baseline of the source data source.
                /// </summary>
                [NameInMap("SrcRtRef")]
                [Validation(Required=false)]
                public long? SrcRtRef { get; set; }

                /// <summary>
                /// A sub-status that indicates whether the checker has completed full verification.
                /// </summary>
                [NameInMap("Validated")]
                [Validation(Required=false)]
                public bool? Validated { get; set; }

            }

            /// <summary>
            /// The step name. Valid values: struct_migration, full_migration, full_validation, incr_log_pull, incr_sync/incr_validation, PRE_CHECK, PREPARE, STRUCT_MIGRATION, INDEX_MIGRATION, STRUCT_SYNC, FULL_MIGRATION, APP_SWITCH, REVERSE_INCR_SYNC, FULL_VALIDATION, INCR_LOG_PULL, INCR_SYNC, INCR_VALIDATION, SYNC_PREPARE, SYNC_INCR_LOG_PULL, CONNECTOR_FULL_SYNC, or CONNECTOR_INCR_SYNC.
            /// </summary>
            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

            /// <summary>
            /// The sequence of steps.
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            /// <summary>
            /// The step progress.
            /// </summary>
            [NameInMap("StepProgress")]
            [Validation(Required=false)]
            public int? StepProgress { get; set; }

            /// <summary>
            /// The step status. Valid values: INIT, RUNNING, FAILED, FINISHED, SUSPEND, and MONITORING. The value MONITORING indicates the continuous monitoring of incremental synchronization and incremental verification.
            /// </summary>
            [NameInMap("StepStatus")]
            [Validation(Required=false)]
            public string StepStatus { get; set; }

        }

        /// <summary>
        /// The error details.
        /// </summary>
        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeOmsOpenAPIProjectStepsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeOmsOpenAPIProjectStepsResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// The error code (new).
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error level. Valid values: CRITICAL, ERROR, and WARN.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The error description (new).
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The suggestions (new).
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

        }

        /// <summary>
        /// The error description (old).
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page size, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total count, which takes effect in a pagination query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

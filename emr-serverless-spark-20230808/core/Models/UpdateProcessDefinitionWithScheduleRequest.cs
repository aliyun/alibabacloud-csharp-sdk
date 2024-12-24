// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateProcessDefinitionWithScheduleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:foo_bar@spark.alert.invalid.com">foo_bar@spark.alert.invalid.com</a></para>
        /// </summary>
        [NameInMap("alertEmailAddress")]
        [Validation(Required=false)]
        public string AlertEmailAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ods batch workflow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARALLEL</para>
        /// </summary>
        [NameInMap("executionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_batch_workflow</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SS</para>
        /// </summary>
        [NameInMap("productNamespace")]
        [Validation(Required=false)]
        public string ProductNamespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("publish")]
        [Validation(Required=false)]
        public bool? Publish { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ONLINE</para>
        /// </summary>
        [NameInMap("releaseState")]
        [Validation(Required=false)]
        public string ReleaseState { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root_queue</para>
        /// </summary>
        [NameInMap("resourceQueue")]
        [Validation(Required=false)]
        public string ResourceQueue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("retryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>113***************</para>
        /// </summary>
        [NameInMap("runAs")]
        [Validation(Required=false)]
        public string RunAs { get; set; }

        [NameInMap("schedule")]
        [Validation(Required=false)]
        public UpdateProcessDefinitionWithScheduleRequestSchedule Schedule { get; set; }
        public class UpdateProcessDefinitionWithScheduleRequestSchedule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("crontab")]
            [Validation(Required=false)]
            public string Crontab { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-23 16:13:27</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-23 16:13:27</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezoneId")]
            [Validation(Required=false)]
            public string TimezoneId { get; set; }

        }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskDefinitionJson")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJson> TaskDefinitionJson { get; set; }
        public class UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJson : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:foo_bar@spark.alert.invalid.com">foo_bar@spark.alert.invalid.com</a></para>
            /// </summary>
            [NameInMap("alertEmailAddress")]
            [Validation(Required=false)]
            public string AlertEmailAddress { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23************</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public long? Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ods transform task</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("failAlertEnable")]
            [Validation(Required=false)]
            public bool? FailAlertEnable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failRetryTimes")]
            [Validation(Required=false)]
            public int? FailRetryTimes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_transform_task</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("startAlertEnable")]
            [Validation(Required=false)]
            public bool? StartAlertEnable { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("taskParams")]
            [Validation(Required=false)]
            public UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJsonTaskParams TaskParams { get; set; }
            public class UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJsonTaskParams : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
                /// </summary>
                [NameInMap("displaySparkVersion")]
                [Validation(Required=false)]
                public string DisplaySparkVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ev-h*************</para>
                /// </summary>
                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("fusion")]
                [Validation(Required=false)]
                public bool? Fusion { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root_queue</para>
                /// </summary>
                [NameInMap("resourceQueueId")]
                [Validation(Required=false)]
                public string ResourceQueueId { get; set; }

                [NameInMap("sparkConf")]
                [Validation(Required=false)]
                public List<UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJsonTaskParamsSparkConf> SparkConf { get; set; }
                public class UpdateProcessDefinitionWithScheduleRequestTaskDefinitionJsonTaskParamsSparkConf : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>spark.dynamicAllocation.enabled</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sparkDriverCores")]
                [Validation(Required=false)]
                public int? SparkDriverCores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4g</para>
                /// </summary>
                [NameInMap("sparkDriverMemory")]
                [Validation(Required=false)]
                public long? SparkDriverMemory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sparkExecutorCores")]
                [Validation(Required=false)]
                public int? SparkExecutorCores { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4g</para>
                /// </summary>
                [NameInMap("sparkExecutorMemory")]
                [Validation(Required=false)]
                public long? SparkExecutorMemory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INFO</para>
                /// </summary>
                [NameInMap("sparkLogLevel")]
                [Validation(Required=false)]
                public string SparkLogLevel { get; set; }

                [NameInMap("sparkLogPath")]
                [Validation(Required=false)]
                public string SparkLogPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
                /// </summary>
                [NameInMap("sparkVersion")]
                [Validation(Required=false)]
                public string SparkVersion { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TSK-d87******************</para>
                /// </summary>
                [NameInMap("taskBizId")]
                [Validation(Required=false)]
                public string TaskBizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SQL</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>w-d8********</para>
                /// </summary>
                [NameInMap("workspaceBizId")]
                [Validation(Required=false)]
                public string WorkspaceBizId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EMR-SERVERLESS-SPARK</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("taskParallelism")]
        [Validation(Required=false)]
        public int? TaskParallelism { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("taskRelationJson")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionWithScheduleRequestTaskRelationJson> TaskRelationJson { get; set; }
        public class UpdateProcessDefinitionWithScheduleRequestTaskRelationJson : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods batch workflow</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19************</para>
            /// </summary>
            [NameInMap("postTaskCode")]
            [Validation(Required=false)]
            public long? PostTaskCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("postTaskVersion")]
            [Validation(Required=false)]
            public int? PostTaskVersion { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16************</para>
            /// </summary>
            [NameInMap("preTaskCode")]
            [Validation(Required=false)]
            public long? PreTaskCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("preTaskVersion")]
            [Validation(Required=false)]
            public int? PreTaskVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}

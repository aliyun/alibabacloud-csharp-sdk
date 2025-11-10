// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMigrationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMigrationsResponseBodyData Data { get; set; }
        public class ListMigrationsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListMigrationsResponseBodyDataList> List { get; set; }
            public class ListMigrationsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("currentStage")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListCurrentStage CurrentStage { get; set; }
                public class ListMigrationsResponseBodyDataListCurrentStage : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("stageData")]
                    [Validation(Required=false)]
                    public object StageData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DOING</para>
                    /// </summary>
                    [NameInMap("stageStatus")]
                    [Validation(Required=false)]
                    public string StageStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MIGRATE_METADATA</para>
                    /// </summary>
                    [NameInMap("stageType")]
                    [Validation(Required=false)]
                    public string StageType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("migrationId")]
                [Validation(Required=false)]
                public long? MigrationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("migrationName")]
                [Validation(Required=false)]
                public string MigrationName { get; set; }

                [NameInMap("migrationSource")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListMigrationSource MigrationSource { get; set; }
                public class ListMigrationsResponseBodyDataListMigrationSource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("sourceData")]
                    [Validation(Required=false)]
                    public object SourceData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EXTERNAL_INSTANCE</para>
                    /// </summary>
                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MIGRATING</para>
                /// </summary>
                [NameInMap("migrationStatus")]
                [Validation(Required=false)]
                public string MigrationStatus { get; set; }

                [NameInMap("migrationTarget")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListMigrationTarget MigrationTarget { get; set; }
                public class ListMigrationsResponseBodyDataListMigrationTarget : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("targetData")]
                    [Validation(Required=false)]
                    public object TargetData { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>INTERNAL_INSTANCE</para>
                    /// </summary>
                    [NameInMap("targetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INSTANCE_MIGRATION</para>
                /// </summary>
                [NameInMap("migrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E5897B2E-C3AC-56DC-A482-F0E9E53F48D5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

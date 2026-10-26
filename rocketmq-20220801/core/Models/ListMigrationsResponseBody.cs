// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMigrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingInstanceId</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMigrationsResponseBodyData Data { get; set; }
        public class ListMigrationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The paged data.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListMigrationsResponseBodyDataList> List { get; set; }
            public class ListMigrationsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The creation time, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The current migration stage.</para>
                /// </summary>
                [NameInMap("currentStage")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListCurrentStage CurrentStage { get; set; }
                public class ListMigrationsResponseBodyDataListCurrentStage : TeaModel {
                    /// <summary>
                    /// <para>The stage data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("stageData")]
                    [Validation(Required=false)]
                    public object StageData { get; set; }

                    /// <summary>
                    /// <para>The stage status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>INIT: Not started.</description></item>
                    /// <item><description>DOING: In progress.</description></item>
                    /// <item><description>DONE: Completed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DOING</para>
                    /// </summary>
                    [NameInMap("stageStatus")]
                    [Validation(Required=false)]
                    public string StageStatus { get; set; }

                    /// <summary>
                    /// <para>The stage type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CONNECT_NETWORK: Network connection.</description></item>
                    /// <item><description>MIGRATE_METADATA: Metadata migration.</description></item>
                    /// <item><description>REPLACE_ENDPOINT: Endpoint replacement.</description></item>
                    /// <item><description>MIGRATE_MESSAGE: Message migration.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MIGRATE_METADATA</para>
                    /// </summary>
                    [NameInMap("stageType")]
                    [Validation(Required=false)]
                    public string StageType { get; set; }

                }

                /// <summary>
                /// <para>The migration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("migrationId")]
                [Validation(Required=false)]
                public long? MigrationId { get; set; }

                /// <summary>
                /// <para>The migration name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("migrationName")]
                [Validation(Required=false)]
                public string MigrationName { get; set; }

                /// <summary>
                /// <para>The migration source.</para>
                /// </summary>
                [NameInMap("migrationSource")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListMigrationSource MigrationSource { get; set; }
                public class ListMigrationsResponseBodyDataListMigrationSource : TeaModel {
                    /// <summary>
                    /// <para>The migration source data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    /// &quot;clusterType&quot;:&quot;INTERNET_NETWORK&quot;,
                    /// &quot;aclType&quot;:&quot;NONE&quot;,
                    /// &quot;clusterName&quot;:&quot;test&quot;,
                    /// &quot;namesrvAddrList&quot;:&quot;47.110.248.xxx:9876&quot;],
                    /// &quot;brokerObtainMethod&quot;:&quot;AUTO_OBTAIN&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("sourceData")]
                    [Validation(Required=false)]
                    public object SourceData { get; set; }

                    /// <summary>
                    /// <para>The migration source type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>EXTERNAL_INSTANCE: External instance.</description></item>
                    /// <item><description>INTERNAL_INSTANCE: Alibaba Cloud 5.0 instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EXTERNAL_INSTANCE</para>
                    /// </summary>
                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

                /// <summary>
                /// <para>The migration status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATED: Created.</description></item>
                /// <item><description>MIGRATING: Migrating.</description></item>
                /// <item><description>COMPLETED: Completed.</description></item>
                /// <item><description>CANCELLED: Cancelled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MIGRATING</para>
                /// </summary>
                [NameInMap("migrationStatus")]
                [Validation(Required=false)]
                public string MigrationStatus { get; set; }

                /// <summary>
                /// <para>The migration target.</para>
                /// </summary>
                [NameInMap("migrationTarget")]
                [Validation(Required=false)]
                public ListMigrationsResponseBodyDataListMigrationTarget MigrationTarget { get; set; }
                public class ListMigrationsResponseBodyDataListMigrationTarget : TeaModel {
                    /// <summary>
                    /// <para>The migration target data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    /// &quot;clusterType&quot;:&quot;ROCKETMQ_V5&quot;,
                    /// &quot;instanceId&quot;:&quot;rmq-cn-778429mp301&quot;,
                    /// &quot;regionId&quot;:&quot;cn-hangzhou&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("targetData")]
                    [Validation(Required=false)]
                    public object TargetData { get; set; }

                    /// <summary>
                    /// <para>The migration target type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>INTERNAL_INSTANCE: Alibaba Cloud 5.0 instance.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>INTERNAL_INSTANCE</para>
                    /// </summary>
                    [NameInMap("targetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The migration type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INSTANCE_MIGRATION: instance migration</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANCE_MIGRATION</para>
                /// </summary>
                [NameInMap("migrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The modification time, in YYYY-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance cannot be found.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5897B2E-C3AC-56DC-A482-F0E9E53F48D5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMigrationOperationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMigrationOperationsResponseBodyData Data { get; set; }
        public class ListMigrationOperationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The paginated data.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListMigrationOperationsResponseBodyDataList> List { get; set; }
            public class ListMigrationOperationsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The operation business status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOUBLE_READ</para>
                /// </summary>
                [NameInMap("businessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The creation time, in the format of YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The migration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("migrationId")]
                [Validation(Required=false)]
                public long? MigrationId { get; set; }

                /// <summary>
                /// <para>The migration operation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>183</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public long? OperationId { get; set; }

                /// <summary>
                /// <para>The primary key of the operation object.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>During the message migration stage, the operation object is the topic name.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>normal-topic-1</para>
                /// </summary>
                [NameInMap("operationKey")]
                [Validation(Required=false)]
                public string OperationKey { get; set; }

                /// <summary>
                /// <para>The operation parameter.</para>
                /// </summary>
                [NameInMap("operationParam")]
                [Validation(Required=false)]
                public ListMigrationOperationsResponseBodyDataListOperationParam OperationParam { get; set; }
                public class ListMigrationOperationsResponseBodyDataListOperationParam : TeaModel {
                    /// <summary>
                    /// <para>The parameter information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;action&quot;: &quot;MIGRATE_FORWARD&quot;,
                    ///       &quot;targetStage&quot;: &quot;MIGRATE_FINISH&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("paramData")]
                    [Validation(Required=false)]
                    public object ParamData { get; set; }

                }

                /// <summary>
                /// <para>The operation result.</para>
                /// </summary>
                [NameInMap("operationResult")]
                [Validation(Required=false)]
                public ListMigrationOperationsResponseBodyDataListOperationResult OperationResult { get; set; }
                public class ListMigrationOperationsResponseBodyDataListOperationResult : TeaModel {
                    /// <summary>
                    /// <para>The operation result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;checkStatus&quot;: &quot;WAIT_CHECK&quot;,
                    ///       &quot;sourceTopicStatus&quot;: &quot;PERM_6&quot;,
                    ///       &quot;targetTopicStatus&quot;: &quot;PERM_4&quot;,
                    ///       &quot;checkResult&quot;: {},
                    ///       &quot;migrateStage&quot;: &quot;DOUBLE_READ&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("resultData")]
                    [Validation(Required=false)]
                    public object ResultData { get; set; }

                }

                /// <summary>
                /// <para>The operation status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOING</para>
                /// </summary>
                [NameInMap("operationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// <para>The operation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIGRATE_MESSAGE</para>
                /// </summary>
                [NameInMap("operationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <para>The migration stage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MIGRATE_MESSAGE</para>
                /// </summary>
                [NameInMap("stageType")]
                [Validation(Required=false)]
                public string StageType { get; set; }

                /// <summary>
                /// <para>The update time, in the format of YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
        /// <para>consumerGroupId</para>
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
        /// <para>The topic already exists.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7E8AE3A-219B-52EE-BE32-4036F5F88833</para>
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

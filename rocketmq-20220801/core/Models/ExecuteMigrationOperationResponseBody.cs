// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ExecuteMigrationOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Topic.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteMigrationOperationResponseBodyData Data { get; set; }
        public class ExecuteMigrationOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operation business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MIGRATE_WAIT</para>
            /// </summary>
            [NameInMap("businessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <para>The creation time, in YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The migration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("migrationId")]
            [Validation(Required=false)]
            public long? MigrationId { get; set; }

            /// <summary>
            /// <para>The migration operation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public long? OperationId { get; set; }

            /// <summary>
            /// <para>The primary key of the operation object.</para>
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
            public ExecuteMigrationOperationResponseBodyDataOperationParam OperationParam { get; set; }
            public class ExecuteMigrationOperationResponseBodyDataOperationParam : TeaModel {
                /// <summary>
                /// <para>The parameter information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;action&quot;:&quot;MIGRATE_FORWARD&quot;,&quot;targetStage&quot;:&quot;MIGRATE_FINISH&quot;}</para>
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
            public ExecuteMigrationOperationResponseBodyDataOperationResult OperationResult { get; set; }
            public class ExecuteMigrationOperationResponseBodyDataOperationResult : TeaModel {
                /// <summary>
                /// <para>The operation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;checkStatus&quot;: &quot;WAIT_CHECK&quot;,
                ///     &quot;sourceTopicStatus&quot;: &quot;PERM_6&quot;,
                ///     &quot;targetTopicStatus&quot;: &quot;PERM_4&quot;,
                ///     &quot;checkResult&quot;: {},
                ///     &quot;migrateStage&quot;: &quot;DOUBLE_READ&quot;
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
            /// <para>The modification time, in YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        /// <para>The topic already exists.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>814BCD66-2D76-5080-AAD2-E50E5BDB0995</para>
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

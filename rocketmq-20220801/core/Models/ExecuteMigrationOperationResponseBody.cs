// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ExecuteMigrationOperationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Topic.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteMigrationOperationResponseBodyData Data { get; set; }
        public class ExecuteMigrationOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MIGRATE_WAIT</para>
            /// </summary>
            [NameInMap("businessStatus")]
            [Validation(Required=false)]
            public string BusinessStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("migrationId")]
            [Validation(Required=false)]
            public long? MigrationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110</para>
            /// </summary>
            [NameInMap("operationId")]
            [Validation(Required=false)]
            public long? OperationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>group01</para>
            /// </summary>
            [NameInMap("operationKey")]
            [Validation(Required=false)]
            public string OperationKey { get; set; }

            [NameInMap("operationParam")]
            [Validation(Required=false)]
            public ExecuteMigrationOperationResponseBodyDataOperationParam OperationParam { get; set; }
            public class ExecuteMigrationOperationResponseBodyDataOperationParam : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("paramData")]
                [Validation(Required=false)]
                public object ParamData { get; set; }

            }

            [NameInMap("operationResult")]
            [Validation(Required=false)]
            public ExecuteMigrationOperationResponseBodyDataOperationResult OperationResult { get; set; }
            public class ExecuteMigrationOperationResponseBodyDataOperationResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("resultData")]
                [Validation(Required=false)]
                public object ResultData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("operationStatus")]
            [Validation(Required=false)]
            public string OperationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CONNECT_NETWORK</para>
            /// </summary>
            [NameInMap("operationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MIGRATE_METADATA</para>
            /// </summary>
            [NameInMap("stageType")]
            [Validation(Required=false)]
            public string StageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        /// <para>The topic already exists.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>814BCD66-2D76-5080-AAD2-E50E5BDB0995</para>
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

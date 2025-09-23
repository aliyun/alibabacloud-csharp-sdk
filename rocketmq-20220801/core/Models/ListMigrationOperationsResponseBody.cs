// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListMigrationOperationsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance.NotFound</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMigrationOperationsResponseBodyData Data { get; set; }
        public class ListMigrationOperationsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListMigrationOperationsResponseBodyDataList> List { get; set; }
            public class ListMigrationOperationsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CONNECT_PENDING</para>
                /// </summary>
                [NameInMap("businessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("migrationId")]
                [Validation(Required=false)]
                public long? MigrationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>183</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public long? OperationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("operationKey")]
                [Validation(Required=false)]
                public string OperationKey { get; set; }

                [NameInMap("operationParam")]
                [Validation(Required=false)]
                public ListMigrationOperationsResponseBodyDataListOperationParam OperationParam { get; set; }
                public class ListMigrationOperationsResponseBodyDataListOperationParam : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("paramData")]
                    [Validation(Required=false)]
                    public object ParamData { get; set; }

                }

                [NameInMap("operationResult")]
                [Validation(Required=false)]
                public ListMigrationOperationsResponseBodyDataListOperationResult OperationResult { get; set; }
                public class ListMigrationOperationsResponseBodyDataListOperationResult : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("resultData")]
                    [Validation(Required=false)]
                    public object ResultData { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DOING</para>
                /// </summary>
                [NameInMap("operationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>IMPORT_CONSUMER_GROUP</para>
                /// </summary>
                [NameInMap("operationType")]
                [Validation(Required=false)]
                public string OperationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CONNECT_NETWORK</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
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
        /// <para>consumerGroupId</para>
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
        /// <para>C7E8AE3A-219B-52EE-BE32-4036F5F88833</para>
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

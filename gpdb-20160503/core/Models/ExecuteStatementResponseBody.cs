// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-04T10:08:47+0800</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The result returned for synchronous calls.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecuteStatementResponseBodyData Data { get; set; }
        public class ExecuteStatementResponseBodyData : TeaModel {
            [NameInMap("ColumnMetadata")]
            [Validation(Required=false)]
            public ExecuteStatementResponseBodyDataColumnMetadata ColumnMetadata { get; set; }
            public class ExecuteStatementResponseBodyDataColumnMetadata : TeaModel {
                [NameInMap("ColumnMetadata")]
                [Validation(Required=false)]
                public List<ColumnMetadata> ColumnMetadata { get; set; }

            }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public ExecuteStatementResponseBodyDataRecords Records { get; set; }
            public class ExecuteStatementResponseBodyDataRecords : TeaModel {
                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<ExecuteStatementResponseBodyDataRecordsRecords> Records { get; set; }
                public class ExecuteStatementResponseBodyDataRecordsRecords : TeaModel {
                    [NameInMap("Record")]
                    [Validation(Required=false)]
                    public List<Field> Record { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalNumRows")]
            [Validation(Required=false)]
            public long? TotalNumRows { get; set; }

        }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbtest</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The task ID for asynchronous SQL execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The access credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:gpdb:cn-beijing:1033**:secret/testsecret-eG2AQGRIwQ0zFp4VA7mYL3uiCXTfDQbQ</para>
        /// </summary>
        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        /// <summary>
        /// <para>The execution status of the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The execution is successful.</description></item>
        /// <item><description><b>fail</b>: The execution failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

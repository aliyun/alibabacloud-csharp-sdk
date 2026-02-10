// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetStatementResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the asynchronous call.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStatementResultResponseBodyData Data { get; set; }
        public class GetStatementResultResponseBodyData : TeaModel {
            [NameInMap("ColumnMetadata")]
            [Validation(Required=false)]
            public GetStatementResultResponseBodyDataColumnMetadata ColumnMetadata { get; set; }
            public class GetStatementResultResponseBodyDataColumnMetadata : TeaModel {
                [NameInMap("ColumnMetadata")]
                [Validation(Required=false)]
                public List<ColumnMetadata> ColumnMetadata { get; set; }

            }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public GetStatementResultResponseBodyDataRecords Records { get; set; }
            public class GetStatementResultResponseBodyDataRecords : TeaModel {
                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<GetStatementResultResponseBodyDataRecordsRecords> Records { get; set; }
                public class GetStatementResultResponseBodyDataRecordsRecords : TeaModel {
                    [NameInMap("Record")]
                    [Validation(Required=false)]
                    public List<Field> Record { get; set; }

                }

            }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalNumRows")]
            [Validation(Required=false)]
            public long? TotalNumRows { get; set; }

        }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>API execution status, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Execution failed.</description></item>
        /// <item><description><b>true</b>: Execution succeeded.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message about the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE8EE2F1-4880-46BC-A704-5CF63EAF9A04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results of the SQL statements that are executed, in the format of an array. Each entry in the array indicates the result of an SQL statement.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ExecuteScriptResponseBodyResults> Results { get; set; }
        public class ExecuteScriptResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The fields that are queried after the SQL statement is executed.</para>
            /// </summary>
            [NameInMap("ColumnNames")]
            [Validation(Required=false)]
            public List<string> ColumnNames { get; set; }

            /// <summary>
            /// <para>The error message that is returned if the SQL statement fails to be executed. For example, an error message is returned because the SQL statement is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UnknownError</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The total number of entries that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// <para>The rows that are queried after the SQL statement is executed.</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Rows { get; set; }

            /// <summary>
            /// <para>Indicates whether the SQL statement is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class AsyncSqlResponseData : TeaModel {
        [NameInMap("AsyncSqlMetaPB")]
        [Validation(Required=false)]
        public AsyncSqlResponseDataAsyncSqlMetaPB AsyncSqlMetaPB { get; set; }
        public class AsyncSqlResponseDataAsyncSqlMetaPB : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("cpu_cores")]
            [Validation(Required=false)]
            public int? CpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("cpu_sec")]
            [Validation(Required=false)]
            public double? CpuSec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("elapsed_milli")]
            [Validation(Required=false)]
            public long? ElapsedMilli { get; set; }

            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000000</para>
            /// </summary>
            [NameInMap("processed_rows")]
            [Validation(Required=false)]
            public long? ProcessedRows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("result_rows")]
            [Validation(Required=false)]
            public int? ResultRows { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidQuery</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>line 37:14: Column \&quot;xyz\&quot; cannot be resolved</para>
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>690C4F2A16FBD65C40000484_14</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<List<string>> Rows { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SubmitAsyncSqlParams : TeaModel {
        /// <summary>
        /// <para>Extensions.</para>
        /// </summary>
        [NameInMap("extensions")]
        [Validation(Required=false)]
        public SubmitAsyncSqlParamsExtensions Extensions { get; set; }
        public class SubmitAsyncSqlParamsExtensions : TeaModel {
            /// <summary>
            /// <para>The maximum running time for the request in milliseconds. Maximum value: 600,000 (10 minutes). Default value: 600,000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("maxRunTime")]
            [Validation(Required=false)]
            public long? MaxRunTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable enhanced SQL. The default value is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("powerSql")]
            [Validation(Required=false)]
            public bool? PowerSql { get; set; }

        }

        /// <summary>
        /// <para>The start of the query time range. This time is the log time specified when the log was written. The time range defined by the from and to parameters is left-inclusive and right-exclusive. This means the time range includes the start time but excludes the end time. If the from and to values are the same, the time range is invalid and the function returns an error. The value is a UNIX timestamp in seconds since 00:00:00 UTC on January 1, 1970.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268100</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>The name of the logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The SQL statement to execute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job: IT | select name, age, gender from log</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The end of the query time range. This time is the log time specified when the log was written. The time range defined by the from and to parameters is left-inclusive and right-exclusive. This means the time range includes the start time but excludes the end time. If the from and to values are the same, the time range is invalid and the function returns an error. The value is a UNIX timestamp in seconds since 00:00:00 UTC on January 1, 1970.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627268200</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

    }

}

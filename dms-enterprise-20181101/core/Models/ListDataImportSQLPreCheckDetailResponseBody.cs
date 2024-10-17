// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataImportSQLPreCheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The precheck information of SQL statements.</para>
        /// </summary>
        [NameInMap("PreCheckSQLDetailList")]
        [Validation(Required=false)]
        public List<ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList> PreCheckSQLDetailList { get; set; }
        public class ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the precheck of the SQL statement was skipped. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// <para>The SQL ID, which indicates the sequence number of the SQL statement. The number starts with 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public long? SqlId { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSERT</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The state of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The ticket was being initialized.</description></item>
            /// <item><description><b>RUNNING</b>: The ticket was in progress.</description></item>
            /// <item><description><b>SUCCESS</b>: The ticket was complete.</description></item>
            /// <item><description><b>TIMEOUT</b>: The ticket was skipped due to timeout.</description></item>
            /// <item><description><b>FAIL</b>: The ticket failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31853A2B-DC9D-5B39-8492-D2AC8BCF550E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

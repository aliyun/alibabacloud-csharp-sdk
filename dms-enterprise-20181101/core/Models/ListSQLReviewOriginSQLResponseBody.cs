// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about the parsed SQL statements.</para>
        /// </summary>
        [NameInMap("OriginSQLList")]
        [Validation(Required=false)]
        public List<ListSQLReviewOriginSQLResponseBodyOriginSQLList> OriginSQLList { get; set; }
        public class ListSQLReviewOriginSQLResponseBodyOriginSQLList : TeaModel {
            /// <summary>
            /// <para>The review status of the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>new</b>: The SQL statement was waiting to be reviewed.</description></item>
            /// <item><description><b>unknown</b>: The SQL statement cannot be parsed.</description></item>
            /// <item><description><b>check_not_pass</b>: The SQL statement failed to pass the review.</description></item>
            /// <item><description><b>check_pass</b>: The SQL statement passed the review.</description></item>
            /// <item><description><b>force_pass</b>: The SQL statement passed the manual review.</description></item>
            /// <item><description><b>force_not_pass</b>: The SQL statement failed to pass the manual review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>check_pass</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// <para>The time when the SQL statement was reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-09 21:07:00</para>
            /// </summary>
            [NameInMap("CheckedTime")]
            [Validation(Required=false)]
            public string CheckedTime { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123321</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.sql</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The statistics on the optimization suggestions for SQL statements. The value is a JSON string. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MUST_IMPROVE</b>: The SQL statements must be optimized.</description></item>
            /// <item><description><b>POTENTIAL_ISSUE</b>: The SQL statements contain potential issues.</description></item>
            /// <item><description><b>SUGGEST_IMPROVE</b>: We recommend that you optimize the SQL statements.</description></item>
            /// <item><description><b>USEDMSTOOLKIT</b>: We recommend that you change schemas without locking tables.</description></item>
            /// <item><description><b>USEDMSDML_UNLOCK</b>: We recommend that you change data without locking tables.</description></item>
            /// <item><description><b>TABLEINDEXSUGGEST</b>: We recommend that you optimize indexes for the SQL statements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;POTENTIAL_ISSUE&quot;:1,&quot;SUGGEST_IMPROVE&quot;:1}</para>
            /// </summary>
            [NameInMap("ReviewSummary")]
            [Validation(Required=false)]
            public string ReviewSummary { get; set; }

            /// <summary>
            /// <para>The SQL statement in the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select id from table_name</para>
            /// </summary>
            [NameInMap("SQLContent")]
            [Validation(Required=false)]
            public string SQLContent { get; set; }

            /// <summary>
            /// <para>The ID of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public long? SQLId { get; set; }

            /// <summary>
            /// <para>The name of the SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>getByPk</para>
            /// </summary>
            [NameInMap("SQLName")]
            [Validation(Required=false)]
            public string SQLName { get; set; }

            /// <summary>
            /// <para>The key that is used to query the information about optimization suggestions. You can call the <a href="https://help.aliyun.com/document_detail/465919.html">GetSQLReviewOptimizeDetail</a> operation to query the details based on this key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a57e54ec5433475ea3082d882fdb89c5</para>
            /// </summary>
            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            /// <summary>
            /// <para>The MD5 hash value that is obtained after the SQL statement is calculated by using a hash algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95adb6e77a0884d9e50232cb8c5c969d</para>
            /// </summary>
            [NameInMap("SqlHash")]
            [Validation(Required=false)]
            public string SqlHash { get; set; }

            /// <summary>
            /// <para>The description of the review status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>passed the test</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of SQL statements in the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

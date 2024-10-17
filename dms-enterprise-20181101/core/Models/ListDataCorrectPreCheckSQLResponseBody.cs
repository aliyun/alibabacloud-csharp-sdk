// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataCorrectPreCheckSQLResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The precheck information about SQL statements.</para>
        /// </summary>
        [NameInMap("PreCheckSQLList")]
        [Validation(Required=false)]
        public List<ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList> PreCheckSQLList { get; set; }
        public class ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList : TeaModel {
            /// <summary>
            /// <para>The estimated number of affected rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// <para>The SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPTIMIZE TABLE <c>Text_TableNames</c></para>
            /// </summary>
            [NameInMap("CheckSQL")]
            [Validation(Required=false)]
            public string CheckSQL { get; set; }

            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1930****</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// <para>The key that is used to query the details of optimization suggestions. You can call the <a href="https://help.aliyun.com/document_detail/265977.html">GetSQLReviewOptimizeDetail</a> operation to query the details of optimization suggestions based on the key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b9e771fc6ec247dea6d06a32c777****</para>
            /// </summary>
            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            /// <summary>
            /// <para>The review status of the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAITING</b>: The SQL statement is pending for review.</description></item>
            /// <item><description><b>RUNNING</b>: The SQL statement is being reviewed.</description></item>
            /// <item><description><b>IGNORE</b>: The SQL statement review is skipped.</description></item>
            /// <item><description><b>PASS</b>: The SQL statement passed the review.</description></item>
            /// <item><description><b>BLOCK</b>: The SQL statement failed the review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAITING</para>
            /// </summary>
            [NameInMap("SqlReviewStatus")]
            [Validation(Required=false)]
            public string SqlReviewStatus { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OPTIMIZE</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// <para>The name of the table whose data is changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text_TableNames</para>
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31853A2B-DC9D-5B39-8492-D2AC8BCF550E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

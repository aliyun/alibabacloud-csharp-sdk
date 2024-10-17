// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLRequest : TeaModel {
        /// <summary>
        /// <para>The parameters that are used to filter SQL statements involved in the ticket.</para>
        /// </summary>
        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public ListSQLReviewOriginSQLRequestOrderActionDetail OrderActionDetail { get; set; }
        public class ListSQLReviewOriginSQLRequestOrderActionDetail : TeaModel {
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
            /// <para>check_not_pass</para>
            /// </summary>
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public string CheckStatusResult { get; set; }

            /// <summary>
            /// <para>The ID of the file that contains the SQL statements to be reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123345</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListSQLReviewOriginSQLRequestOrderActionDetailPage Page { get; set; }
            public class ListSQLReviewOriginSQLRequestOrderActionDetailPage : TeaModel {
                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <para>The number of entries per page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// <para>The optimization suggestion for the SQL statement. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MUST_IMPROVE</b>: The SQL statement must be optimized.</description></item>
            /// <item><description><b>POTENTIAL_ISSUE</b>: The SQL statement contains potential issues.</description></item>
            /// <item><description><b>SUGGEST_IMPROVE</b>: We recommend that you optimize the SQL statement.</description></item>
            /// <item><description><b>USE_DMS_TOOLKIT</b>: We recommend that you change schemas without locking tables.</description></item>
            /// <item><description><b>USE_DMS_DML_UNLOCK</b>: We recommend that you change data without locking tables.</description></item>
            /// <item><description><b>TABLE_INDEX_SUGGEST</b>: We recommend that you optimize indexes for the SQL statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MUST_IMPROVE</para>
            /// </summary>
            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public string SQLReviewResult { get; set; }

        }

        /// <summary>
        /// <para>The ID of the SQL review ticket. You can call the <a href="https://help.aliyun.com/document_detail/257777.html">CreateSQLReviewOrder</a> operation to query the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123321</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegeObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegeObjectsResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegeObjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the column. This parameter is returned when PrivilegeType is set to Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column1</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// <para>The name of the database. This parameter is returned when PrivilegeType is set to Database, Table, or Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tdb1</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The description that is specified when you create a table or column. This parameter is returned only when PrivilegeType is set to Database or Table, indicating the database description or table description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a test db</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the table. This parameter is returned when PrivilegeType is set to Table or Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34B2AD29-682F-1C14-B3AA-9EF1A96084B8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

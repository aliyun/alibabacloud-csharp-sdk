// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegeObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of privileges.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegeObjectsResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegeObjectsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The column name. This field is returned when the privilege level is Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column1</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// <para>The database name. This field is returned when the privilege level is Database, Table, or Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tdb1</para>
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// <para>The description specified when the table or column is created. This field has a value only when the privilege level is Database or Table, representing the description of the database or table, respectively.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a test db</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The table name. This field is returned when the privilege level is Table or Column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table1</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

        }

        /// <summary>
        /// <para>The page number, which is the same as the value passed in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size, which is the same as the value passed in the request.</para>
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

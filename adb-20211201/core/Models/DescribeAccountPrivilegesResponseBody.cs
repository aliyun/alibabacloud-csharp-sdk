// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of privilege details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegesResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The privilege object, which specifies the database, table, column, and description.</para>
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public DescribeAccountPrivilegesResponseBodyDataPrivilegeObject PrivilegeObject { get; set; }
            public class DescribeAccountPrivilegesResponseBodyDataPrivilegeObject : TeaModel {
                /// <summary>
                /// <para>The column name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a test column</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tabl1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <para>The privilege level. Valid values: <c>Global</c>, <c>Database</c>, <c>Table</c>, and <c>Column</c>. The <c>DescribeEnabledPrivileges</c> API returns this value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Column</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>A list of privileges.</para>
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// <para>The page number. This value matches the <c>PageNumber</c> input parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. This value matches the <c>PageSize</c> input parameter.</para>
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
        /// <para>DA32480A-E3E5-1BE7-BA98-724551DC04C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of privileges at the specified privilege level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

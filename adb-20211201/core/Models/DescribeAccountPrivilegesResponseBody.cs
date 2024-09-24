// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the permissions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountPrivilegesResponseBodyData> Data { get; set; }
        public class DescribeAccountPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The objects on which the permission takes effect, including databases, tables, columns, and additional descriptions.</para>
            /// </summary>
            [NameInMap("PrivilegeObject")]
            [Validation(Required=false)]
            public DescribeAccountPrivilegesResponseBodyDataPrivilegeObject PrivilegeObject { get; set; }
            public class DescribeAccountPrivilegesResponseBodyDataPrivilegeObject : TeaModel {
                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>column1</para>
                /// </summary>
                [NameInMap("Column")]
                [Validation(Required=false)]
                public string Column { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// <para>The description of the permission object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a test column</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tabl1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <para>The permission level of the permission. Valid values: <c>Global</c>, <c>Database</c>, <c>Table</c>, and <c>Column</c>. You can call the <c>DescribeEnabledPrivileges</c> parameter to query the permission level of a specific permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Column</para>
            /// </summary>
            [NameInMap("PrivilegeType")]
            [Validation(Required=false)]
            public string PrivilegeType { get; set; }

            /// <summary>
            /// <para>The name of the permission. You can call the <c>DescribeEnabledPrivileges</c> operation to query the name of the permission.</para>
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<string> Privileges { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA32480A-E3E5-1BE7-BA98-724551DC04C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

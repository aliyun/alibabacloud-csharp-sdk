// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountAllPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>Permission details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountAllPrivilegesResponseBodyData Data { get; set; }
        public class DescribeAccountAllPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If the <c>Truncated</c> field in the response is <c>true</c>, pass this value in subsequent calls to retrieve the next set of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0573e74fd1ccb01739993a691e876074db6e1b6ad79f54115f0e98528432ba6a523cfec5780ade5189299cc3396f6ff7</para>
            /// </summary>
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>List of permissions.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAccountAllPrivilegesResponseBodyDataResult> Result { get; set; }
            public class DescribeAccountAllPrivilegesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The permission object, represented as a trituple of database, table, and column. All fields are empty for Global-level permissions.</para>
                /// </summary>
                [NameInMap("PrivilegeObject")]
                [Validation(Required=false)]
                public DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject PrivilegeObject { get; set; }
                public class DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject : TeaModel {
                    /// <summary>
                    /// <para>The column name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tdb1</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <para>Description of the permission object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id of table</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table1</para>
                    /// </summary>
                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// <para>The permission level, returned by the <c>DescribeEnabledPrivileges</c> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public string PrivilegeType { get; set; }

                /// <summary>
                /// <para>List of permissions.</para>
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public List<string> Privileges { get; set; }

            }

            /// <summary>
            /// <para>If the response is truncated, this field is <c>true</c>. Continue calling this operation until this field becomes <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Truncated")]
            [Validation(Required=false)]
            public bool? Truncated { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BB185E9-BB54-1727-B876-13243E4C0EB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

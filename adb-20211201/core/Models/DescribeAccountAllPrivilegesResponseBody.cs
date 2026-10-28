// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountAllPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountAllPrivilegesResponseBodyData Data { get; set; }
        public class DescribeAccountAllPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If the <c>Truncated</c> field in the response is <c>true</c>, specify the value of this field in the next call to retrieve the subsequent entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0573e74fd1ccb01739993a691e876074db6e1b6ad79f54115f0e98528432ba6a523cfec5780ade5189299cc3396f6ff7</para>
            /// </summary>
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The list of permissions.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAccountAllPrivilegesResponseBodyDataResult> Result { get; set; }
            public class DescribeAccountAllPrivilegesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The permission object, which is a triplet of the database, table, and column. All fields are empty when the permission level is Global.</para>
                /// </summary>
                [NameInMap("PrivilegeObject")]
                [Validation(Required=false)]
                public DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject PrivilegeObject { get; set; }
                public class DescribeAccountAllPrivilegesResponseBodyDataResultPrivilegeObject : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Column")]
                    [Validation(Required=false)]
                    public string Column { get; set; }

                    /// <summary>
                    /// <para>The name of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tdb1</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <para>The description of the permission object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id of table</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table1</para>
                    /// </summary>
                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// <para>The permission level, which is obtained from the <c>DescribeEnabledPrivileges</c> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public string PrivilegeType { get; set; }

                /// <summary>
                /// <para>The list of permissions.</para>
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public List<string> Privileges { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the returned content is truncated. If the value is <c>true</c>, the returned content is truncated, and you must continue to call this operation to retrieve the remaining entries until the value is <c>false</c>.</para>
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

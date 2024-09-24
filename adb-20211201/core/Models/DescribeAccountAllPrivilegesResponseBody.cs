// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAccountAllPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the permissions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountAllPrivilegesResponseBodyData Data { get; set; }
        public class DescribeAccountAllPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the position where the results are truncated. When a value of <c>true</c> is returned for the <c>Truncated</c> parameter, this parameter is present and contains the value to use for the Marker parameter in a subsequent call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0573e74fd1ccb01739993a691e876074db6e1b6ad79f54115f0e98528432ba6a523cfec5780ade5189299cc3396f6ff7</para>
            /// </summary>
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The permissions.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAccountAllPrivilegesResponseBodyDataResult> Result { get; set; }
            public class DescribeAccountAllPrivilegesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The objects on which the permission takes effect, including databases, tables, and columns. If Global is returned for the PrivilegeType parameter, an empty string is returned for this parameter.</para>
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
                /// <para>The permission level of the database account. You can call the <c>DescribeEnabledPrivileges</c> operation to query the permission level of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Global</para>
                /// </summary>
                [NameInMap("PrivilegeType")]
                [Validation(Required=false)]
                public string PrivilegeType { get; set; }

                /// <summary>
                /// <para>The name of the permission, which is the same as the permission name returned by the <c>DescribeEnabledPrivileges</c> operation.</para>
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public List<string> Privileges { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the results are truncated. If the results are truncated, a value of <c>true</c> is returned. In this case, you must call this operation again to obtain all the results until a value of <c>false</c> is returned for this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Truncated")]
            [Validation(Required=false)]
            public bool? Truncated { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3BB185E9-BB54-1727-B876-13243E4C0EB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

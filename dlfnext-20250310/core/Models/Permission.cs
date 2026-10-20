// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Permission : TeaModel {
        /// <summary>
        /// <para>The access type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DROP</para>
        /// </summary>
        [NameInMap("access")]
        [Validation(Required=false)]
        public string Access { get; set; }

        /// <summary>
        /// <para>The column masking transformation rules mapped by column name. The key is the column name, and the value is the corresponding masking transformation configuration.</para>
        /// </summary>
        [NameInMap("columnMasking")]
        [Validation(Required=false)]
        public Dictionary<string, ColumnMask> ColumnMasking { get; set; }

        /// <summary>
        /// <para>The custom columns.</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public PermissionColumns Columns { get; set; }
        public class PermissionColumns : TeaModel {
            /// <summary>
            /// <para>The list of included column names.</para>
            /// </summary>
            [NameInMap("columnNames")]
            [Validation(Required=false)]
            public List<string> ColumnNames { get; set; }

            /// <summary>
            /// <para>The list of excluded column names.</para>
            /// </summary>
            [NameInMap("excludedColumnNames")]
            [Validation(Required=false)]
            public List<string> ExcludedColumnNames { get; set; }

        }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database_name</para>
        /// </summary>
        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1762398431157</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>function_name</para>
        /// </summary>
        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// <para>The user resource descriptor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:user/user_name</para>
        /// </summary>
        [NameInMap("principal")]
        [Validation(Required=false)]
        public string Principal { get; set; }

        /// <summary>
        /// <para>The permission resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALOG</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The row filter.</para>
        /// </summary>
        [NameInMap("rowFilter")]
        [Validation(Required=false)]
        public RowFilter RowFilter { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// <para>The view name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view_name</para>
        /// </summary>
        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}

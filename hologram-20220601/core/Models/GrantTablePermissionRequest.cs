// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GrantTablePermissionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to grant permissions on all existing tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allTable")]
        [Validation(Required=false)]
        public bool? AllTable { get; set; }

        /// <summary>
        /// <para>The list of column names to grant permissions on.</para>
        /// </summary>
        [NameInMap("columnNames")]
        [Validation(Required=false)]
        public List<string> ColumnNames { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The list of permissions.</para>
        /// </summary>
        [NameInMap("privileges")]
        [Validation(Required=false)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// <para>The schema name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_schema</para>
        /// </summary>
        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders_pay</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The user ID. For more information, see <a href="https://help.aliyun.com/document_detail/130393.html">Hologres account overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_1234xxxx</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

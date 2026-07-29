// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GrantSchemaPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_demo</para>
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
        /// <para>The user ID. For more information, see <a href="https://help.aliyun.com/document_detail/130393.html">Hologres account overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_134xxx</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

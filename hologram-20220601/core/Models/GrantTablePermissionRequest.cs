// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GrantTablePermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("allTable")]
        [Validation(Required=false)]
        public bool? AllTable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_db</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("privileges")]
        [Validation(Required=false)]
        public List<string> Privileges { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_schema</para>
        /// </summary>
        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>orders_pay</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p4_1234xxxx</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

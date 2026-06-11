// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabaseObject : TeaModel {
        /// <summary>
        /// <para>The fully qualified name of the database. This name uniquely identifies the database within the system.</para>
        /// </summary>
        [NameInMap("DatabaseQualifiedName")]
        [Validation(Required=false)]
        public string DatabaseQualifiedName { get; set; }

        /// <summary>
        /// <para>The unique identifier (UUID) of the database that contains the object.</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The Data Definition Language (DDL) SQL statement that defines the object\&quot;s structure.</para>
        /// </summary>
        [NameInMap("DdlSql")]
        [Validation(Required=false)]
        public string DdlSql { get; set; }

        /// <summary>
        /// <para>The name of the database object, such as a table, view, or index.</para>
        /// </summary>
        [NameInMap("ObjectName")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

        /// <summary>
        /// <para>The fully qualified name that uniquely identifies the object, typically formatted as <database>.<schema>.<object>.</para>
        /// </summary>
        [NameInMap("ObjectQualifiedName")]
        [Validation(Required=false)]
        public string ObjectQualifiedName { get; set; }

        /// <summary>
        /// <para>The type of the database object. For example, <c>TABLE</c>, <c>VIEW</c>, or <c>INDEX</c>.</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateAgenticSqlExecuteCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1xxxxxxxx</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The UUID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f8e7d6c-xxxx-xxxx-xxxx-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the database. If you specify this parameter, the credential is restricted to this database. You can call the ListDatabases operation to obtain the UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6c4e8a2b-xxxx-xxxx-xxxx-0f1d2e3c4b5a</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the database. This parameter must be used together with CatalogUuid or CatalogName.</para>
        /// <list type="bullet">
        /// <item><description>MySQL database: The value is the same as the database name.</description></item>
        /// <item><description>PostgreSQL database or other databases with schemas: The value is in the database.schema format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabaseEngineMeta : TeaModel {
        /// <summary>
        /// <para>The name of the database catalog.</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The character encoding for the database.</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The name of the database schema.</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The storage capacity of the database, in GB.</para>
        /// </summary>
        [NameInMap("StorageCapacity")]
        [Validation(Required=false)]
        public long? StorageCapacity { get; set; }

    }

}

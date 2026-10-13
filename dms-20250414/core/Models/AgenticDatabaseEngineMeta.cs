// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabaseEngineMeta : TeaModel {
        /// <summary>
        /// <para>The catalog name in the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>def</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The character set encoding of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The schema name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The storage capacity of the database, in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("StorageCapacity")]
        [Validation(Required=false)]
        public long? StorageCapacity { get; set; }

    }

}

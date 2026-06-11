// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableBaseInfo : TeaModel {
        /// <summary>
        /// <para>The catalog type.</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The database\&quot;s unique identifier.</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The table description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The engine metadata.</para>
        /// </summary>
        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public AgenticTableEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The table\&quot;s qualified name.</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The table type.</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <para>The table\&quot;s unique identifier.</para>
        /// </summary>
        [NameInMap("TableUuid")]
        [Validation(Required=false)]
        public string TableUuid { get; set; }

    }

}

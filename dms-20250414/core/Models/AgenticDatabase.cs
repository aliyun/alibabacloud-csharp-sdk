// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticDatabase : TeaModel {
        /// <summary>
        /// <para>The name of the catalog.</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The type of the catalog.</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the catalog.</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The data source type, such as <c>MySQL</c> or <c>PostgreSQL</c>.</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The database\&quot;s business attributes.</para>
        /// </summary>
        [NameInMap("DatabaseBizAttrs")]
        [Validation(Required=false)]
        public Dictionary<string, object> DatabaseBizAttrs { get; set; }

        /// <summary>
        /// <para>The unique identifier of the database.</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The database description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata for the database engine.</para>
        /// </summary>
        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public AgenticDatabaseEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The database\&quot;s extended properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The fully qualified name of the database.</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The region ID of the database.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name used to search the database.</para>
        /// </summary>
        [NameInMap("SearchName")]
        [Validation(Required=false)]
        public string SearchName { get; set; }

        /// <summary>
        /// <para>The database state.</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The database storage location.</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}

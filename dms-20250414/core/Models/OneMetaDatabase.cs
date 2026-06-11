// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaDatabase : TeaModel {
        /// <summary>
        /// <para>The catalog name.</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The catalog type.</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The catalog UUID.</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The business attributes of the database.</para>
        /// </summary>
        [NameInMap("DatabaseBizAttrs")]
        [Validation(Required=false)]
        public Dictionary<string, object> DatabaseBizAttrs { get; set; }

        /// <summary>
        /// <para>The database UUID.</para>
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

        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public OneMetaDatabaseEngineMeta EngineMeta { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended properties of the database.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The qualified name of the database.</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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

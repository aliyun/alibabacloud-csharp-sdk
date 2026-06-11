// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticCatalog : TeaModel {
        /// <summary>
        /// <para>A collection of key-value pairs that represents business attributes for the catalog, such as the data owner or department.</para>
        /// </summary>
        [NameInMap("CatalogBizAttrs")]
        [Validation(Required=false)]
        public Dictionary<string, object> CatalogBizAttrs { get; set; }

        /// <summary>
        /// <para>The type of the catalog. For example, <c>INTERNAL_METADATA</c> or <c>THIRD_PARTY</c>.</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The unique identifier (UUID) of the catalog. This parameter is system-generated and output-only.</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The type of the data source associated with the catalog. For example, <c>MySQL</c>, <c>PostgreSQL</c>, or <c>OSS</c>.</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The unique identifier (UUID) of the associated data source.</para>
        /// </summary>
        [NameInMap("DataSourceUuid")]
        [Validation(Required=false)]
        public string DataSourceUuid { get; set; }

        /// <summary>
        /// <para>The description of the catalog. It can be up to 2,048 characters long.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the catalog. The name can be up to 256 characters long.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>A collection of key-value pairs that represents additional technical properties for the catalog.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The ID of the region where the catalog is located. For example, <c>cn-hangzhou</c>.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The current state of the catalog. Valid values are: <c>0</c> (Creating), <c>1</c> (Active), <c>2</c> (Deleting), and <c>3</c> (Error).</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        /// <summary>
        /// <para>The storage location for the catalog\&quot;s metadata, such as a database name or a file path.</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}

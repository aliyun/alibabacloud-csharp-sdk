// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineageRelationshipsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination entity. You can refer to the table or field ID returned by the ListTables or ListColumns operation, or use a custom entity ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("DstEntityId")]
        [Validation(Required=false)]
        public string DstEntityId { get; set; }

        /// <summary>
        /// <para>The name of the destination entity. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dstName</para>
        /// </summary>
        [NameInMap("DstEntityName")]
        [Validation(Required=false)]
        public string DstEntityName { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order.</description></item>
        /// <item><description>Desc: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Default value: Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the source entity. You can refer to the table or field ID returned by the ListTables or ListColumns operation, or use a custom entity ID.</para>
        /// <para>To obtain the entity ID of a table or field, first call ListCrawlers to obtain the MetaEntityId of the metadata crawler. For types that include a data catalog hierarchy, such as DLF and StarRocks, call ListCatalogs to obtain the catalog ID. Then, call ListDatabases to obtain the database ID, and call ListSchemas to obtain the schema ID if necessary. Finally, call ListTables or ListColumns to obtain the table or field ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("SrcEntityId")]
        [Validation(Required=false)]
        public string SrcEntityId { get; set; }

        /// <summary>
        /// <para>The name of the source entity. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>srcName</para>
        /// </summary>
        [NameInMap("SrcEntityName")]
        [Validation(Required=false)]
        public string SrcEntityName { get; set; }

    }

}

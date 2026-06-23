// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineageRelationshipsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination entity. You can get the ID for a table or column from the response of the <c>ListTables</c> or <c>ListColumns</c> operation, or specify the ID of a custom entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("DstEntityId")]
        [Validation(Required=false)]
        public string DstEntityId { get; set; }

        /// <summary>
        /// <para>The name of the destination entity. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dstName</para>
        /// </summary>
        [NameInMap("DstEntityName")]
        [Validation(Required=false)]
        public string DstEntityName { get; set; }

        /// <summary>
        /// <para>The sort order. The default value is <c>Asc</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending order</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. The default value is 10. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. The default value is <c>Name</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the source entity. You can get the ID for a table or column from the response of the <c>ListTables</c> or <c>ListColumns</c> operation, or specify the ID of a custom entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("SrcEntityId")]
        [Validation(Required=false)]
        public string SrcEntityId { get; set; }

        /// <summary>
        /// <para>The name of the source entity. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>srcName</para>
        /// </summary>
        [NameInMap("SrcEntityName")]
        [Validation(Required=false)]
        public string SrcEntityName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineagesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the destination entity. This can be a table or column ID returned by the <c>ListTables</c> or <c>ListColumns</c> API, or the ID of a custom entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("DstEntityId")]
        [Validation(Required=false)]
        public string DstEntityId { get; set; }

        /// <summary>
        /// <para>The name of the destination entity. This parameter supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dstName1</para>
        /// </summary>
        [NameInMap("DstEntityName")]
        [Validation(Required=false)]
        public string DstEntityName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include lineage relationships. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAttachRelationship")]
        [Validation(Required=false)]
        public bool? NeedAttachRelationship { get; set; }

        /// <summary>
        /// <para>The sort order. Default: <c>Asc</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Asc</c>: ascending</para>
        /// </description></item>
        /// <item><description><para><c>Desc</c>: descending</para>
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
        /// <para>The page number to retrieve. Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. The default is <c>Name</c>, which sorts by entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the source entity. This can be a table or column ID returned by the <c>ListTables</c> or <c>ListColumns</c> API, or the ID of a custom entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("SrcEntityId")]
        [Validation(Required=false)]
        public string SrcEntityId { get; set; }

        /// <summary>
        /// <para>The name of the source entity. This parameter supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>srcName1</para>
        /// </summary>
        [NameInMap("SrcEntityName")]
        [Validation(Required=false)]
        public string SrcEntityName { get; set; }

    }

}

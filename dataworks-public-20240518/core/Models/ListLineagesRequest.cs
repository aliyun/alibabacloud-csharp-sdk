// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineagesRequest : TeaModel {
        /// <summary>
        /// <para>The destination entity ID. You can use the table or column ID returned by the ListTables or ListColumns operation, or a custom entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-table::catalog_id:database_name::table_name</para>
        /// </summary>
        [NameInMap("DstEntityId")]
        [Validation(Required=false)]
        public string DstEntityId { get; set; }

        /// <summary>
        /// <para>The destination entity name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dstName1</para>
        /// </summary>
        [NameInMap("DstEntityName")]
        [Validation(Required=false)]
        public string DstEntityName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return lineage relationship information. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAttachRelationship")]
        [Validation(Required=false)]
        public bool? NeedAttachRelationship { get; set; }

        /// <summary>
        /// <para>The sort direction. Default value: Asc. Valid values:</para>
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
        /// <para>The page size. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecentDays")]
        [Validation(Required=false)]
        public int? RecentDays { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: Name, which sorts by lineage entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source entity ID. You can use the table or column ID returned by the ListTables or ListColumns operation, or a custom entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("SrcEntityId")]
        [Validation(Required=false)]
        public string SrcEntityId { get; set; }

        /// <summary>
        /// <para>The source entity name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>srcName1</para>
        /// </summary>
        [NameInMap("SrcEntityName")]
        [Validation(Required=false)]
        public string SrcEntityName { get; set; }

    }

}

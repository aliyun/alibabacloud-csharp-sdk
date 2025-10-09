// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListLineageRelationshipsRequest : TeaModel {
        /// <summary>
        /// <para>The destination entity ID. For more information, see the table ID or field ID in the response returned by the ListTables or ListColumns operation. You can also specify a custom entity ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456XXX::test_project::test_tbl
        /// dlf-table:123456XXX:test_catalog:test_db::test_tbl
        /// hms-table:c-abc123xxx::test_db::test_tbl
        /// holo-table:h-abc123xxx::test_db:test_schema:test_tbl
        /// custom-api:api123
        /// custom-table:table456</para>
        /// </summary>
        [NameInMap("DstEntityId")]
        [Validation(Required=false)]
        public string DstEntityId { get; set; }

        /// <summary>
        /// <para>The destination entity name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dstName</para>
        /// </summary>
        [NameInMap("DstEntityName")]
        [Validation(Required=false)]
        public string DstEntityName { get; set; }

        /// <summary>
        /// <para>The order in which schemas are sorted. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending.</description></item>
        /// <item><description>Desc: descending.</description></item>
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
        /// <para>The sort field. Default value: Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source entity ID. For more information, see the table ID or field ID in the response returned by the ListTables or ListColumns operation. You can also specify a custom entity ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456XXX::test_project::test_tbl
        /// dlf-table:123456XXX:test_catalog:test_db::test_tbl
        /// hms-table:c-abc123xxx::test_db::test_tbl
        /// holo-table:h-abc123xxx::test_db:test_schema:test_tbl
        /// custom-api:api123
        /// custom-table:table456</para>
        /// </summary>
        [NameInMap("SrcEntityId")]
        [Validation(Required=false)]
        public string SrcEntityId { get; set; }

        /// <summary>
        /// <para>The source entity name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>srcName</para>
        /// </summary>
        [NameInMap("SrcEntityName")]
        [Validation(Required=false)]
        public string SrcEntityName { get; set; }

    }

}

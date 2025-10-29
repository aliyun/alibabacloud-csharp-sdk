// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDatabasesRequest : TeaModel {
        /// <summary>
        /// <para>The comment. Supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name. Supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: Asc. Valid values:</para>
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
        /// <para>The number of records per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>You can refer to the ListCrawlerTypes operation for the parent entity type.</para>
        /// <list type="bullet">
        /// <item><description>If the parent entity is a catalog, the format of <c>ParentMetaEntityId</c> follows the response of the ListCatalogs API.</description></item>
        /// <item><description>If the parent entity is a metadata crawler, the format of <c>ParentMetaEntityId</c> is <c>${CrawlerType}:${Instance ID or encoded URL}</c>.</description></item>
        /// </list>
        /// <para>ParentMetaEntityId format examples</para>
        /// <list type="bullet">
        /// <item><description><c>dlf-catalog::catalog_id</c></description></item>
        /// <item><description><c>holo:instance_id</c></description></item>
        /// <item><description><c>mysql:(instance_id|encoded_jdbc_url)</c></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><c>catalog_id</c>: The ID of the DLF catalog.</description></item>
        /// <item><description><c>instance_id</c>: The instance ID. Required when the data source is registered in instance mode.</description></item>
        /// <item><description><c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. Required when the data source is registered by connection string.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql:rm-abc123xxx
        /// dlf-catalog:123456XXX:test_catalog</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime</description></item>
        /// <item><description>ModifyTime</description></item>
        /// <item><description>Name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDatabasesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">description of concepts related to metadata entities.</a></para>
        /// <para>The type of the parent entity can be found in the response of the ListCrawlerTypes operation.</para>
        /// <list type="bullet">
        /// <item><description>If the parent entity is a catalog, the format of <c>ParentMetaEntityId</c> follows the response of the ListCatalogs API.</description></item>
        /// <item><description>If the parent entity is a metadata crawler, the format of <c>ParentMetaEntityId</c> is <c>${CrawlerType}:${Instance ID or encoded URL}.</c></description></item>
        /// </list>
        /// <para>ParentMetaEntityId format examples</para>
        /// <para><c>dlf-catalog::catalog_id</c></para>
        /// <para><c>holo:instance_id</c></para>
        /// <para><c>mysql:(instance_id|encoded_jdbc_url)</c></para>
        /// <remarks>
        /// <para>\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>instance_id</c>: The instance ID, required for the data source registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The JDBC connection string that has been URL encoded, required for the data source registered via a connection string.</para>
        /// </remarks>
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
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}

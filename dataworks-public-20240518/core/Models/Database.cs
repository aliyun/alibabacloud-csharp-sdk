// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Database : TeaModel {
        /// <summary>
        /// <para>The comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The database ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>The common format of this parameter is <c>${Entity type}:${Instance ID or escaped URL}:${Catalog identifier}:${Database name}</c>. If a level does not exist, specify an empty string as a placeholder.</para>
        /// <remarks>
        /// <para> For StarRocks data sources, specify a catalog name at the Catalog identifier level. For DLF data sources, specify a catalog ID at the Catalog identifier level. Other types of data sources do not support the Catalog identifier level. You can specify an empty string as a placeholder.</para>
        /// </remarks>
        /// <para>You can configure this parameter in one of the following formats based on your data source type:</para>
        /// <para><c>dlf-database::catalog_id:database_name</c></para>
        /// <para><c>holo-database:instance_id::database_name</c></para>
        /// <para><c>mysql-database:(instance_id|encoded_jdbc_url)::database_name</c></para>
        /// <remarks>
        /// <para>\
        /// <c>catalog_id</c>: the ID of a DLF catalog.\
        /// <c>instance_id</c>: the ID of an instance. If the related data source is added to DataWorks in Alibaba Cloud instance mode, you must configure this parameter.\
        /// <c>encoded_jdbc_url</c>: the JDBC connection string that is URL-encoded. If the related data source is added to DataWorks in connection string mode, you must configure this parameter.\
        /// <c>database_name</c>: the name of a database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>holo-database:h-xxxx::test_db</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The uniform resource identifier (URI) of the storage location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test_db</para>
        /// </summary>
        [NameInMap("LocationUri")]
        [Validation(Required=false)]
        public string LocationUri { get; set; }

        /// <summary>
        /// <para>The update time. This value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736852168000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parent entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>You can call the ListCrawlerTypes operation to query the parent entity types.</para>
        /// <list type="bullet">
        /// <item><description>If the parent entity is a catalog, you can configure the <c>ParentMetaEntityId</c> parameter by referring to the <c>Catalog</c> topic.</description></item>
        /// <item><description>If the parent entity is a metadata crawler, you can configure the <c>ParentMetaEntityId</c> parameter in the <c>${Crawler type}:${Instance ID or escaped URL}</c> format.</description></item>
        /// </list>
        /// <para>You can configure the ParentMetaEntityId parameter in one of the following formats based on your data source type:</para>
        /// <para><c>dlf-catalog::catalog_id</c></para>
        /// <para><c>holo:instance_id</c></para>
        /// <para><c>mysql:(instance_id|encoded_jdbc_url)</c></para>
        /// <remarks>
        /// <para>\
        /// <c>catalog_id</c>: the ID of a DLF catalog.\
        /// <c>instance_id</c>: the ID of an instance. If the related data source is added to DataWorks in Alibaba Cloud instance mode, you must configure this parameter.\
        /// <c>encoded_jdbc_url</c>: the JDBC connection string that is URL-encoded. If the related data source is added to DataWorks in connection string mode, you must configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>holo:h-xxxx</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

    }

}

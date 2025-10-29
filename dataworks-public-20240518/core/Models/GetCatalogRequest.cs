// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The catalog entity ID. Currently supports dlf and starrocks types. You can refer to the results returned by the ListCatalogs operation and the <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <list type="bullet">
        /// <item><description>For the DLF type, the format is <c>dlf-catalog::catalog_id</c>.</description></item>
        /// <item><description>For the StarRocks type, the format is <c>starrocks-catalog:(instance_id|encoded_jdbc_url):catalog_name</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>\
        /// <c>catalog_id</c>: The ID of the DLF catalog.\
        /// <c>instance_id</c>: The instance ID, required if the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string. Required if the data source is registered in connection string mode.\
        /// <c>catalog_name</c>: The name of the StarRocks catalog.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-catalog:123456XXX:test_catalog
        /// starrocks-catalog:c-abc123xxx:default_catalog</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCatalogRequest : TeaModel {
        /// <summary>
        /// <para>Data catalog entity ID. Currently, only DLF and StarRocks types are supported. You can refer to the response of the ListCatalogs operation and <a href="https://help.aliyun.com/document_detail/2880092.html">the description of metadata entity concepts.</a></para>
        /// <list type="bullet">
        /// <item><description>For the DLF type, the format is <c>dlf-catalog::catalog_id</c>.</description></item>
        /// <item><description>For the StarRocks type, the format is <c>starrocks-catalog:(instance_id|encoded_jdbc_url):catalog_name</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Parameter descriptions:\
        /// <c>catalog_id</c>: The DLF catalog ID.\
        /// <c>instance_id</c>: The instance ID, required for the data source registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The JDBC connection string that has been URL encoded, required for the data source registered via a connection string.\
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

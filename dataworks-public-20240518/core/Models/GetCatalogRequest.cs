// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data catalog entity. Currently, DLF and StarRocks types are supported. You can obtain the ID from the response of the ListCatalogs operation. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>For the DLF type, the format is <c>dlf-catalog::catalog_id</c>.</para>
        /// </description></item>
        /// <item><description><para>For the StarRocks type, the format is <c>starrocks-catalog:(instance_id|encoded_jdbc_url):catalog_name</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Where<br><c>catalog_id</c>: the ID of the DLF catalog.<br><c>instance_id</c>: the instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered in connection string mode.<br><c>catalog_name</c>: the name of the StarRocks catalog.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-catalog::catalog_id</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}

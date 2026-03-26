// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Catalog : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722073854000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The catalog ID. Currently, only the DLF and StarRocks types are supported. For details, see <a href="https://help.aliyun.com/document_detail/2880092.html">description of concepts related to metadata entities.</a></para>
        /// <list type="bullet">
        /// <item><description>For the DLF type, the format is <c>dlf-catalog::catalog_id</c>.</description></item>
        /// <item><description>For the starrocks type, the format is <c>starrocks-catalog:(instance_id|encoded_jdbc_url):catalog_name</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>\
        /// <c>catalog_id</c>: The the DLF catalog ID.\
        /// <c>instance_id</c>: The instance ID, required if the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, required if the data source is registered using a connection string.\
        /// <c>catalog_name</c>: The StarRocks catalog name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-catalog:123456XXX:test_catalog
        /// starrocks-catalog:c-abc123xxx:default_catalog</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The modification time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1722073854000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The catalog name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_catalog</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parent entity ID.</para>
        /// <list type="bullet">
        /// <item><description>For the DLF type, the format of <c>ParentMetaEntityId</c> is <c>dlf</c>.</description></item>
        /// <item><description>For the StarRocks type, the format of <c>ParentMetaEntityId</c> is <c>starrocks:(instance_id|encoded_jdbc_url)</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>\
        /// <c>instance_id</c>: The instance ID, required when the data source is registered in instance mode.\
        /// <c>encoded_jdbc_url</c>: The URL-encoded JDBC connection string, required if the data source is registered via a connection string.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf
        /// starrocks:c-abc123xxx</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The catalog type. The value of this parameter varies based on the type of the metadata crawler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

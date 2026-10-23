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
        /// <para>Default catalog</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725330777000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the data catalog entity. Currently, the DLF and StarRocks types are supported. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts of metadata entities</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>For the DLF type, the format is <c>dlf-catalog::catalog_id</c>.</para>
        /// </description></item>
        /// <item><description><para>For the StarRocks type, the format is <c>starrocks-catalog:(instance_id|encoded_jdbc_url):catalog_name</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Where:<br><c>catalog_id</c>: The DLF catalog ID.<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered by using a connection string.<br><c>catalog_name</c>: the name of the StarRocks catalog.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf-catalog::catalog1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The modification time. The value is a millisecond-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725330777000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>catalog1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the parent entity.</para>
        /// <list type="bullet">
        /// <item><description><para>For the DLF type, the format of <c>ParentMetaEntityId</c> is <c>dlf</c>.</para>
        /// </description></item>
        /// <item><description><para>For the StarRocks type, the format of <c>ParentMetaEntityId</c> is <c>starrocks:(instance_id|encoded_jdbc_url)</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Where:<br><c>instance_id</c>: The instance ID, which is required when the data source is registered in instance mode.<br><c>encoded_jdbc_url</c>: the URL-encoded JDBC connection string, which is required when the data source is registered by using a connection string.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dlf</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The catalog type. The valid values depend on the metadata collector type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIVE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCatalogsRequest : TeaModel {
        /// <summary>
        /// <para>The comment. Supports token-based matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name. Supports fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order in which the tables are sorted. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Asc: ascending order.</para>
        /// </description></item>
        /// <item><description><para>Desc: descending order.</para>
        /// </description></item>
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
        /// <para>The number of records per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parent entity ID. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>Currently, only the DLF and StarRocks types are supported.</para>
        /// <list type="bullet">
        /// <item><description><para>For the DLF type, you can query all catalog lists. The format of <c>ParentMetaEntityId</c> is <c>DLF</c>.</para>
        /// </description></item>
        /// <item><description><para>For the StarRocks type, you can query the catalogs of a specific instance. The format of <c>ParentMetaEntityId</c> <c>is StarRocks:(instance_id|encoded_jdbc_url)</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><br><c>instance_id</c>: The instance ID. Required if the data source is registered in instance mode.<br>
        /// <c>encoded_jdbc_url</c>: The JDBC connection string encoded with URL encoding. Required if the data source is registered in connection-string mode.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlf</para>
        /// </summary>
        [NameInMap("ParentMetaEntityId")]
        [Validation(Required=false)]
        public string ParentMetaEntityId { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime</para>
        /// </description></item>
        /// <item><description><para>ModifyTime</para>
        /// </description></item>
        /// <item><description><para>Name</para>
        /// </description></item>
        /// <item><description><para>Type</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type. Supports exact match. If left empty, all types are queried.</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}

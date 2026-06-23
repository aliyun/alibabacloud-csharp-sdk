// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPartitionsRequest : TeaModel {
        /// <summary>
        /// <para>The partition name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20250101</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Asc: Ascending order.</para>
        /// </description></item>
        /// <item><description><para>Desc: Descending order.</para>
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
        /// <para>The page number. Default: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime: Creation time. Supported only for MaxCompute tables.</para>
        /// </description></item>
        /// <item><description><para>ModifyTime: Modification time. Supported only for MaxCompute tables.</para>
        /// </description></item>
        /// <item><description><para>Name: Name. Used for HMS-type tables.</para>
        /// </description></item>
        /// <item><description><para>RecordCount: Record count. Supported only for MaxCompute tables.</para>
        /// </description></item>
        /// <item><description><para>DataSize: Storage size. Supported only for MaxCompute tables.</para>
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
        /// <para>The ID of the data table.You can refer to the ListTables API response and <a href="https://help.aliyun.com/document_detail/2880092.html">Concepts related to metadata entities</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

    }

}

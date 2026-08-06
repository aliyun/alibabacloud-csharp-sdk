// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPartitionsRequest : TeaModel {
        /// <summary>
        /// <para>The partition name. Fuzzy match is supported. This parameter is valid only for MaxCompute tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20250101</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort direction. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order.</description></item>
        /// <item><description>Desc: descending order.</description></item>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Default value: CreateTime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTime: the creation time. Only MaxCompute tables are supported.</description></item>
        /// <item><description>ModifyTime: the modification time. Only MaxCompute tables are supported.</description></item>
        /// <item><description>Name: the name. This is the sort method used for HMS tables.</description></item>
        /// <item><description>RecordCount: the number of records. Only MaxCompute tables are supported.</description></item>
        /// <item><description>DataSize: the storage size. Only MaxCompute tables are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the table. You can obtain this value from the response of the <a href="https://help.aliyun.com/document_detail/2880092.html">ListTables</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
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

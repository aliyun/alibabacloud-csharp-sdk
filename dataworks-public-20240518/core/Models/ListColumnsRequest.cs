// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The comment. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("IncludeExtendedProperties")]
        [Validation(Required=false)]
        public bool? IncludeExtendedProperties { get; set; }

        /// <summary>
        /// <para>The name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: Asc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: ascending order</description></item>
        /// <item><description>Desc: descending order</description></item>
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
        /// <para>The sort field. Default value: Position. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Name: name</description></item>
        /// <item><description>Position: position</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Position</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the data table. You can obtain the ID from the response of the ListTables operation. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata entity concepts</a>.</para>
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

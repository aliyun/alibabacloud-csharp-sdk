// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCustomAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The comment on the custom attribute. The service performs a fuzzy search based on this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The display name of the custom attribute. The service performs a partial match based on this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Owner</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The entity types to which the custom attribute applies. To specify multiple entity types, separate them with commas (,), for example, <c>*-table,*-column</c>. This parameter supports specific entity types, such as <c>hms-table</c> and <c>emr-table</c>, and wildcard types, such as <c>*-table</c> and <c>*-column</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table</para>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public string EntityTypes { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values: Asc and Desc.</para>
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
        /// <para>The field to sort by. Valid values: CreateTime and ModifyTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}

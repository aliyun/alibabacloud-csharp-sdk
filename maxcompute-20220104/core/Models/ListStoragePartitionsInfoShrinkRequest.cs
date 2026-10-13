// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStoragePartitionsInfoShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The statistical date at the day level. Specify the time parameter in the YYYYMMdd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241205</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The sort column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>totalFrequency</para>
        /// </summary>
        [NameInMap("orderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The partition name for fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241201</para>
        /// </summary>
        [NameInMap("partitionPrefix")]
        [Validation(Required=false)]
        public string PartitionPrefix { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The name of the schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schema</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can view the tenant ID by logging on to the MaxCompute console and choosing <b>Tenant Management</b> &gt; <b>Tenant Properties</b> in the left-side navigation pane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40713753659****</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The storage types.</para>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string TypesShrink { get; set; }

    }

}

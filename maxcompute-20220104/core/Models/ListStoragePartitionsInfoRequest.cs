// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStoragePartitionsInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort data in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The date on which the statistics are collected, in days. Set this parameter to a value in the YYYYMMdd format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20241205</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The sorting column.</para>
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
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the partition that you want to use for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20241201</para>
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
        /// <para>The ID of the tenant. You can log on to the MaxCompute console, and choose <b>Tenants</b> &gt; <b>Tenant Property</b> from the left-side navigation pane to view the tenant ID.</para>
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
        public List<string> Types { get; set; }

    }

}

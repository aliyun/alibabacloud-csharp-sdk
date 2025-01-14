// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek2kqofrgXXXXX</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public string AliyunResourceTagsShrink { get; set; }

        /// <summary>
        /// <para>The name of a resource group, which is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resource</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResourceGroupTypes")]
        [Validation(Required=false)]
        public string ResourceGroupTypesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CreateTime Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}

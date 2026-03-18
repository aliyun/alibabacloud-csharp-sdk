// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subscription</para>
        /// </summary>
        [NameInMap("billingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which to start returning results. The results are sorted in alphabetical order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public long? MaxItem { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("productId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ProductId { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("region")]
        [Validation(Required=false)]
        [Obsolete]
        public string Region { get; set; }

        /// <summary>
        /// <para>The cost allocation tags that are used to filter quotas. You can create cost allocation tags in the Tag service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tag&quot;:&quot;this_is_tag_demo&quot;}</para>
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

    }

}

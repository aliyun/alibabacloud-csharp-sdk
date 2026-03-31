// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subscription</para>
        /// </summary>
        [NameInMap("billingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>Specifies the marker after which the returned list begins.</para>
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
        /// 
        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ProductId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        [Obsolete]
        public string Region { get; set; }

        /// <summary>
        /// <para>The cost tag. You can filter out quota objects based on the cost tag. The cost tag is created when you tag a service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tag&quot;:&quot;this_is_tag_demo&quot;}</para>
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>280747109771520</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

    }

}

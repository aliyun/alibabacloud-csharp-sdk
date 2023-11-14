// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListQuotasRequest : TeaModel {
        /// <summary>
        /// The billing method of the quota.
        /// </summary>
        [NameInMap("billingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// Specifies the marker after which the returned list begins.
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("maxItem")]
        [Validation(Required=false)]
        public long? MaxItem { get; set; }

        /// <summary>
        /// The service ID.
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The cost tag. You can filter out quota objects based on the cost tag. The cost tag is created when you tag a service.
        /// </summary>
        [NameInMap("saleTags")]
        [Validation(Required=false)]
        public string SaleTags { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}

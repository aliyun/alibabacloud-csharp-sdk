// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends. An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The information of the Alibaba Cloud service.
        /// </summary>
        [NameInMap("ProductInfo")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProductInfo> ProductInfo { get; set; }
        public class ListProductsResponseBodyProductInfo : TeaModel {
            /// <summary>
            /// Indicates whether the Alibaba Cloud service supports general quotas. Valid values:
            /// 
            /// *   support: The Alibaba Cloud service supports general quotas.
            /// *   unsupport: The Alibaba Cloud service does not support general quotas.
            /// </summary>
            [NameInMap("CommonQuotaSupport")]
            [Validation(Required=false)]
            public string CommonQuotaSupport { get; set; }

            /// <summary>
            /// Indicates whether the Alibaba Cloud service supports dynamic quota adjustment. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            /// <summary>
            /// Indicates whether the Alibaba Cloud service supports API rate limits. Valid values:
            /// 
            /// *   support: The Alibaba Cloud service supports API rate limits.
            /// *   unsupport: The Alibaba Cloud service does not support API rate limits.
            /// </summary>
            [NameInMap("FlowControlSupport")]
            [Validation(Required=false)]
            public string FlowControlSupport { get; set; }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// The English name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ProductNameEn")]
            [Validation(Required=false)]
            public string ProductNameEn { get; set; }

            /// <summary>
            /// The ID of the service category.
            /// </summary>
            [NameInMap("SecondCategoryId")]
            [Validation(Required=false)]
            public long? SecondCategoryId { get; set; }

            /// <summary>
            /// The name of the service category.
            /// </summary>
            [NameInMap("SecondCategoryName")]
            [Validation(Required=false)]
            public string SecondCategoryName { get; set; }

            /// <summary>
            /// The English name of the service category.
            /// </summary>
            [NameInMap("SecondCategoryNameEn")]
            [Validation(Required=false)]
            public string SecondCategoryNameEn { get; set; }

            /// <summary>
            /// Indicates whether the Alibaba Cloud service supports whitelist quotas. Valid values:
            /// 
            /// *   support: The Alibaba Cloud service supports whitelist quotas.
            /// *   unsupport: The Alibaba Cloud service does not support whitelist quotas.
            /// </summary>
            [NameInMap("WhiteListLabelQuotaSupport")]
            [Validation(Required=false)]
            public string WhiteListLabelQuotaSupport { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of records that are returned for the query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

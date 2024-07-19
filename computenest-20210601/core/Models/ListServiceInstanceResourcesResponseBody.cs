// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class ListServiceInstanceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// The time when the resource was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the resource expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The billing method. Valid values:
            /// 
            /// *   Subscription
            /// *   PayAsYouGo
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The code of the cloud service.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The type of the cloud service.
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// The renewal state. Valid values:
            /// 
            /// *   AutoRenewal
            /// *   ManualRenewal
            /// *   NotRenewal
            /// </summary>
            [NameInMap("RenewStatus")]
            [Validation(Required=false)]
            public string RenewStatus { get; set; }

            /// <summary>
            /// The renewal period.
            /// </summary>
            [NameInMap("RenewalPeriod")]
            [Validation(Required=false)]
            public int? RenewalPeriod { get; set; }

            /// <summary>
            /// The unit of the renewal period. Valid values:
            /// 
            /// *   Month
            /// *   Year
            /// </summary>
            [NameInMap("RenewalPeriodUnit")]
            [Validation(Required=false)]
            public string RenewalPeriodUnit { get; set; }

            /// <summary>
            /// The ARN of the resource.
            /// </summary>
            [NameInMap("ResourceARN")]
            [Validation(Required=false)]
            public string ResourceARN { get; set; }

            /// <summary>
            /// The state of the resource. Valid values:
            /// 
            /// *   running
            /// *   waiting
            /// *   terminated
            /// 
            /// >  This parameter is returned only for containers.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

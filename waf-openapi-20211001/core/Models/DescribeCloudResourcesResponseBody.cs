// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// The cloud service resources that are added to WAF.
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public List<DescribeCloudResourcesResponseBodyCloudResources> CloudResources { get; set; }
        public class DescribeCloudResourcesResponseBodyCloudResources : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// The domain name. This parameter has a value only if the value of ResourceProduct is fc or sae.
            /// </summary>
            [NameInMap("ResourceDomain")]
            [Validation(Required=false)]
            public string ResourceDomain { get; set; }

            /// <summary>
            /// The function name. This parameter has a value only if the value of ResourceProduct is fc.
            /// </summary>
            [NameInMap("ResourceFunction")]
            [Validation(Required=false)]
            public string ResourceFunction { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceInstance")]
            [Validation(Required=false)]
            public string ResourceInstance { get; set; }

            /// <summary>
            /// The name of the resource.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// The cloud service to which the resource belongs. Valid values:
            /// 
            /// *   **alb**: ALB.
            /// *   **mse**: MSE.
            /// *   **fc**: Function Compute.
            /// *   **sae**: SAE.
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// The region ID of the resource.
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// The route name. This parameter has a value only if the value of ResourceProduct is mse.
            /// </summary>
            [NameInMap("ResourceRouteName")]
            [Validation(Required=false)]
            public string ResourceRouteName { get; set; }

            /// <summary>
            /// The service name. This parameter has a value only if the value of ResourceProduct is fc.
            /// </summary>
            [NameInMap("ResourceService")]
            [Validation(Required=false)]
            public string ResourceService { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of cloud service resources returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

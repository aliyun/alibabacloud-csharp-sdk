// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeElbAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about resources.
        /// </summary>
        [NameInMap("ElbAvailableResourceInfo")]
        [Validation(Required=false)]
        public List<DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo> ElbAvailableResourceInfo { get; set; }
        public class DescribeElbAvailableResourceInfoResponseBodyElbAvailableResourceInfo : TeaModel {
            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            /// <summary>
            /// The number of resources that you can purchase.
            /// </summary>
            [NameInMap("CanBuyCount")]
            [Validation(Required=false)]
            public string CanBuyCount { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// The ID of the Edge Node Service (ENS) node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The specifications of the ELB instances.
            /// </summary>
            [NameInMap("LoadBalancerSpec")]
            [Validation(Required=false)]
            public List<string> LoadBalancerSpec { get; set; }

            /// <summary>
            /// The Chinese name of the node.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The province where the node is deployed.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// Details of the regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// Indicates whether the region supports scaling groups of the classic network type. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ClassicUnavailable")]
            [Validation(Required=false)]
            public bool? ClassicUnavailable { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The endpoint of the region.
            /// </summary>
            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the region supports scaling groups of the virtual private cloud (VPC) type. Valid values:
            /// 
            /// *   true: The region does not support scaling groups of the VPC type.
            /// *   false: The region supports scaling groups of the VPC type.
            /// </summary>
            [NameInMap("VpcUnavailable")]
            [Validation(Required=false)]
            public bool? VpcUnavailable { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

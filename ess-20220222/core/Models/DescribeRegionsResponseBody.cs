// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The collection of region information.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// Indicates whether the current region supports scaling groups that reside in the classic network. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("ClassicUnavailable")]
            [Validation(Required=false)]
            public bool? ClassicUnavailable { get; set; }

            /// <summary>
            /// The region name.
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The region endpoint.
            /// </summary>
            [NameInMap("RegionEndpoint")]
            [Validation(Required=false)]
            public string RegionEndpoint { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether the current region supports scaling groups that reside in virtual private clouds (VPCs). Valid values:
            /// 
            /// *   true
            /// *   false
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

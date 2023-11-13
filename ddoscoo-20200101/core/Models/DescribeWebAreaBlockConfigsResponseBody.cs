// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAreaBlockConfigsResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the configurations of the Location Blacklist (Domain Names) policy.
        /// </summary>
        [NameInMap("AreaBlockConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs> AreaBlockConfigs { get; set; }
        public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs : TeaModel {
            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The configuration of the blocked locations.
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList> RegionList { get; set; }
            public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList : TeaModel {
                /// <summary>
                /// Indicates whether the location is blocked. Valid values:
                /// 
                /// *   **0**: yes
                /// *   **1**: no
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public int? Block { get; set; }

                /// <summary>
                /// The name of the location.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

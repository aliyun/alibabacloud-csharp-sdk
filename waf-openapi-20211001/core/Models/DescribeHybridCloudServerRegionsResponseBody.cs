// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudServerRegionsResponseBody : TeaModel {
        /// <summary>
        /// The information about the regions.
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudServerRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeHybridCloudServerRegionsResponseBodyRegions : TeaModel {
            /// <summary>
            /// The code of the region.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

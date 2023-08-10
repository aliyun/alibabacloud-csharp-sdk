// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result that was returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyResult> Result { get; set; }
        public class DescribeRegionsResponseBodyResult : TeaModel {
            /// <summary>
            /// The URL of the OpenSearch console.
            /// </summary>
            [NameInMap("consoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }

            /// <summary>
            /// The endpoint of the region.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}

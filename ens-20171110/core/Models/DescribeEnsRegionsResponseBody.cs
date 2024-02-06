// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionsResponseBody : TeaModel {
        /// <summary>
        /// The service code. 0 is returned for a successful request. An error code is returned for a failed request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the regions.
        /// </summary>
        [NameInMap("EnsRegions")]
        [Validation(Required=false)]
        public DescribeEnsRegionsResponseBodyEnsRegions EnsRegions { get; set; }
        public class DescribeEnsRegionsResponseBodyEnsRegions : TeaModel {
            [NameInMap("EnsRegions")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions> EnsRegions { get; set; }
            public class DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions : TeaModel {
                /// <summary>
                /// The code of the region.
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The name of the node.
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

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceResponseBody : TeaModel {
        /// <summary>
        /// The returned data. For more information, see EnsRegionIdResources in sample JSON responses.
        /// </summary>
        [NameInMap("EnsRegionIdResources")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources EnsRegionIdResources { get; set; }
        public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources : TeaModel {
            [NameInMap("EnsRegionIdResource")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource> EnsRegionIdResource { get; set; }
            public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource : TeaModel {
                /// <summary>
                /// The region. Set the value to West.
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// The code of the region.
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// The date when the transaction was processed.
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("EnsRegionIdName")]
                [Validation(Required=false)]
                public string EnsRegionIdName { get; set; }

                /// <summary>
                /// The number of instances.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The public bandwidth of the instance. Unit: Bits/s.
                /// </summary>
                [NameInMap("InternetBandwidth")]
                [Validation(Required=false)]
                public long? InternetBandwidth { get; set; }

                /// <summary>
                /// The ISP. Valid values:
                /// 
                /// *   cmcc: China Mobile
                /// *   unicom: China Unicom
                /// *   telecom: China Telecom
                /// *   multiCarrier: multi-line ISP
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("VCpu")]
                [Validation(Required=false)]
                public int? VCpu { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of queried nodes.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceResponseBody : TeaModel {
        [NameInMap("EnsRegionIdResources")]
        [Validation(Required=false)]
        public DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources EnsRegionIdResources { get; set; }
        public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResources : TeaModel {
            [NameInMap("EnsRegionIdResource")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource> EnsRegionIdResource { get; set; }
            public class DescribeEnsRegionIdResourceResponseBodyEnsRegionIdResourcesEnsRegionIdResource : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("EnsRegionIdName")]
                [Validation(Required=false)]
                public string EnsRegionIdName { get; set; }

                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                [NameInMap("InternetBandwidth")]
                [Validation(Required=false)]
                public long? InternetBandwidth { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("VCpu")]
                [Validation(Required=false)]
                public int? VCpu { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>476600B1-C9E2-4245-A26F-DC7EA8071425</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

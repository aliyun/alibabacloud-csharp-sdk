// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data. For more information, see EnsRegionIdResources in sample JSON responses.</para>
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
                /// <para>The region. Set the value to West.</para>
                /// 
                /// <b>Example:</b>
                /// <para>West</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>The code of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300100</para>
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <para>The date when the transaction was processed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-telecom</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nanjing Mobile</para>
                /// </summary>
                [NameInMap("EnsRegionIdName")]
                [Validation(Required=false)]
                public string EnsRegionIdName { get; set; }

                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// <para>The public bandwidth of the instance. Unit: Bits/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("InternetBandwidth")]
                [Validation(Required=false)]
                public long? InternetBandwidth { get; set; }

                /// <summary>
                /// <para>The ISP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cmcc: China Mobile</description></item>
                /// <item><description>unicom: China Unicom</description></item>
                /// <item><description>telecom: China Telecom</description></item>
                /// <item><description>multiCarrier: multi-line ISP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cmcc</para>
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
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

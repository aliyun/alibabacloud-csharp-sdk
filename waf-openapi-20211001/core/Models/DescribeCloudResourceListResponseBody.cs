// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of resources that are added to WAF.</para>
        /// </summary>
        [NameInMap("CloudResourceList")]
        [Validation(Required=false)]
        public List<DescribeCloudResourceListResponseBodyCloudResourceList> CloudResourceList { get; set; }
        public class DescribeCloudResourceListResponseBodyCloudResourceList : TeaModel {
            /// <summary>
            /// <para>The ID of the protected resource. WAF automatically generates this ID when you add the resource to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdlsd********81e22-80-ecs</para>
            /// </summary>
            [NameInMap("CloudResourceId")]
            [Validation(Required=false)]
            public string CloudResourceId { get; set; }

            /// <summary>
            /// <para>The port of the cloud service that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>http</b>: HTTP</para>
            /// </description></item>
            /// <item><description><para><b>https</b>: HTTPS</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the resource instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdlsd********81e22</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2uo2****lbka</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The cloud service to which the resource belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>alb</b>: ALB.</para>
            /// </description></item>
            /// <item><description><para><b>mse</b>: MSE.</para>
            /// </description></item>
            /// <item><description><para><b>fc</b>: FC.</para>
            /// </description></item>
            /// <item><description><para><b>sae</b>: SAE.</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: ECS.</para>
            /// </description></item>
            /// <item><description><para><b>clb4</b>: CLB that uses the TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: CLB that uses the HTTP or HTTPS protocol.</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: NLB.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The ID of the region where the resource resides. For more information, see the &quot;Regions and supported products&quot; section in this topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// <remarks>
        /// <para>If a value is returned for this parameter, it indicates that a next page is available. To retrieve the next page of data, include the returned <b>NextToken</b> in your next request. Repeat this process until no value is returned, which indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D****E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>118</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

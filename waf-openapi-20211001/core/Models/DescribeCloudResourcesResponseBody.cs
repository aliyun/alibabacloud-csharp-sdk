// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of cloud services.</para>
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public List<DescribeCloudResourcesResponseBodyCloudResources> CloudResources { get; set; }
        public class DescribeCloudResourcesResponseBodyCloudResources : TeaModel {
            /// <summary>
            /// <para>The number of HTTP ports that are added to WAF.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ECS and CLB instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HttpPortCount")]
            [Validation(Required=false)]
            public int? HttpPortCount { get; set; }

            /// <summary>
            /// <para>The number of HTTPS ports that are added to WAF.</para>
            /// <remarks>
            /// <para>This parameter is returned only for ECS and CLB instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HttpsPortCount")]
            [Validation(Required=false)]
            public int? HttpsPortCount { get; set; }

            /// <summary>
            /// <para>The UID of the account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11769793******</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The domain name of the resource. This parameter is returned for FC or SAE instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-resource-domain</para>
            /// </summary>
            [NameInMap("ResourceDomain")]
            [Validation(Required=false)]
            public string ResourceDomain { get; set; }

            /// <summary>
            /// <para>The name of the function. This parameter is returned for FC instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-resource-function</para>
            /// </summary>
            [NameInMap("ResourceFunction")]
            [Validation(Required=false)]
            public string ResourceFunction { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the resource instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-ffff****</para>
            /// </summary>
            [NameInMap("ResourceInstance")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceInstance { get; set; }

            /// <summary>
            /// <para>The ID of the instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-uf60ub45fr9b***</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("ResourceInstanceIp")]
            [Validation(Required=false)]
            public string ResourceInstanceIp { get; set; }

            /// <summary>
            /// <para>The name of the instance that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-resource-name</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The cloud service to which the resource belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>alb</b>: ALB</para>
            /// </description></item>
            /// <item><description><para><b>mse</b>: MSE</para>
            /// </description></item>
            /// <item><description><para><b>fc</b>: FC</para>
            /// </description></item>
            /// <item><description><para><b>sae</b>: SAE</para>
            /// </description></item>
            /// <item><description><para><b>ecs</b>: ECS</para>
            /// </description></item>
            /// <item><description><para><b>clb4</b>: CLB that uses TCP</para>
            /// </description></item>
            /// <item><description><para><b>clb7</b>: CLB that uses HTTP or HTTPS</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: NLB</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alb</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The region where the resource resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The name of the route. This parameter is returned for MSE instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-route-name</para>
            /// </summary>
            [NameInMap("ResourceRouteName")]
            [Validation(Required=false)]
            public string ResourceRouteName { get; set; }

            /// <summary>
            /// <para>The name of the service. This parameter is returned for FC instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-resource-service</para>
            /// </summary>
            [NameInMap("ResourceService")]
            [Validation(Required=false)]
            public string ResourceService { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C327F81A-CCE2-5B21-817C-F93E29C5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of cloud services found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

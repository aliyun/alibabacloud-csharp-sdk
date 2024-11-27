// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud service resources that are added to WAF.</para>
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public List<DescribeCloudResourcesResponseBodyCloudResources> CloudResources { get; set; }
        public class DescribeCloudResourcesResponseBodyCloudResources : TeaModel {
            /// <summary>
            /// <para>The number of the HTTP ports that are added to WAF.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the cloud service is ECS or CLB.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HttpPortCount")]
            [Validation(Required=false)]
            public int? HttpPortCount { get; set; }

            /// <summary>
            /// <para>The number of the HTTPS ports that are added to WAF.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the cloud service is ECS or CLB.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HttpsPortCount")]
            [Validation(Required=false)]
            public int? HttpsPortCount { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11769793******</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The domain name. This parameter has a value only if the value of ResourceProduct is fc or sae.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-resource-domain</para>
            /// </summary>
            [NameInMap("ResourceDomain")]
            [Validation(Required=false)]
            public string ResourceDomain { get; set; }

            /// <summary>
            /// <para>The function name. This parameter has a value only if the value of ResourceProduct is fc.</para>
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
            /// <para>The ID of the resource.</para>
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
            /// <para>The name of the resource.</para>
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
            /// <item><description><b>alb</b>: ALB.</description></item>
            /// <item><description><b>mse</b>: MSE.</description></item>
            /// <item><description><b>fc</b>: Function Compute.</description></item>
            /// <item><description><b>sae</b>: SAE.</description></item>
            /// <item><description><b>ecs</b>: ECS.</description></item>
            /// <item><description><b>clb4</b>: Layer 4 CLB.</description></item>
            /// <item><description><b>clb7</b>: Layer 7 CLB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>alb</para>
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The route name. This parameter has a value only if the value of ResourceProduct is mse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-route-name</para>
            /// </summary>
            [NameInMap("ResourceRouteName")]
            [Validation(Required=false)]
            public string ResourceRouteName { get; set; }

            /// <summary>
            /// <para>The service name. This parameter has a value only if the value of ResourceProduct is fc.</para>
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
        /// <para>The total number of cloud service resources returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the basic GA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The endpoints.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateBasicEndpointsRequestEndpoints> Endpoints { get; set; }
        public class CreateBasicEndpointsRequestEndpoints : TeaModel {
            /// <summary>
            /// <para>The address of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1a05txelswuj8g****</para>
            /// </summary>
            [NameInMap("EndpointAddress")]
            [Validation(Required=false)]
            public string EndpointAddress { get; set; }

            /// <summary>
            /// <para>The secondary address of the endpoint.</para>
            /// <para>This parameter is required only if you set the endpoint type to <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>.</para>
            /// <list type="bullet">
            /// <item><description>If you set the endpoint type to <b>ECS</b>, you can set <b>EndpointSubAddress</b> to the secondary private IP address of the primary ENI. If you leave this parameter empty, the primary private IP address of the primary ENI is used.</description></item>
            /// <item><description>If you set the endpoint type to <b>ENI</b>, you can set <b>EndpointSubAddress</b> to the secondary private IP address of the secondary ENI. If you leave this parameter empty, the primary private IP address of the secondary ENI is used.</description></item>
            /// <item><description>If you set the endpoint type to <b>NLB</b>, you can set <b>EndpointSubAddress</b> to the primary private IP address of the NLB backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("EndpointSubAddress")]
            [Validation(Required=false)]
            public string EndpointSubAddress { get; set; }

            /// <summary>
            /// <para>The secondary address type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>primary</b>: a primary private IP address.</description></item>
            /// <item><description><b>secondary</b>: a secondary private IP address.</description></item>
            /// </list>
            /// <para>This parameter is required only if you set the endpoint type to <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>. If you set the endpoint type to <b>NLB</b>, only <b>primary</b> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("EndpointSubAddressType")]
            [Validation(Required=false)]
            public string EndpointSubAddressType { get; set; }

            /// <summary>
            /// <para>The type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ENI</b>: elastic network interface (ENI).</description></item>
            /// <item><description><b>SLB</b>: Classic Load Balancer (CLB) instance.</description></item>
            /// <item><description><b>ECS</b>: Elastic Compute Service (ECS) instance.</description></item>
            /// <item><description><b>NLB</b>: Network Load Balancer (NLB) instance.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ENI</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the endpoint resides.</para>
            /// <para>This parameter is required only if you set the endpoint type to <b>NLB</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("EndpointZoneId")]
            [Validation(Required=false)]
            public string EndpointZoneId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// <para>The name must be 1 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ep01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

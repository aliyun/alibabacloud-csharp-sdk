// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the basic Alibaba Cloud Global Accelerator (GA).</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The address of the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp1a05txelswuj8g****</para>
        /// </summary>
        [NameInMap("EndpointAddress")]
        [Validation(Required=false)]
        public string EndpointAddress { get; set; }

        /// <summary>
        /// <para>The endpoint group ID of the basic Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The secondary address of the endpoint.</para>
        /// <para>This parameter is required when the endpoint type is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint type is <b>ECS</b>, EndpointSubAddress can be set to a secondary private IP of the primary network interface controller (NIC). If you leave this parameter empty, the primary private IP of the primary network interface controller (NIC) is used.</description></item>
        /// <item><description>If the endpoint type is <b>ENI</b>, EndpointSubAddress can be set to a secondary private IP of the secondary network interface controller (NIC). If you leave this parameter empty, the primary private IP of the secondary network interface controller (NIC) is used.</description></item>
        /// <item><description>If the endpoint type is <b>NLB</b>, this parameter is required. Set EndpointSubAddress to the primary private IP of the NLB backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// <para>The type of the secondary address of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: The secondary address type is the primary private IP address.</description></item>
        /// <item><description><b>secondary</b>: The secondary address type is a secondary private IP address.</description></item>
        /// </list>
        /// <para>This parameter is required when the endpoint type is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>. If the endpoint type is <b>NLB</b>, only <b>primary</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("EndpointSubAddressType")]
        [Validation(Required=false)]
        public string EndpointSubAddressType { get; set; }

        /// <summary>
        /// <para>The endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ENI</b>: Alibaba Cloud elastic network interface (ENI).</description></item>
        /// <item><description><b>SLB</b>: Alibaba Cloud Classic Load Balancer (CLB) instance.</description></item>
        /// <item><description><b>ECS</b>: Alibaba Cloud ECS instance.</description></item>
        /// <item><description><b>NLB</b>: Alibaba Cloud Network Load Balancer (NLB) instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENI</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The zone ID of the endpoint.</para>
        /// <para>Currently, this parameter is required only when the endpoint type is <b>NLB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("EndpointZoneId")]
        [Validation(Required=false)]
        public string EndpointZoneId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint for the basic Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>The name must be 1 to 128 characters in length and must start with a letter or a Chinese character. The name can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>ap-southeast-1</b>.</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAccelerateIpEndpointRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The accelerated IP address instance ID of the basic Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gaip-bp1****</para>
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// <para>The instance ID of the basic Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp11v53zfftax68b0daws</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

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
        /// <para>The endpoint ID of the basic Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-bp14sz7ftcwwjgrdm****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint of the basic Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep01</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The secondary address of the endpoint.</para>
        /// <para>This parameter is returned when the endpoint type attached to the accelerated IP address is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint type is <b>ECS</b>, EndpointSubAddress is the secondary private IP address or the primary private IP address of the primary network interface controller (NIC).</description></item>
        /// <item><description>If the endpoint type is <b>ENI</b>, EndpointSubAddress is the secondary private IP address or the primary private IP address of the secondary elastic network interface (ENI).</description></item>
        /// <item><description>If the endpoint type is <b>NLB</b>, EndpointSubAddress is the primary private IP address of the NLB backend server.</description></item>
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
        /// <item><description><b>secondary</b>: The secondary address type is the secondary private IP address.</description></item>
        /// </list>
        /// <para>This parameter is returned when the endpoint type bound to the accelerated IP address is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>. If the endpoint type is <b>NLB</b>, only <b>primary</b> is returned.</para>
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
        /// <item><description><b>ENI</b>: an Alibaba Cloud elastic network interface (ENI).</description></item>
        /// <item><description><b>SLB</b>: an Alibaba Cloud Classic Load Balancer (CLB) instance.</description></item>
        /// <item><description><b>ECS</b>: an Alibaba Cloud ECS instance.</description></item>
        /// <item><description><b>NLB</b>: an Alibaba Cloud Network Load Balancer (NLB) instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENI</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The zone ID of the endpoint.</para>
        /// <para>Currently, this parameter is returned only when the endpoint type bound to the accelerated IP address is <b>NLB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("EndpointZoneId")]
        [Validation(Required=false)]
        public string EndpointZoneId { get; set; }

        /// <summary>
        /// <para>The accelerated IP address of the basic Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.132.XX.XX</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the attachment between the accelerated IP address and the endpoint of the basic Global Accelerator (GA) instance.</para>
        /// <para>The value <b>active</b> indicates that the accelerated IP address is attached to the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

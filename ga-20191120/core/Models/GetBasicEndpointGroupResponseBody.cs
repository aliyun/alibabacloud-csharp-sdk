// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicEndpointGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The description of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BasicEndpointGroup</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The ID of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the endpoint group resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        /// <summary>
        /// <para>The secondary address of the endpoint.</para>
        /// <para>This parameter is returned if the endpoint type is <b>ECS</b>, <b>ENI</b>, or <b>NLB</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the endpoint type is <b>ECS</b>, <b>EndpointSubAddress</b> returns the primary or secondary private IP address of the primary ENI.</description></item>
        /// <item><description>If the endpoint type is <b>ENI</b>, <b>EndpointSubAddress</b> returns the primary or secondary private IP address of the secondary ENI.</description></item>
        /// <item><description>If the endpoint type is <b>NLB</b>, <b>EndpointSubAddress</b> returns the primary private IP address of the NLB backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("EndpointSubAddress")]
        [Validation(Required=false)]
        public string EndpointSubAddress { get; set; }

        /// <summary>
        /// <para>The type of endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ENI</b>: elastic network interface (ENI).</description></item>
        /// <item><description><b>SLB</b>: Classic Load Balancer (CLB) instance.</description></item>
        /// <item><description><b>ECS</b>: Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>NLB</b>: Network Load Balancer (NLB) instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENI</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The name of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the endpoint group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: being initialized.</description></item>
        /// <item><description><b>active</b>: running as expected.</description></item>
        /// <item><description><b>updating</b>: being updated.</description></item>
        /// <item><description><b>deleting</b>: being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

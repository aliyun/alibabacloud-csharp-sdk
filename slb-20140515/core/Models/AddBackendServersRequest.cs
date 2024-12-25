// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you want to add. Set the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ServerId</b>: Required. This value must be a string. Enter the ID of an ECS instance, elastic network interface (ENI), or elastic container instance. If <b>ServerId</b> is set to the ID of an ENI or elastic container instance, <b>Type</b> is required.</para>
        /// </description></item>
        /// <item><description><para><b>Weight</b>: the weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>.</para>
        /// <para>If the value is set to 0, no requests are forwarded to the backend server.</para>
        /// </description></item>
        /// <item><description><para><b>Description</b>: Optional. The description of the backend server. This value must be a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the type of the backend server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b> (default): an ECS instance</description></item>
        /// <item><description><b>eni</b>: an ENI</description></item>
        /// <item><description><b>eci</b>: an elastic container instance</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify ENIs and elastic container instances as the backend servers only for high-performance CLB instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ServerIp</b>: the IP address of the ECS instance, ENI, or elastic container instance</description></item>
        /// <item><description><b>Port</b>: the backend port</description></item>
        /// </list>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>ECS instance: <c>[{ &quot;ServerId&quot;: &quot;i-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;ecs&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></description></item>
        /// <item><description>ENI: <c>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></description></item>
        /// <item><description>ENI with multiple IP addresses: <c>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``172.166.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</c></description></item>
        /// <item><description>Elastic container instance: <c>[{ &quot;ServerId&quot;: &quot;eci-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eci&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-114&quot; }]</c></description></item>
        /// </list>
        /// <remarks>
        /// <para> The backend servers that you add to a CLB instance must be in the Running state. You can add at most 20 backend servers to a CLB instance in each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>192.168.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>172.166.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze7o5h52g02kkzz******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

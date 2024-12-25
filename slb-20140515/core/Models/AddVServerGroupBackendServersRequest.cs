// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddVServerGroupBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The backend servers that you want to add. Configure the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ServerId</b>: Required. The ID of the backend server. Specify the ID in a string. You can specify the ID of an Elastic Compute Service (ECS) instance, an elastic network interface (ENI), and an elastic container instance. If you set <b>ServerId</b> to the ID of an ENI or an elastic container instance, you must configure the <b>Type</b> parameter.</para>
        /// </description></item>
        /// <item><description><para><b>Weight</b>: the weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If you set the weight of a backend server to 0, no requests are forwarded to the backend server.</para>
        /// </description></item>
        /// <item><description><para><b>Description</b>: Optional. The description of the backend server. Specify the description in a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the type of the backend server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b> (default): ECS instance</description></item>
        /// <item><description><b>eni</b>: ENI</description></item>
        /// <item><description><b>eci</b>: elastic container instance</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify ENIs and elastic container instances as backend servers only for high-performance SLB instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ServerIp</b>: the IP address of an ENI or an elastic container instance.</description></item>
        /// <item><description><b>Port</b>: the backend port.</description></item>
        /// </list>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Add an ECS instance:</para>
        /// <para><c>[{ &quot;ServerId&quot;: &quot;i-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;ecs&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an ENI:</para>
        /// <para><c>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an ENI with multiple IP addresses:</para>
        /// <para><c>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``172.166.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an elastic container instance:</para>
        /// <para><c>[{ &quot;ServerId&quot;: &quot;eci-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eci&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-114&quot; }]</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can add only running backend servers to SLB instances. You can specify at most 20 backend servers in each call.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>192.168.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>172.166.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Server Load Balancer (SLB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

        /// <summary>
        /// <para>The ID of the vServer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rsp-cige6******</para>
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}

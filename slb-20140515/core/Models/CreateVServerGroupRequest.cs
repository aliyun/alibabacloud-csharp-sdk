// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateVServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The backend servers that you want to add. Configure the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ServerId</b>:  required. The ID of the backend server. Specify the ID in a string. You can specify the ID of an Elastic Compute Service (ECS) instance, an elastic network interface (ENI), or an elastic container instance. If you set ServerId to the ID of an ENI or an elastic container instance, you must configure the Type parameter.</para>
        /// </description></item>
        /// <item><description><para><b>Weight</b>: the weight of the backend server. Valid values: 0 to 100. Default value: 100. If you set the weight of a backend server to 0, no requests are forwarded to the backend server.</para>
        /// </description></item>
        /// <item><description><para><b>Description</b>: optional. The description of the backend server. Specify the description in a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the type of the backend server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs (default)</b>: ECS instance</description></item>
        /// <item><description><b>eni</b>: ENI.</description></item>
        /// <item><description><b>eni</b>: elastic container instance.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify ENIs and elastic container instances as backend servers only for high-performance SLB instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ServerIp</b>: The IP address of the ECS instance or ENI.</description></item>
        /// <item><description><b>Port</b>: the backend port.</description></item>
        /// </list>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>Add an ECS instance:</para>
        /// <para><c>[{ &quot;ServerId&quot;: &quot;i-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;ecs&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an ENI:</para>
        /// <para><c> [{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an ENI with multiple IP addresses:</para>
        /// <para> <c>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;``172.166.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</c></para>
        /// </description></item>
        /// <item><description><para>Add an elastic container instance:</para>
        /// <para><c> [{ &quot;ServerId&quot;: &quot;eci-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eci&quot;, &quot;ServerIp&quot;: &quot;``192.168.**.**``&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-114&quot; }]</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can add only running backend servers to SLB instances. You can specify at most 20 backend servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>192.168.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-112&quot; },{ &quot;ServerId&quot;: &quot;eni-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;eni&quot;, &quot;ServerIp&quot;: &quot;<c>172.166.**.**</c>&quot;, &quot;Port&quot;:&quot;80&quot;,&quot;Description&quot;:&quot;test-113&quot; }]</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// <para>The ID of the Server Load Balancer (SLB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1qjwo61pqz3ahl******</para>
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
        /// <para>The ID of the region where the SLB instance is deployed.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVServerGroupRequestTag> Tag { get; set; }
        public class CreateVServerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: <b>1 to 20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the vServer group.</para>
        /// <para>The name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group1</para>
        /// </summary>
        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

    }

}

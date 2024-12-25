// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateMasterSlaveServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The CLB instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1hv944r69al4j******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The backend servers in the primary/secondary server group. Each primary/secondary server group consists of two backend servers.</para>
        /// <para>Configure the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ServerId</b>: required. The IDs of the backend servers. Specify the IDs in a string. You can specify the IDs of Elastic Compute Service (ECS) instances, elastic network interfaces (ENIs), and elastic container instances. If you set <b>ServerId</b> to the IDs of ENIs or elastic container instances, you must configure the <b>Type</b> parameter.</para>
        /// </description></item>
        /// <item><description><para><b>Weight</b>: the weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Default value: <b>100</b>. If you set the weight of a backend server to 0, no requests are forwarded to the backend server.</para>
        /// </description></item>
        /// <item><description><para><b>Description</b>: optional. The description of the backend servers. Specify the description in a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/). periods (.), and underscores (_).</para>
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
        /// <para> You can specify ENIs and elastic container instances as backend servers only for high-performance CLB instances.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>ServerIp</b>: the IP address of the ENI or elastic container instance.</para>
        /// </description></item>
        /// <item><description><para><b>Port</b>: the backend port.</para>
        /// </description></item>
        /// <item><description><para><b>ServerType</b>: Specify the primary and secondary backend servers in a string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Master</b>: primary server</description></item>
        /// <item><description><b>Slave</b>: secondary server</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{ &quot;ServerId&quot;: &quot;i-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;ecs&quot;,  &quot;Port&quot;:&quot;82&quot;,&quot;ServerType&quot;:&quot;Master&quot;,&quot;Description&quot;:&quot;test-112&quot; },  { &quot;ServerId&quot;: &quot;i-xxxxxxxxx&quot;, &quot;Weight&quot;: &quot;100&quot;, &quot;Type&quot;: &quot;ecs&quot;,  &quot;Port&quot;:&quot;84&quot;,&quot;ServerType&quot;:&quot;Slave&quot;,&quot;Description&quot;:&quot;test-112&quot; }]</para>
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public string MasterSlaveBackendServers { get; set; }

        /// <summary>
        /// <para>The name of the primary/secondary server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group1</para>
        /// </summary>
        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Classic Load Balancer (CLB) instance.</para>
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
        public List<CreateMasterSlaveServerGroupRequestTag> Tag { get; set; }
        public class CreateMasterSlaveServerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N. Valid values of N: <b>1 to 20</b>. The tag value can be an empty string. The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

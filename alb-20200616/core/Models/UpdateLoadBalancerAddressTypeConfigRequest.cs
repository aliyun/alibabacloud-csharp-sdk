// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerAddressTypeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The target network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: The load balancer is assigned a public IP address and can be accessed over the Internet. Its DNS domain name is resolved to the public IP address.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The load balancer is assigned a private IP address and can be accessed only from the VPC where it is deployed. Its DNS domain name is resolved to the private IP address.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a value from your client to make sure that the value is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> of each request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the check, the system returns a 2xx HTTP status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("RetainResourceType")]
        [Validation(Required=false)]
        public List<string> RetainResourceType { get; set; }

        /// <summary>
        /// <para>The mappings between availability zones and vSwitches. You can specify up to 10 mappings. If the region supports two or more availability zones, you must specify mappings for at least two.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerAddressTypeConfigRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerAddressTypeConfigRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic IP address (EIP).</para>
            /// <remarks>
            /// <para>This parameter is required when you change the network type from Intranet to Internet.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Common</b> (default): a regular EIP.</para>
            /// </description></item>
            /// <item><description><para>Anycast: Anycast EIP.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For the regions where Application Load Balancer (ALB) supports binding Anycast Elastic IP addresses (EIPs), see <a href="https://help.aliyun.com/document_detail/460727.html">Usage limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in the specified availability zone. You can specify only one vSwitch for each availability zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10ttov87felojcn****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the availability zone of the ALB instance.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query information about availability zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}

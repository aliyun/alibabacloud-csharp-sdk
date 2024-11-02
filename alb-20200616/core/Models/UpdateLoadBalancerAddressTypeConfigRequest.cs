// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerAddressTypeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The new network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the virtual private cloud (VPC) where the ALB instance is deployed.</description></item>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The ALB instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The zones and the vSwitches in the zones. You can specify a maximum of 10 zones. If the selected region supports two or more zones, select at least two zones to ensure the high availability of your service.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerAddressTypeConfigRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerAddressTypeConfigRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic IP address (EIP). You can specify a maximum of 10 zones.</para>
            /// <remarks>
            /// <para> This parameter is required if you want to change the network type from internal-facing to Internet-facing.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The type of EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Common</b>: an EIP.</description></item>
            /// <item><description><b>Anycast</b>: an Anycast EIP.</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about the regions in which ALB supports Anycast EIPs, see <a href="https://help.aliyun.com/document_detail/460727.html">Limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The vSwitch in the zone. You can specify only one vSwitch (subnet) in each zone of an ALB instance. You can specify a maximum of 10 zones. If the selected region supports two or more zones, select at least two zones to ensure the high availability of your service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10ttov87felojcn****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the ALB instance. You can specify a maximum of 10 zones. If the selected region supports two or more zones, select at least two zones to ensure the high availability of your service.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query the information about the zone.</para>
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

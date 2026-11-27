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
        /// <item><description><para><b>Internet</b>: The load balancing instance has a public IP address, and its DNS domain name is resolved to the public IP address. The load balancing instance can be accessed over the Internet.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The load balancing instance has only a private IP address, and its DNS domain name is resolved to the private IP address. The load balancing instance can be accessed only within the internal network environment of the VPC where it resides.</para>
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
        /// <para>Generate a unique value from your client for this parameter. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
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
        /// <item><description><b>true</b>: Sends a dry run request. The network type of the instance is not changed. The system checks whether the required parameters are specified, the request format is valid, and the business limits are met. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a regular request. If the check passes, the system returns an HTTP 2xx status code and performs the operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-bp1o94dp5i6ea****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The types of resources that are automatically created by ALB and need to be retained. Settings can currently be configured as eip, which indicates EIPs. Automatic creation and attach operations apply to these resource types.</para>
        /// </summary>
        [NameInMap("RetainResourceType")]
        [Validation(Required=false)]
        public List<string> RetainResourceType { get; set; }

        /// <summary>
        /// <para>The list of zone and vSwitch mappings. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerAddressTypeConfigRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerAddressTypeConfigRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The instance ID of the EIP. You can add up to 10 active zones.</para>
            /// <remarks>
            /// <para>This parameter is required when you invoke this operation to transform the network type from private network to public network.</para>
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
            /// <item><description><para>Common (default): a standard EIP.</para>
            /// </description></item>
            /// <item><description><para>Anycast: an Anycast EIP.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For the regions that support binding Anycast EIPs to ALB instances, see <a href="https://help.aliyun.com/document_detail/460727.html">Limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The vSwitch that corresponds to the zone. Each zone can use only one vSwitch and one subnet. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp10ttov87felojcn****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID of the load balancing instance. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> to query the active zone information that corresponds to a zone ID.</para>
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

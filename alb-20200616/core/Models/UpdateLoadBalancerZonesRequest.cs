// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerZonesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run and does not modify the active zone property of the application load balancing instance. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, the system returns an error. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends a Normal request. If the request passes the dry run, the system returns an <c>HTTP_2xx</c> status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the application load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hfn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The types of resources that undergo automatic creation and attach to the ALB instance, which need to be retained. When you remove an active zone from an Internet-facing ALB instance, you can update the Settings to eip to retain the EIP that undergoes automatic creation and attach by ALB. Anycast EIPs do not support retention, and EIPs that users manually attach are automatically retained.</para>
        /// </summary>
        [NameInMap("RetainResourceType")]
        [Validation(Required=false)]
        public List<string> RetainResourceType { get; set; }

        /// <summary>
        /// <para>The mappings between zones and vSwitches. You can specify up to 10 zones. If the current region supports two or more zones, you must specify at least two zones. If you specify this parameter, the previous zone configurations are replaced.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerZonesRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerZonesRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The type of the Internet-facing EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Common</b>: EIP.</description></item>
            /// <item><description><b>Anycast</b>: Anycast EIP.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the regions where ALB supports Anycast EIPs, see <a href="https://help.aliyun.com/document_detail/460727.html">Limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The IPv4 private endpoint of the private network. You must add at least two active zones and can add up to 10 active zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.1</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The vSwitch that corresponds to the zone. By default, each zone uses one vSwitch and one subnet. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1rmcrwg3srh1fh8****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The name of the zone. You can obtain the zone name by calling the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>This parameter is required.</para>
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

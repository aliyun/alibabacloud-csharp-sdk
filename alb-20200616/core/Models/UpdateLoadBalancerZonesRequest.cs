// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateLoadBalancerZonesRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique token from your client for each request. The <c>ClientToken</c> parameter can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request\&quot;s <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> differs for each API request.</para>
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
        /// <item><description><para><b>true</b>: performs a dry run to check for potential issues, including missing parameters, incorrect formatting, and service limits. If the request fails the dry run, the system returns an error message. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the check, the system returns an HTTP <c>2xx</c> status code and performs the operation.</para>
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
        /// <para>The ID of the ALB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-o9ulmq5hfn68jk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("RetainResourceType")]
        [Validation(Required=false)]
        public List<string> RetainResourceType { get; set; }

        /// <summary>
        /// <para>The mappings between availability zones and VSwitches. You can specify up to 10 availability zones. If the current region supports two or more availability zones, you must specify at least two. Specifying this parameter overwrites the existing availability zone configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateLoadBalancerZonesRequestZoneMappings> ZoneMappings { get; set; }
        public class UpdateLoadBalancerZonesRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The type of the EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Common</b>: an EIP.</para>
            /// </description></item>
            /// <item><description><para><b>Anycast</b>: an Anycast EIP.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For a list of regions that support binding an Anycast EIP to an ALB instance, see <a href="https://help.aliyun.com/document_detail/460727.html">Usage limits</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("EipType")]
            [Validation(Required=false)]
            public string EipType { get; set; }

            /// <summary>
            /// <para>The private IPv4 address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.1</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The ID of the VSwitch in the availability zone. Each availability zone uses one VSwitch and one subnet by default.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1rmcrwg3srh1fh8****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the availability zone. You can call the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query the IDs of available zones.</para>
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

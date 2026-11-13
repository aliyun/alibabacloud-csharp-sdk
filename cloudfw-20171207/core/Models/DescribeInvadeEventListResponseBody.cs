// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of compromised host events.</para>
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventListResponseBodyEventList> EventList { get; set; }
        public class DescribeInvadeEventListResponseBodyEventList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-ECS****</para>
            /// </summary>
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_test</para>
            /// </summary>
            [NameInMap("AssetsInstanceName")]
            [Validation(Required=false)]
            public string AssetsInstanceName { get; set; }

            /// <summary>
            /// <para>The affected asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BastionHostIP</b>: the egress IP address of Bastionhost.</description></item>
            /// <item><description><b>BastionHostIngressIP</b>: the ingress IP address of Bastionhost.</description></item>
            /// <item><description><b>EcsEIP</b>: the EIP of an ECS instance.</description></item>
            /// <item><description><b>EcsPublicIP</b>: the public IP addresses of Elastic Compute Service (ECS) instances.</description></item>
            /// <item><description><b>EIP</b>: an EIP.</description></item>
            /// <item><description><b>EniEIP</b>: the EIP of an elastic network interface controller (NIC).</description></item>
            /// <item><description><b>NatEIP</b>: the EIP of a NAT gateway.</description></item>
            /// <item><description><b>SlbEIP</b>: the EIP of an SLB instance.</description></item>
            /// <item><description><b>SlbPublicIP</b>: the public IP address of an SLB instance.</description></item>
            /// <item><description><b>NatPublicIP</b>: the public IP address of a NAT gateway.</description></item>
            /// <item><description><b>HAVIP</b>: a high-availability (active) virtual IP address.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIp</para>
            /// </summary>
            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            /// <summary>
            /// <para>The ID of the breach awareness event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69d189e2-ec17-4676-a2fe-02969234****</para>
            /// </summary>
            [NameInMap("EventKey")]
            [Validation(Required=false)]
            public string EventKey { get; set; }

            /// <summary>
            /// <para>The name of the breach awareness event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event_test</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The source of the compromised host event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPS</b>: intrusion prevention event.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: offline event.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPS</para>
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// <para>The UUID of the breach awareness event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fadd-dfdd-****</para>
            /// </summary>
            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            /// <summary>
            /// <para>The time when the compromised host event first occurred. The value is a UNIX timestamp accurate to seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656750960</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public int? FirstTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the compromised host event is ignored. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: ignored.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: not ignored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsIgnore")]
            [Validation(Required=false)]
            public bool? IsIgnore { get; set; }

            /// <summary>
            /// <para>The time when the compromised host event last occurred. The value is a UNIX timestamp accurate to seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656837360</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public int? LastTime { get; set; }

            /// <summary>
            /// <para>The UID of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135809047715****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The private IP address of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// <para>The processing status of the compromised host event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unhandled.</description></item>
            /// <item><description><b>20</b>: resolved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <para>The public IP address of the affected asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>198.51.XX.XX</para>
            /// </summary>
            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            /// <summary>
            /// <para>The affected asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BastionHostIP</b>: the egress IP address of Bastionhost.</description></item>
            /// <item><description><b>BastionHostIngressIP</b>: the ingress IP address of Bastionhost.</description></item>
            /// <item><description><b>EcsEIP</b>: the EIP of an ECS instance.</description></item>
            /// <item><description><b>EcsPublicIP</b>: the public IP addresses of Elastic Compute Service (ECS) instances.</description></item>
            /// <item><description><b>EIP</b>: an EIP.</description></item>
            /// <item><description><b>EniEIP</b>: the EIP of an elastic network interface controller (NIC).</description></item>
            /// <item><description><b>NatEIP</b>: the EIP of a NAT gateway.</description></item>
            /// <item><description><b>SlbEIP</b>: the EIP of an SLB instance.</description></item>
            /// <item><description><b>SlbPublicIP</b>: the public IP address of an SLB instance.</description></item>
            /// <item><description><b>NatPublicIP</b>: the public IP address of a NAT gateway.</description></item>
            /// <item><description><b>HAVIP</b>: a high-availability (active) virtual IP address.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIp</para>
            /// </summary>
            [NameInMap("PublicIpType")]
            [Validation(Required=false)]
            public string PublicIpType { get; set; }

            /// <summary>
            /// <para>The risk assessment level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Low risk.</description></item>
            /// <item><description><b>2</b>: Medium risk.</description></item>
            /// <item><description><b>3</b>: High risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The proportion of high-risk levels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("HighLevelPercent")]
        [Validation(Required=false)]
        public int? HighLevelPercent { get; set; }

        /// <summary>
        /// <para>The proportion of low-risk levels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("LowLevelPercent")]
        [Validation(Required=false)]
        public int? LowLevelPercent { get; set; }

        /// <summary>
        /// <para>The proportion of medium-risk levels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MiddleLevelPercent")]
        [Validation(Required=false)]
        public int? MiddleLevelPercent { get; set; }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInvadeEventListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInvadeEventListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number returned for a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page for a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of compromised host events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

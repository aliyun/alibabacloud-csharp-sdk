// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetDhcpOptionsSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the VPCs associated with the DHCP options set.</para>
        /// </summary>
        [NameInMap("AssociateVpcs")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyAssociateVpcs> AssociateVpcs { get; set; }
        public class GetDhcpOptionsSetResponseBodyAssociateVpcs : TeaModel {
            /// <summary>
            /// <para>The status of the VPC associated with the DHCP options set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>InUse</b>: in use.</para>
            /// </description></item>
            /// <item><description><para><b>Pending</b>: being configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InUse</para>
            /// </summary>
            [NameInMap("AssociateStatus")]
            [Validation(Required=false)]
            public string AssociateStatus { get; set; }

            /// <summary>
            /// <para>The ID of the VPC associated with the DHCP options set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-eb3b54r6otues4tjj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-21 ***</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The DHCP options configuration.</para>
        /// </summary>
        [NameInMap("DhcpOptions")]
        [Validation(Required=false)]
        public GetDhcpOptionsSetResponseBodyDhcpOptions DhcpOptions { get; set; }
        public class GetDhcpOptionsSetResponseBodyDhcpOptions : TeaModel {
            /// <summary>
            /// <para>The hostname suffix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The IP address of the DNS server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.XX.XX.123</para>
            /// </summary>
            [NameInMap("DomainNameServers")]
            [Validation(Required=false)]
            public string DomainNameServers { get; set; }

            /// <summary>
            /// <para>The lease time of the IPv6 DHCP options set.</para>
            /// <list type="bullet">
            /// <item><description><para>When the lease time is set in hours: Unit: h. Valid values: <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>24h</b>.</para>
            /// </description></item>
            /// <item><description><para>When the lease time is set in days: Unit: d. Valid values: <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>1d</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3650d</para>
            /// </summary>
            [NameInMap("Ipv6LeaseTime")]
            [Validation(Required=false)]
            public string Ipv6LeaseTime { get; set; }

            /// <summary>
            /// <para>The lease time of the IPv4 DHCP options set.</para>
            /// <list type="bullet">
            /// <item><description><para>When the lease time is set in hours: Unit: h. Valid values: <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>87600h</b>.</para>
            /// </description></item>
            /// <item><description><para>When the lease time is set in days: Unit: d. Valid values: <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>3650d</b>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3650d</para>
            /// </summary>
            [NameInMap("LeaseTime")]
            [Validation(Required=false)]
            public string LeaseTime { get; set; }

        }

        /// <summary>
        /// <para>The description of the DHCP options set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

        /// <summary>
        /// <para>The ID of the DHCP options set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dopt-o6w0df4epg9zo8isy****</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public string DhcpOptionsSetId { get; set; }

        /// <summary>
        /// <para>The name of the DHCP options set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the DHCP options set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283117732402483989</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the DHCP options set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the DHCP options set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Available</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>InUse</b>: in use.</para>
        /// </description></item>
        /// <item><description><para><b>Deleted</b>: deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: being configured.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyTags> Tags { get; set; }
        public class GetDhcpOptionsSetResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

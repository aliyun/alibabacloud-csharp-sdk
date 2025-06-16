// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetDhcpOptionsSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the virtual private cloud (VPC) that is associated with the DHCP options set.</para>
        /// </summary>
        [NameInMap("AssociateVpcs")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyAssociateVpcs> AssociateVpcs { get; set; }
        public class GetDhcpOptionsSetResponseBodyAssociateVpcs : TeaModel {
            /// <summary>
            /// <para>The status of the VPC that is associated with the DHCP options set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>InUse</b>: in use</description></item>
            /// <item><description><b>Pending</b>: being configured</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>InUse</para>
            /// </summary>
            [NameInMap("AssociateStatus")]
            [Validation(Required=false)]
            public string AssociateStatus { get; set; }

            /// <summary>
            /// <para>The ID of the VPC that is associated with the DHCP options set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-eb3b54r6otues4tjj****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The configuration information about the DHCP options set.</para>
        /// </summary>
        [NameInMap("DhcpOptions")]
        [Validation(Required=false)]
        public GetDhcpOptionsSetResponseBodyDhcpOptions DhcpOptions { get; set; }
        public class GetDhcpOptionsSetResponseBodyDhcpOptions : TeaModel {
            /// <summary>
            /// <para>The suffix of the hostname.</para>
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
            /// <para>The lease time of the IPv6 addresses for the DHCP options set.</para>
            /// <list type="bullet">
            /// <item><description>If you use hours as the unit, Valid values are <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>87600h</b>.</description></item>
            /// <item><description>If you use days as the unit, Valid values are <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>3650d</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3650d</para>
            /// </summary>
            [NameInMap("Ipv6LeaseTime")]
            [Validation(Required=false)]
            public string Ipv6LeaseTime { get; set; }

            /// <summary>
            /// <para>The lease time of the IPv4 addresses for the DHCP options set.</para>
            /// <list type="bullet">
            /// <item><description>If you use hours as the unit, valid values are <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>87600h</b>.</description></item>
            /// <item><description>If you use days as the unit, valid values are <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>3650d</b>.</description></item>
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
        /// <para>The ID of the Alibaba Cloud account to which the DHCP options set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>283117732402483989</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <item><description><b>Available</b>: available</description></item>
        /// <item><description><b>InUse</b>: in use</description></item>
        /// <item><description><b>Deleted</b>: deleted</description></item>
        /// <item><description><b>Pending</b>: being configured</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
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

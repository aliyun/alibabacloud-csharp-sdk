// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListDhcpOptionsSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of DHCP options sets.</para>
        /// </summary>
        [NameInMap("DhcpOptionsSets")]
        [Validation(Required=false)]
        public List<ListDhcpOptionsSetsResponseBodyDhcpOptionsSets> DhcpOptionsSets { get; set; }
        public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSets : TeaModel {
            /// <summary>
            /// <para>The number of VPCs associated with the DHCP options set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssociateVpcCount")]
            [Validation(Required=false)]
            public int? AssociateVpcCount { get; set; }

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
            public ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions DhcpOptions { get; set; }
            public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions : TeaModel {
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
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("DomainNameServers")]
                [Validation(Required=false)]
                public string DomainNameServers { get; set; }

                /// <summary>
                /// <para>The lease time of the IPv6 DHCP options set.</para>
                /// <list type="bullet">
                /// <item><description><para>If the lease time is in hours, the unit is h. Valid values: <b>24h</b> to <b>1176h</b> and <b>87600h</b> to <b>175200h</b>. Default value: <b>24h</b>.</para>
                /// </description></item>
                /// <item><description><para>If the lease time is in days, the unit is d. Valid values: <b>1d</b> to <b>49d</b> and <b>3650d</b> to <b>7300d</b>. Default value: <b>1d</b>.</para>
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
                /// <item><description><para>If the lease time is in hours, the unit is h. Valid values: <b>24h</b> to <b>1176h</b> and <b>87600h</b> to <b>175200h</b>. Default value: <b>87600h</b>.</para>
                /// </description></item>
                /// <item><description><para>If the lease time is in days, the unit is d. Valid values: <b>1d</b> to <b>49d</b> and <b>3650d</b> to <b>7300d</b>. Default value: <b>3650d</b>.</para>
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
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

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
            /// <item><description><para><b>Pending</b>: being configured.</para>
            /// </description></item>
            /// <item><description><para><b>Deleted</b>: deleted.</para>
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
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsTags> Tags { get; set; }
            public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsTags : TeaModel {
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

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd********</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}

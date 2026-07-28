// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateDhcpOptionsSetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the DHCP options set. </para>
        /// <para>The description can be empty or 1 to 256 characters in length. It must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

        /// <summary>
        /// <para>The name of the DHCP options set.</para>
        /// <para>The name must be 1 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// <para>The hostname suffix. Example: example.com.</para>
        /// <para>After the DHCP options set is used to associate VPC, the hostname suffix is automatically synchronized to the ECS instances in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The IP addresses of DNS servers. You can specify up to four DNS server IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// <remarks>
        /// <para>If you do not specify DNS server IP addresses, ECS instances use the DNS server IP addresses provided by Alibaba Cloud (100.100.2.136 and 100.100.2.138) by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.123</para>
        /// </summary>
        [NameInMap("DomainNameServers")]
        [Validation(Required=false)]
        public string DomainNameServers { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <para><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// <para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the DHCP options set is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The lease time of the IPv6 DHCP options set.</para>
        /// <list type="bullet">
        /// <item><description><para>If the lease time is in hours, the unit is h. Valid values: <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>24h</b>.</para>
        /// </description></item>
        /// <item><description><para>If the lease time is in days, the unit is d. Valid values: <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>1d</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must include the unit when specifying the value.</para>
        /// </remarks>
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
        /// <item><description><para>If the lease time is in hours, the unit is h. Valid values: <b>24h to 1176h</b> and <b>87600h to 175200h</b>. Default value: <b>87600h</b>.</para>
        /// </description></item>
        /// <item><description><para>If the lease time is in days, the unit is d. Valid values: <b>1d to 49d</b> and <b>3650d to 7300d</b>. Default value: <b>3650d</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must include the unit when specifying the value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3650d</para>
        /// </summary>
        [NameInMap("LeaseTime")]
        [Validation(Required=false)]
        public string LeaseTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region in which the DHCP options set resides.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the DHCP options set belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDhcpOptionsSetRequestTag> Tag { get; set; }
        public class CreateDhcpOptionsSetRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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

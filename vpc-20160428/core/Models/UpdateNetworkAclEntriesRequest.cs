// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateNetworkAclEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including the AccessKey pair, the permissions of the RAM user, and the required parameters. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The information about the outbound rules.</para>
        /// </summary>
        [NameInMap("EgressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestEgressAclEntries> EgressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestEgressAclEntries : TeaModel {
            /// <summary>
            /// <para>The description of the outbound rule.</para>
            /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is EgressAclEntries.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidrIp")]
            [Validation(Required=false)]
            public string DestinationCidrIp { get; set; }

            /// <summary>
            /// <para>The type of the rule. Set the value to <b>custom</b>, which specifies custom rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("EntryType")]
            [Validation(Required=false)]
            public string EntryType { get; set; }

            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b> (default)</description></item>
            /// <item><description><b>IPv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The ID of the outbound rule.</para>
            /// <para>Valid values of <b>N</b>: <b>0</b> to <b>99</b>. You can specify at most 100 outbound rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae-2zecs97e0brcge46****</para>
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// <para>The name of the outbound rule.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-2</para>
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// <para>The action to be performed on network traffic that matches the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b></description></item>
            /// <item><description><b>drop</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The destination port range of the outbound traffic.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>protocol</b> of the outbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which specified all ports.</description></item>
            /// <item><description>If the <b>protocol</b> of the outbound rule is set to <b>tcp</b> or <b>udp</b>, set the port range in the following format: <b>1/200</b> or <b>80/80</b>, which specifies port 1 to port 200 or port 80. Valid values for a port: <b>1</b> to <b>65535</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>icmp</b></description></item>
            /// <item><description><b>gre</b></description></item>
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// <item><description><b>all</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The information about the inbound rule.</para>
        /// </summary>
        [NameInMap("IngressAclEntries")]
        [Validation(Required=false)]
        public List<UpdateNetworkAclEntriesRequestIngressAclEntries> IngressAclEntries { get; set; }
        public class UpdateNetworkAclEntriesRequestIngressAclEntries : TeaModel {
            /// <summary>
            /// <para>The description of the inbound rule.</para>
            /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is IngressAclEntries.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the rule. Set the value to <b>custom</b>, which specifies custom rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("EntryType")]
            [Validation(Required=false)]
            public string EntryType { get; set; }

            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b> (default)</description></item>
            /// <item><description><b>IPv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The ID of the inbound rule.</para>
            /// <para>Valid values of <b>N</b>: <b>0</b> to <b>99</b>. You can specify at most 100 inbound rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nae-2zepn32de59j8m4****</para>
            /// </summary>
            [NameInMap("NetworkAclEntryId")]
            [Validation(Required=false)]
            public string NetworkAclEntryId { get; set; }

            /// <summary>
            /// <para>The name of the inbound rule.</para>
            /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-3</para>
            /// </summary>
            [NameInMap("NetworkAclEntryName")]
            [Validation(Required=false)]
            public string NetworkAclEntryName { get; set; }

            /// <summary>
            /// <para>The action to be performed on network traffic that matches the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>accept</b></description></item>
            /// <item><description><b>drop</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The source port range of the inbound rule.</para>
            /// <list type="bullet">
            /// <item><description>If the <b>protocol</b> of the inbound rule is set to <b>all</b>, <b>icmp</b>, or <b>gre</b>, the port range is -1/-1, which specifies all ports.</description></item>
            /// <item><description>If the <b>protocol</b> of the inbound rule is set to <b>tcp</b> or <b>udp</b>, set the port range in the following format: <b>1/200</b> or <b>80/80</b>, which specifies port 1 to port 200 or port 80. Valid ports: <b>1</b> to <b>65535</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1/-1</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>icmp</b></description></item>
            /// <item><description><b>gre</b></description></item>
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// <item><description><b>all</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/24</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-bp1lhl0taikrzxsc****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the network ACL.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to update outbound rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter cannot be used to add outbound rules to ACLs. If you want to add more outbound rules to ACLs, specify both the existing rule and the rule that you want to add when you call this API operation. If you specify only the rule that you want to add, it overwrites the existing rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateEgressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateEgressAclEntries { get; set; }

        /// <summary>
        /// <para>Specifies whether to update inbound rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter cannot be used to add inbound rules to ACLs. If you want to add more inbound rules to ACLs, you must specify both the existing rule and the rule that you want to add when you call this API operation. If you specify only the rule that you want to add, it overwrites the existing rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpdateIngressAclEntries")]
        [Validation(Required=false)]
        public bool? UpdateIngressAclEntries { get; set; }

    }

}

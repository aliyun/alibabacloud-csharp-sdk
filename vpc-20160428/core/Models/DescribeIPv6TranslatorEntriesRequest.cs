// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access control policy group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transacl-bp1de2****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The type of the access control policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: allows the IPv6 addresses in the access control policy group to access backend services.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: denies the IPv6 addresses in the access control policy group from accessing backend services.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The IPv6 address allocated by the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2400:3200:1600::XX</para>
        /// </summary>
        [NameInMap("AllocateIpv6Addr")]
        [Validation(Required=false)]
        public string AllocateIpv6Addr { get; set; }

        /// <summary>
        /// <para>The port used by the IPv6 address allocated by the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AllocateIpv6Port")]
        [Validation(Required=false)]
        public int? AllocateIpv6Port { get; set; }

        /// <summary>
        /// <para>The public IPv4 address that requires IPv6 services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.99.XX.XX</para>
        /// </summary>
        [NameInMap("BackendIpv4Addr")]
        [Validation(Required=false)]
        public string BackendIpv4Addr { get; set; }

        /// <summary>
        /// <para>The port used by the public IPv4 address that requires IPv6 services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("BackendIpv4Port")]
        [Validation(Required=false)]
        public int? BackendIpv4Port { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 Translation mapping entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entryname</para>
        /// </summary>
        [NameInMap("EntryName")]
        [Validation(Required=false)]
        public string EntryName { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 Translation mapping entry to query. </para>
        /// <remarks>
        /// <para>If both <b>Ipv6TranslatorId</b> and <b>Ipv6TranslatorEntryId</b> are empty, all IPv6 Translation mapping entries are returned. If only <b>Ipv6TranslatorEntryId</b> is empty, all IPv6 Translation mapping entries under the current IPv6 Translation Service instance are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transentry-bp1g8bhrde****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorEntryId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorEntryId { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1858ysxx****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the IPv6 Translation Service instance. You can call the <b>DescribeRegions</b> operation to query region IDs.</para>
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
        /// <para>The protocol type used for data forwarding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("TransProtocol")]
        [Validation(Required=false)]
        public string TransProtocol { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIPv6TranslatorEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated access control policy group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transacl-bp1g8bhrdexnrxxxx</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The type of access control:</para>
        /// <list type="bullet">
        /// <item><description><para><b>white</b>: Allows the IPv6 addresses in the access control policy group to access backend services.</para>
        /// </description></item>
        /// <item><description><para><b>black</b>: Denies the IPv6 addresses in the access control policy group from accessing backend services.</para>
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
        /// <para>The port used by the IPv6 address allocated by the IPv6 Translation Service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AllocateIpv6Port")]
        [Validation(Required=false)]
        public int? AllocateIpv6Port { get; set; }

        /// <summary>
        /// <para>The public IPv4 address that requires IPv6 services (the IPv4 address of the IPv4-only server).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46.22.xx.xx</para>
        /// </summary>
        [NameInMap("BackendIpv4Addr")]
        [Validation(Required=false)]
        public string BackendIpv4Addr { get; set; }

        /// <summary>
        /// <para>The port of the public IPv4 address that requires IPv6 services.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("BackendIpv4Port")]
        [Validation(Required=false)]
        public int? BackendIpv4Port { get; set; }

        /// <summary>
        /// <para>The peak bandwidth of the IPv6 translation mapping entry. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>-1 (default): No bandwidth limit is imposed on the IPv6 translation mapping entry.  </description></item>
        /// <item><description>1-200Mbps: The bandwidth value of the mapping entry.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The sum of peak bandwidth values of all IPv6 translation mapping entries cannot exceed the peak bandwidth of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EntryBandwidth")]
        [Validation(Required=false)]
        public int? EntryBandwidth { get; set; }

        /// <summary>
        /// <para>The description of the IPv6 translation mapping entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("EntryDescription")]
        [Validation(Required=false)]
        public string EntryDescription { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 translation mapping entry. The name must be 2 to 100 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("EntryName")]
        [Validation(Required=false)]
        public string EntryName { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPv6 Translation Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1858ys57xxxxxx</para>
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
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: Forwards TCP packets.  </description></item>
        /// <item><description><b>udp</b>: Forwards UDP packets.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("TransProtocol")]
        [Validation(Required=false)]
        public string TransProtocol { get; set; }

    }

}

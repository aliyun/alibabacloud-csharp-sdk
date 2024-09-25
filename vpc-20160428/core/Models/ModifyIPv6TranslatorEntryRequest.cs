// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyIPv6TranslatorEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transacl-bp1de27sou71g0lf****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access control lists (ACLs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// <para>The ACL type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>white</b>: a whitelist. IPv6 addresses in the ACL are allowed to access backend services.</description></item>
        /// <item><description><b>black</b>: a blacklist. IPv6 addresses in the ACL are not allowed to access backend services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>white</para>
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// <para>The port that is used by the IPv6 address allocated to the IPv6 Translation Service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("AllocateIpv6Port")]
        [Validation(Required=false)]
        public int? AllocateIpv6Port { get; set; }

        /// <summary>
        /// <para>The public IPv4 address that needs to provide IPv6 services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.11.XX.XX</para>
        /// </summary>
        [NameInMap("BackendIpv4Addr")]
        [Validation(Required=false)]
        public string BackendIpv4Addr { get; set; }

        /// <summary>
        /// <para>The port of the public IPv4 address that needs to provide IPv6 services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("BackendIpv4Port")]
        [Validation(Required=false)]
        public int? BackendIpv4Port { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth specified in the IPv6 mapping entry. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b> (default): does not limit the maximum bandwidth specified in the IPv6 mapping entry.</description></item>
        /// <item><description><b>1</b> to <b>200</b>: changes the maximum bandwidth specified in the IPv6 mapping entry.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The sum of maximum bandwidth values specified in all IPv6 entries cannot exceed the maximum bandwidth supported by the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("EntryBandwidth")]
        [Validation(Required=false)]
        public int? EntryBandwidth { get; set; }

        /// <summary>
        /// <para>The description of the IPv6 mapping entry. It must be 2 to 100 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter. It cannot start with http:// or <a href="https://%E3%80%82">https://</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entrydescription</para>
        /// </summary>
        [NameInMap("EntryDescription")]
        [Validation(Required=false)]
        public string EntryDescription { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 mapping entry. It must be 2 to 100 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter. It cannot start with http:// or <a href="https://%E3%80%82">https://</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entry1</para>
        /// </summary>
        [NameInMap("EntryName")]
        [Validation(Required=false)]
        public string EntryName { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 mapping entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6trans-bp1858ys****</para>
        /// </summary>
        [NameInMap("Ipv6TranslatorEntryId")]
        [Validation(Required=false)]
        public string Ipv6TranslatorEntryId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the IPv6 Translation Service instance. You can call the DescribeRegions operation to query the most recent region list.</para>
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
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b></description></item>
        /// <item><description><b>udp</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("TransProtocol")]
        [Validation(Required=false)]
        public string TransProtocol { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddZoneRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The location of the built-in authoritative zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL_ZONE</b>: Standard zone. DNS responses are cached. If a cache miss occurs, the query is sent to the built-in authoritative standard zone. The time to live (TTL) value affects the time when a DNS record change takes effect. You cannot use custom DNS lines or weighted round-robin.</para>
        /// </description></item>
        /// <item><description><para><b>FAST_ZONE</b>: Accelerated zone (recommended). DNS queries are directly responded to with the lowest latency. DNS record changes take effect in real time. You can use custom DNS lines and weighted round-robin.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>NORMAL_ZONE</b>.</para>
        /// <remarks>
        /// <para>The built-in authoritative accelerated zone is located before the cache module. DNS responses are not cached. This may increase the number of DNS queries and your costs.</para>
        /// </remarks>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>Starting from April 30, 2025 (UTC+8), when new users activate Alibaba Cloud DNS PrivateZone, added zones are set as accelerated zones by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FAST_ZONE</para>
        /// </summary>
        [NameInMap("DnsGroup")]
        [Validation(Required=false)]
        public string DnsGroup { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable subdomain recursive proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ZONE</b>: Disables the feature. If a DNS query for a subdomain that does not exist under the current domain name is received, an NXDOMAIN error is returned.</para>
        /// </description></item>
        /// <item><description><para><b>RECORD</b>: Enables the feature. If a DNS query for a subdomain that does not exist under the current domain name is received, the query is processed by the forwarding and recursion modules in sequence. The final result is used to respond to the DNS query.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>ZONE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZONE</para>
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmykd63gt****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the zone to add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// <para>This parameter is not available to users. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BLINK</para>
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public string ZoneTag { get; set; }

        /// <summary>
        /// <para>This parameter is not available to users. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_PRODUCT_ZONE</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}

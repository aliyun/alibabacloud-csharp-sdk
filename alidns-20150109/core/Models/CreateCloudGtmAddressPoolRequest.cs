// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmAddressPoolRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US (default): English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Address pool name, helping users distinguish the purpose of address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Address pool-1</para>
        /// </summary>
        [NameInMap("AddressPoolName")]
        [Validation(Required=false)]
        public string AddressPoolName { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4: IPv4 addresses are returned for Domain Name System (DNS) resolution.</description></item>
        /// <item><description>IPv6: IPv6 addresses are returned for DNS resolution.</description></item>
        /// <item><description>domain: Domain names are returned for DNS resolution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The enabling state of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable: The address pool is enabled, and the addresses in the address pool are returned for DNS resolution when the health check results are normal.</description></item>
        /// <item><description>disable: The address pool is disabled, and the addresses in the address pool are not returned for DNS resolution regardless of whether the health check results are normal or not.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The condition for determining the health status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>any_ok: At least one address in the address pool is available.</description></item>
        /// <item><description>p30_ok: At least 30% of the addresses in the address pool are available.</description></item>
        /// <item><description>p50_ok: At least 50% of the addresses in the address pool are available.</description></item>
        /// <item><description>p70_ok: At least 70% of the addresses in the address pool are available.</description></item>
        /// <item><description>all_ok: All addresses in the address pool are available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>any_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>Remarks for the address pool, helping users distinguish the usage scenarios of different address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

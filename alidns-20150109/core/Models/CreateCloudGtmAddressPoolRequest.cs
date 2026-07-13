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
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The name of the address pool. The name helps you identify the purpose of the address pool.</para>
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
        /// <item><description><para>IPv4: The endpoint is an IPv4 address.</para>
        /// </description></item>
        /// <item><description><para>IPv6: The endpoint is an IPv6 address.</para>
        /// </description></item>
        /// <item><description><para>domain: The endpoint is a domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a unique token for each request. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: The address pool is enabled and can be used for DNS resolution if it passes health checks.</para>
        /// </description></item>
        /// <item><description><para>disable: The address pool is disabled and cannot be used for DNS resolution, regardless of its health check status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health status condition of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one address in the address pool is active.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of the addresses in the address pool are active.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All addresses in the address pool are active.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>any_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>Remarks about the address pool. The remarks help you identify the scenario in which the address pool is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

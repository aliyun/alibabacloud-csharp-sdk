// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh-CN: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en-US: English.</para>
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
        /// <para>The billing method for the instance configuration:</para>
        /// <list type="bullet">
        /// <item><description><para>prepay: Subscription. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>postpay: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>postpay</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can specify a custom value, but you must make sure that the value is unique among different requests. The token can contain up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The status of the domain name instance:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enabled. The intelligent scheduling policy of the GTM instance is active.</para>
        /// </description></item>
        /// <item><description><para>disable: Disabled. The intelligent scheduling policy of the GTM instance is unavailable.</para>
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
        /// <para>The unique ID of the GTM 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-jmp3qnw**03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The host record of the GTM access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("ScheduleHostname")]
        [Validation(Required=false)]
        public string ScheduleHostname { get; set; }

        /// <summary>
        /// <para>The DNS record type of the access domain name:</para>
        /// <list type="bullet">
        /// <item><description><para>A: IPv4 address</para>
        /// </description></item>
        /// <item><description><para>AAAA: IPv6 address</para>
        /// </description></item>
        /// <item><description><para>CNAME: Canonical name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("ScheduleRrType")]
        [Validation(Required=false)]
        public string ScheduleRrType { get; set; }

        /// <summary>
        /// <para>The configuration mode for the access domain name:</para>
        /// <list type="bullet">
        /// <item><description><para>sys_assign: The system assigns a domain name. This mode is no longer supported.</para>
        /// </description></item>
        /// <item><description><para>custom: Custom mode. Select a domain name under the account that owns the instance and enter a host record to generate the access domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ScheduleZoneMode")]
        [Validation(Required=false)]
        public string ScheduleZoneMode { get; set; }

        /// <summary>
        /// <para>The zone name, which is the parent zone of the GTM access domain name. This is typically a domain name hosted in the Alibaba Cloud DNS console under the account that owns the GTM instance. Primary domains and subdomains are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

        /// <summary>
        /// <para>The global Time to Live (TTL) in seconds. This is the TTL for the access domain name that resolves to an address in an address pool. This value affects how long the DNS record is cached on a carrier\&quot;s local DNS server. You can specify a custom TTL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}

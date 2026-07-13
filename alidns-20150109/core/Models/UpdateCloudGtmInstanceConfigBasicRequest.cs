// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmInstanceConfigBasicRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (default): English.</para>
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
        /// <para>A client-generated token that you can use to ensure the idempotence of the request. Make sure that the token is unique among different requests. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the domain name instance configuration. For the same access domain name and GTM instance, you can configure both A and AAAA records. This results in two domain name instance configurations for the same GTM instance. The ConfigId uniquely identifies the configuration object that you want to modify.</para>
        /// <para>Call the <a href="~~ListCloudGtmInstanceConfigs~~">ListCloudGtmInstanceConfigs</a> operation to query the ConfigId of a domain name instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The root domain (such as example.com) or subdomain (such as a.example.com) of the GTM access domain name. This is usually a domain name that is hosted in the authoritative zone of the Alibaba Cloud DNS console under the account that owns the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

        /// <summary>
        /// <para>The global Time to Live (TTL) in seconds. This is the TTL for the DNS record that resolves the access domain name to an address in an address pool. The TTL affects how long the DNS record is cached on a carrier\&quot;s Local DNS server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}

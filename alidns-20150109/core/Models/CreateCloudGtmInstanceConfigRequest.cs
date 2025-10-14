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
        /// <item><description>zh-CN: Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>postpay/prepay</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can specify a custom value for this parameter, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The enabling state of the access domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable: The access domain name is enabled and the intelligent scheduling policy of the corresponding GTM instance takes effect.</description></item>
        /// <item><description>disable: The access domain name is disabled and the intelligent scheduling policy of the corresponding GTM instance is unavailable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager (GTM) 3.0 instance. This ID uniquely identifies a GTM 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-jmp3qnw**03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The description of the access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The hostname of the access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("ScheduleHostname")]
        [Validation(Required=false)]
        public string ScheduleHostname { get; set; }

        /// <summary>
        /// <para>The type of the Domain Name System (DNS) record configured for the access domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>A: IPv4 address</description></item>
        /// <item><description>AAAA: IPv6 address</description></item>
        /// <item><description>CNAME: domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("ScheduleRrType")]
        [Validation(Required=false)]
        public string ScheduleRrType { get; set; }

        /// <summary>
        /// <para>The configuration mode of the access domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sys_assign: system allocation. This mode is not supported.</description></item>
        /// <item><description>custom: custom allocation. You must select a zone within the account to which the instance belongs and enter a hostname to generate an access domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ScheduleZoneMode")]
        [Validation(Required=false)]
        public string ScheduleZoneMode { get; set; }

        /// <summary>
        /// <para>The name of the parent zone for the access domain name configured in GTM. In most cases, the value of this parameter is the name of a zone hosted by Alibaba Cloud DNS. This zone belongs to the account to which the GTM instance belongs. You can specify the name of a zone or subzone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

        /// <summary>
        /// <para>The global time to live (TTL) period. Unit: seconds. The global TTL period affects how long the DNS records that map the access domain name to the addresses in the address pools are cached in the local DNS servers of Internet service providers (ISPs). You can specify a custom value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}

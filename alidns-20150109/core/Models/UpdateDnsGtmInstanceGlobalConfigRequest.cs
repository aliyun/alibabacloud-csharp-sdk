// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmInstanceGlobalConfigRequest : TeaModel {
        /// <summary>
        /// <para>The alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateDnsGtmInstanceGlobalConfigRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to send alerts through DingTalk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: yes</para>
            /// </description></item>
            /// <item><description><para>false: no</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// <para>Specifies whether to send alerts by email. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: yes</para>
            /// </description></item>
            /// <item><description><para>false or null: no</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// <para>The type of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ADDR_ALERT: An address becomes unavailable.</para>
            /// </description></item>
            /// <item><description><para>ADDR_RESUME: An address becomes available.</para>
            /// </description></item>
            /// <item><description><para>ADDR_POOL_GROUP_UNAVAILABLE: An address pool group becomes unavailable.</para>
            /// </description></item>
            /// <item><description><para>ADDR_POOL_GROUP_AVAILABLE: An address pool group becomes available.</para>
            /// </description></item>
            /// <item><description><para>ACCESS_STRATEGY_POOL_GROUP_SWITCH: A switchover occurs between the primary and secondary address pools.</para>
            /// </description></item>
            /// <item><description><para>MONITOR_NODE_IP_CHANGE: The IP address of a monitoring node changes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ADDR_ALERT</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// <para>Specifies whether to send alerts through text messages. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: yes</para>
            /// </description></item>
            /// <item><description><para>false or null: no</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

        }

        /// <summary>
        /// <para>The alert contact group. The value is a JSON-formatted \<c>List\\&lt;string&gt;\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test1&quot;,&quot;test2&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The type of the CNAME record. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The CNAME record is used for Internet access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully update the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Forcefully updates the instance without checking for conflicts.</para>
        /// </description></item>
        /// <item><description><para>false or null: Does not forcefully update the instance. The system checks for conflicts before the update.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

        /// <summary>
        /// <para>The ID of the GTM instance. To obtain the instance ID, call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describednsgtminstances?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDnsGtmInstances</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance. This parameter is required when you update the instance for the first time. It is optional for subsequent updates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values: en, zh, and ja. The default value is en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The method used to access the instance over the Internet. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SYSTEM_ASSIGN: The system assigns a canonical name (CNAME) record. This option is disabled.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: You specify a CNAME record.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("PublicCnameMode")]
        [Validation(Required=false)]
        public string PublicCnameMode { get; set; }

        /// <summary>
        /// <para>The hostname of the CNAME record that is used for Internet access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.rr</para>
        /// </summary>
        [NameInMap("PublicRr")]
        [Validation(Required=false)]
        public string PublicRr { get; set; }

        /// <summary>
        /// <para>The service domain name that is accessed over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("PublicUserDomainName")]
        [Validation(Required=false)]
        public string PublicUserDomainName { get; set; }

        /// <summary>
        /// <para>The primary domain name that is used to access the instance over the Internet using a CNAME record. This parameter is required if you set PublicCnameMode to CUSTOM.</para>
        /// <remarks>
        /// <para>Enter the primary domain name. Do not include the hostname specified by the PublicRr parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("PublicZoneName")]
        [Validation(Required=false)]
        public string PublicZoneName { get; set; }

        /// <summary>
        /// <para>The global time to live (TTL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}

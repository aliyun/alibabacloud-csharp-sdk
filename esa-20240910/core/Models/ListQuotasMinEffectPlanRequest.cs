// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListQuotasMinEffectPlanRequest : TeaModel {
        /// <summary>
        /// <para>The plan instance ID. You can obtain the plan instance ID by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation. You must specify at least one of the InstanceId and SiteId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-aug976vv2u4g</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The plan quota names. Separate multiple names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: The action enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: The action enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: The statistical object enumeration for the custom device rate limiting type in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: The statistical object enumeration for the custom IP rate limiting type in WAF bot management.</description></item>
        /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: The match operator enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: The statistical object enumeration for the custom session rate limiting type in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: The match field enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: The match operator enumeration for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: The match field enumeration for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: The statistical object enumeration for the folder traverse blocking type in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: The statistical object enumeration for the high-frequency scan blocking type in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: The match operator enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: The match field enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: The action enumeration for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: The referenced rule group enumeration for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: The action enumeration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: The duration enumeration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: The statistical duration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: The match feature enumeration for the control type rule in WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: The match operator enumeration for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: The match field enumeration for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: The action enumeration for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: The match operator enumeration for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: The match fields for the WAF custom rule phase.</description></item>
        /// <item><description><b>waiting_room|queuing_method</b>: The queuing method for the waiting room.</description></item>
        /// <item><description><b>origin_rules|origin_scheme</b>: The back-to-origin protocol for origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_sni</b>: The back-to-origin SNI for origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_host</b>: The back-to-origin host for origin rules.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration.</description></item>
        /// <item><description><b>rtlog_service</b>: The real-time log feature switch.</description></item>
        /// <item><description><b>dashboard_traffic</b>: The value-added capability for network traffic analysis.</description></item>
        /// <item><description><b>custom_name_server</b>: The custom NS name.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: The WAF bot management switch.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: The WAF whitelist switch.</description></item>
        /// <item><description><b>instantlog</b>: Specifies whether instant logs are active.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: The WAF scan protection switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: The switch for configuring referenced rule groups in WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: The WAF managed rules switch.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: The switch for applying WAF rate limiting to cache-hit requests.</description></item>
        /// <item><description><b>ddos</b>: The DDoS instance.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: The switch for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: The switch for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: The WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: Specifies whether the rule DPI engine supports regular expression operations.</description></item>
        /// <item><description><b>waiting_room_event</b>: The scheduled event for the waiting room.</description></item>
        /// <item><description><b>waiting_room_rule</b>: The waiting room bypass rule.</description></item>
        /// <item><description><b>waiting_room|json_response</b>: The JSON response switch for the waiting room.</description></item>
        /// <item><description><b>waiting_room|disable_session_renewal</b>: The switch for disabling session renewal in the waiting room.</description></item>
        /// <item><description><b>origin_rules|dns_record</b>: The DNS record for origin rules.</description></item>
        /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: Specifies whether the real client IP header is active in transform rules.</description></item>
        /// <item><description><b>tiered_cache|regional_enable</b>: area caching.</description></item>
        /// <item><description><b>real_client_ip_header</b>: The client IP header.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf:phase:http_anti_scan:actions</para>
        /// </summary>
        [NameInMap("QuotaNames")]
        [Validation(Required=false)]
        public string QuotaNames { get; set; }

        /// <summary>
        /// <para>The site ID. You can obtain the site ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListQuotasMinEffectPlanRequest : TeaModel {
        /// <summary>
        /// <para>The plan instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the instance ID. You must specify at least one of this parameter and SiteId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-aug976vv2u4g</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The plan quota names, separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: WAF scan protection - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: WAF bot management - all action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: WAF bot management - custom device rate limiting statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: WAF bot management - custom IP rate limiting statistical object enumeration.</description></item>
        /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: WAF bot management - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: WAF bot management - custom session rate limiting statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: WAF bot management - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: WAF whitelist - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: WAF whitelist - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: WAF scan protection - folder traverse blocking statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: WAF scan protection - high-frequency scan blocking statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: WAF scan protection - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: WAF scan protection - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: WAF managed rules - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: WAF managed rules - referenced rule group enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: WAF rate limiting - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: WAF rate limiting - duration enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: WAF rate limiting - statistical period.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: WAF rate limiting - control type rule match characteristic enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: WAF rate limiting rule phase match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: WAF rate limiting rule phase match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: WAF custom rule phase action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: WAF custom rule phase match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: WAF custom rule phase match field.</description></item>
        /// <item><description><b>waiting_room|queuing_method</b>: waiting room - queuing method.</description></item>
        /// <item><description><b>origin_rules|origin_scheme</b>: back-to-origin rule - back-to-origin protocol.</description></item>
        /// <item><description><b>origin_rules|origin_sni</b>: back-to-origin rule - back-to-origin SNI.</description></item>
        /// <item><description><b>origin_rules|origin_host</b>: back-to-origin rule - back-to-origin host.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration.</description></item>
        /// <item><description><b>rtlog_service</b>: real-time log feature switch.</description></item>
        /// <item><description><b>dashboard_traffic</b>: value-added capability for network traffic analysis.</description></item>
        /// <item><description><b>custom_name_server</b>: custom NS name.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: WAF bot management switch.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: WAF whitelist switch.</description></item>
        /// <item><description><b>instantlog</b>: instant log active or not.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: WAF scan protection switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: WAF managed rules - referenced rule group configuration switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: WAF managed rules switch.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: WAF rate limiting - apply to cache-hit requests switch.</description></item>
        /// <item><description><b>ddos</b>: DDoS instance.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: WAF rate limiting rule phase switch.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: WAF custom rule phase switch.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: whether the DPI engine supports regular expressions.</description></item>
        /// <item><description><b>waiting_room_event</b>: waiting room - scheduled event.</description></item>
        /// <item><description><b>waiting_room_rule</b>: waiting room - bypass waiting room.</description></item>
        /// <item><description><b>waiting_room|json_response</b>: waiting room - enable JSON response.</description></item>
        /// <item><description><b>waiting_room|disable_session_renewal</b>: waiting room - disable session renewal.</description></item>
        /// <item><description><b>origin_rules|dns_record</b>: back-to-origin rule - DNS record.</description></item>
        /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: whether the real client IP header is active in transform rules.</description></item>
        /// <item><description><b>tiered_cache|regional_enable</b>: area cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: client IP header.</description></item>
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
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
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

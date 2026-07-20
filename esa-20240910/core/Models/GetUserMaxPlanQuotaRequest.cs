// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserMaxPlanQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The plan quota name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: WAF scan protection - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: WAF bot management - all action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: WAF bot management - custom device rate limiting type statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: WAF bot management - custom IP rate limiting type statistical object enumeration.</description></item>
        /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: WAF bot management - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: WAF bot management - custom session rate limiting type statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: WAF bot management - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: WAF whitelist - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: WAF whitelist - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: WAF scan protection - folder traverse blocking type statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: WAF scan protection - high-frequency scan blocking type statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: WAF scan protection - match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: WAF scan protection - match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: WAF managed rules - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: WAF managed rules - referenced rule group enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: WAF rate limiting - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: WAF rate limiting - duration enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: WAF rate limiting - statistical duration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: WAF rate limiting - control type rule - match characteristic enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: WAF rate limiting rule phase match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: WAF rate limiting rule phase match field enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: WAF custom rule phase action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: WAF custom rule phase match operator enumeration.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: WAF custom rule phase match field.</description></item>
        /// <item><description><b>waiting_room|queuing_method</b>: Waiting room - queuing method.</description></item>
        /// <item><description><b>origin_rules|origin_scheme</b>: Back-to-origin rules - back-to-origin protocol.</description></item>
        /// <item><description><b>origin_rules|origin_sni</b>: Back-to-origin rules - back-to-origin SNI.</description></item>
        /// <item><description><b>origin_rules|origin_host</b>: Back-to-origin rules - back-to-origin host.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration.</description></item>
        /// <item><description><b>rtlog_service</b>: Real-time log feature switch.</description></item>
        /// <item><description><b>dashboard_traffic</b>: Value-added capability of network traffic analysis.</description></item>
        /// <item><description><b>custom_name_server</b>: Custom NS name.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: WAF bot management switch.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: WAF whitelist switch.</description></item>
        /// <item><description><b>instantlog</b>: Instant log active or not.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: WAF scan protection switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: WAF managed rules - referenced rule group configuration switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: WAF managed rules switch.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: WAF rate limiting - apply on cache-hit requests switch.</description></item>
        /// <item><description><b>ddos</b>: DDoS instance.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: WAF rate limiting rule phase switch.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: WAF custom rule phase switch.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: Specifies whether the DPI engine supports regular expressions.</description></item>
        /// <item><description><b>waiting_room_event</b>: Waiting room - scheduled event.</description></item>
        /// <item><description><b>waiting_room_rule</b>: Waiting room - bypass waiting room.</description></item>
        /// <item><description><b>waiting_room|json_response</b>: Waiting room - enable JSON response.</description></item>
        /// <item><description><b>waiting_room|disable_session_renewal</b>: Waiting room - disable session renewal.</description></item>
        /// <item><description><b>origin_rules|dns_record</b>: Back-to-origin rules - DNS record.</description></item>
        /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: Specifies whether the real client IP header is active in transform rules.</description></item>
        /// <item><description><b>tiered_cache|regional_enable</b>: Area cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: Client IP header.</description></item>
        /// <item><description><b>data_timerange</b>: Data query time range - in minutes.</description></item>
        /// <item><description><b>cache_rules|edge_cache_ttl</b>: Cache - node TTL.</description></item>
        /// <item><description><b>cache_rules|browser_cache_ttl</b>: Cache - browser TTL.</description></item>
        /// <item><description><b>fourLayerRecordCount</b>: Record count limit for Layer 4 acceleration.</description></item>
        /// <item><description><b>waitingroomRuleCount</b>: Maximum number of rules per waiting room ID.</description></item>
        /// <item><description><b>waitingroomEventCount</b>: Maximum number of events per waiting room ID.</description></item>
        /// <item><description><b>waitingroom_custom_pathhost</b>: Waiting room - hostname and path.</description></item>
        /// <item><description><b>er_routers</b>: Function routing.</description></item>
        /// <item><description><b>cache_rules|rule_quota</b>: Cache rules.</description></item>
        /// <item><description><b>configuration_rules|rule_quota</b>: Configuration rules.</description></item>
        /// <item><description><b>redirect_rules|rule_quota</b>: Redirect rules.</description></item>
        /// <item><description><b>compression_rules|rule_quota</b>: Compression rules.</description></item>
        /// <item><description><b>origin_rules|rule_quota</b>: Back-to-origin rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:rulesets_per_instance:less_than_or_equal</b>: WAF bot management - maximum number of rule groups per instance.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:rules_per_instance:less_than_or_equal</b>: WAF whitelist - maximum number of rules per instance.</description></item>
        /// <item><description><b>rtlog_quota</b>: Quota for real-time log push node count.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:rulesets_per_instance:less_than_or_equal</b>: WAF scan protection - maximum number of rule groups per instance.</description></item>
        /// <item><description><b>ddos_instance</b>: Number of DDoS instances.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:rules_per_instance:less_than_or_equal</b>: Maximum number of WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:rules_per_instance:less_than_or_equal</b>: WAF custom rule phase - maximum number of rules per instance.</description></item>
        /// <item><description><b>ruleNestedConditionalCount</b>: Number of rule nesting levels.</description></item>
        /// <item><description><b>waiting_room</b>: Waiting room.</description></item>
        /// <item><description><b>transition_rule</b>: Transform rules.</description></item>
        /// <item><description><b>customHttpCert</b>: Number of custom certificates.</description></item>
        /// <item><description><b>free_cert</b>: Number of free certificates.</description></item>
        /// <item><description><b>preload</b>: Resource prefetch.</description></item>
        /// <item><description><b>refresh_cache_tag</b>: Refresh - cache tag.</description></item>
        /// <item><description><b>refresh_ignore_param</b>: Refresh - purge without parameters.</description></item>
        /// <item><description><b>refresh_directory</b>: Refresh - purge by folder.</description></item>
        /// <item><description><b>refresh_hostname</b>: Refresh - purge by hostname.</description></item>
        /// <item><description><b>refresh_all</b>: Refresh - purge all cache.</description></item>
        /// <item><description><b>refresh_file</b>: URL refresh.</description></item>
        /// <item><description><b>wildcard</b>: Number of wildcard domain names.</description></item>
        /// <item><description><b>recordCount</b>: Number of Layer 7 records.</description></item>
        /// <item><description><b>siteCount</b>: Number of sites.</description></item>
        /// <item><description><b>https|rule_quota</b>: Number of SSL/TLS rules.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>siteCount</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

    }

}

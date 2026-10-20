// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserMaxPlanQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The name of the plan quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: Actions for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: All actions for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: Statistical objects for custom device rate limiting in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: Statistical objects for custom IP rate limiting in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:symbols</b>: Match symbols for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: Statistical objects for custom session rate limiting in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: Match fields for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: Match symbols for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: Match fields for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: Statistical objects for folder traverse blocking in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: Statistical objects for high-frequency scan blocking in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: Match symbols for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: Match fields for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: Actions for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: Referenced rule groups for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: Actions for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: Durations for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: Statistical durations for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: Match features for control type rules in WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: Match symbols for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: Match fields for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: Actions for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: Match symbols for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: Match fields for the WAF custom rule phase.</description></item>
        /// <item><description><b>waiting_room|queuing_method</b>: Queuing method for the waiting room.</description></item>
        /// <item><description><b>origin_rules|origin_scheme</b>: Back-to-origin protocol for back-to-origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_sni</b>: Back-to-origin SNI for back-to-origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_host</b>: Back-to-origin host for back-to-origin rules.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration.</description></item>
        /// <item><description><b>rtlog_service</b>: Real-time log feature switch.</description></item>
        /// <item><description><b>dashboard_traffic</b>: Value-added capability for network traffic analysis.</description></item>
        /// <item><description><b>custom_name_server</b>: Custom NS name.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: WAF bot management switch.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: WAF whitelist switch.</description></item>
        /// <item><description><b>instantlog</b>: Whether instant logs are active.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: WAF scan protection switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: Switch for configuring referenced rule groups in WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: WAF managed rules switch.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: Switch for applying WAF rate limiting to cached requests.</description></item>
        /// <item><description><b>ddos</b>: DDoS instance.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: Switch for the WAF rate limiting rule phase.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: Switch for the WAF custom rule phase.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: Whether the rule DPI engine supports regular expressions.</description></item>
        /// <item><description><b>waiting_room_event</b>: Scheduled events for the waiting room.</description></item>
        /// <item><description><b>waiting_room_rule</b>: Bypass the waiting room.</description></item>
        /// <item><description><b>waiting_room|json_response</b>: Enable JSON response for the waiting room.</description></item>
        /// <item><description><b>waiting_room|disable_session_renewal</b>: Disable session renewal for the waiting room.</description></item>
        /// <item><description><b>origin_rules|dns_record</b>: DNS record for back-to-origin rules.</description></item>
        /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: Whether the real client IP header is available in transformation rules.</description></item>
        /// <item><description><b>tiered_cache|regional_enable</b>: Area cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: Client IP header.</description></item>
        /// <item><description><b>data_timerange</b>: Data query time in minutes.</description></item>
        /// <item><description><b>cache_rules|edge_cache_ttl</b>: Edge node TTL for cache.</description></item>
        /// <item><description><b>cache_rules|browser_cache_ttl</b>: Browser TTL for cache.</description></item>
        /// <item><description><b>fourLayerRecordCount</b>: Record count limit for Layer 4 acceleration.</description></item>
        /// <item><description><b>waitingroomRuleCount</b>: Number of rules that can be associated with a single waitingRoomId.</description></item>
        /// <item><description><b>waitingroomEventCount</b>: Number of events that can be associated with a single waitingRoomId.</description></item>
        /// <item><description><b>waitingroom_custom_pathhost</b>: Hostname and path for the waiting room.</description></item>
        /// <item><description><b>er_routers</b>: Function routing.</description></item>
        /// <item><description><b>cache_rules|rule_quota</b>: Cache rules.</description></item>
        /// <item><description><b>configuration_rules|rule_quota</b>: Configuration rules.</description></item>
        /// <item><description><b>redirect_rules|rule_quota</b>: Redirect rules.</description></item>
        /// <item><description><b>compression_rules|rule_quota</b>: Compression rules.</description></item>
        /// <item><description><b>origin_rules|rule_quota</b>: Back-to-origin rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:rulesets_per_instance:less_than_or_equal</b>: Maximum number of rule groups per instance in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:rules_per_instance:less_than_or_equal</b>: Maximum number of rules per instance in the WAF whitelist.</description></item>
        /// <item><description><b>rtlog_quota</b>: Quota for the number of real-time log push tasks.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:rulesets_per_instance:less_than_or_equal</b>: Maximum number of rule groups per instance in WAF scan protection.</description></item>
        /// <item><description><b>ddos_instance</b>: Number of DDoS instances.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:rules_per_instance:less_than_or_equal</b>: Maximum number of WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:rules_per_instance:less_than_or_equal</b>: Maximum number of rules per instance in the WAF custom rule phase.</description></item>
        /// <item><description><b>ruleNestedConditionalCount</b>: Nesting level of rules.</description></item>
        /// <item><description><b>waiting_room</b>: Waiting room.</description></item>
        /// <item><description><b>transition_rule</b>: Transformation rules.</description></item>
        /// <item><description><b>customHttpCert</b>: Number of custom certificates.</description></item>
        /// <item><description><b>free_cert</b>: Number of free certificates.</description></item>
        /// <item><description><b>preload</b>: Prefetch.</description></item>
        /// <item><description><b>refresh_cache_tag</b>: Refresh - cache tag.</description></item>
        /// <item><description><b>refresh_ignore_param</b>: Refresh - refresh ignoring parameters.</description></item>
        /// <item><description><b>refresh_directory</b>: Refresh - refresh by folder.</description></item>
        /// <item><description><b>refresh_hostname</b>: Refresh - refresh by hostname.</description></item>
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

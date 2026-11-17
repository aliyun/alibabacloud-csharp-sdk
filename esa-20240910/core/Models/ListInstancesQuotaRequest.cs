// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstancesQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The instance IDs. Separate multiple IDs with commas (,). You can obtain the instance IDs by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****,sp-xcdn-81wblslz****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The quota names. Separate multiple names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: Action enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: Action enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: Statistical object enumeration for custom device rate limiting in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: Statistical object enumeration for custom IP rate limiting in WAF bot management.</description></item>
        /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: Match operator enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: Statistical object enumeration for custom session rate limiting in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: Match field enumeration for WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: Match operator enumeration for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: Match field enumeration for the WAF whitelist.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: Statistical object enumeration for folder traverse blocking in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: Statistical object enumeration for high-frequency scan blocking in WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: Match operator enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: Match field enumeration for WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: Action enumeration for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: Referenced rule group enumeration for WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: Action enumeration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: Duration enumeration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: Statistical duration for WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: Match feature enumeration for WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: Match operator enumeration for WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: Match field enumeration for WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: Action enumeration for WAF custom rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: Match operator enumeration for WAF custom rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: Match fields for WAF custom rules.</description></item>
        /// <item><description><b>waiting_roomqueuing_method</b>: Queuing method for the waiting room.</description></item>
        /// <item><description><b>origin_rulesorigin_scheme</b>: Back-to-origin protocol for origin rules.</description></item>
        /// <item><description><b>origin_rulesorigin_sni</b>: Back-to-origin SNI for origin rules.</description></item>
        /// <item><description><b>origin_rulesorigin_host</b>: Back-to-origin host for origin rules.</description></item>
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
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: WAF rate limiting rule switch.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: WAF custom rule switch.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: Whether the rule DPI engine supports regular expression operations.</description></item>
        /// <item><description><b>waiting_room_event</b>: Scheduled events for the waiting room.</description></item>
        /// <item><description><b>waiting_room_rule</b>: Bypass waiting room.</description></item>
        /// <item><description><b>waiting_roomjson_response</b>: Enable JSON response for the waiting room.</description></item>
        /// <item><description><b>waiting_roomdisable_session_renewal</b>: Disable session renewal for the waiting room.</description></item>
        /// <item><description><b>origin_rulesdns_record</b>: DNS record for origin rules.</description></item>
        /// <item><description><b>managed_transformsadd_client_geolocation_headers</b>: Whether the real client IP header is active in transformation rules.</description></item>
        /// <item><description><b>tiered_cacheregional_enable</b>: Area cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: Client IP header.</description></item>
        /// <item><description><b>data_timerange</b>: Data query time in minutes.</description></item>
        /// <item><description><b>cache_rulesedge_cache_ttl</b>: Edge node TTL for cache rules.</description></item>
        /// <item><description><b>cache_rulesbrowser_cache_ttl</b>: Browser TTL for cache rules.</description></item>
        /// <item><description><b>fourLayerRecordCount</b>: Record count limit for Layer 4 acceleration.</description></item>
        /// <item><description><b>waitingroomRuleCount</b>: Number of rules that can be associated with a single waitingRoomId.</description></item>
        /// <item><description><b>waitingroomEventCount</b>: Number of events that can be associated with a single waitingRoomId.</description></item>
        /// <item><description><b>waitingroom_custom_pathhost</b>: Hostname and path for the waiting room.</description></item>
        /// <item><description><b>er_routers</b>: Function routing.</description></item>
        /// <item><description><b>cache_rulesrule_quota</b>: Cache rules.</description></item>
        /// <item><description><b>configuration_rulesrule_quota</b>: Configuration rules.</description></item>
        /// <item><description><b>redirect_rulesrule_quota</b>: Redirect rules.</description></item>
        /// <item><description><b>compression_rulesrule_quota</b>: Compression rules.</description></item>
        /// <item><description><b>origin_rulesrule_quota</b>: Origin rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:rulesets_per_instance:less_than_or_equal</b>: Maximum number of rule groups per instance in WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:rules_per_instance:less_than_or_equal</b>: Maximum number of rules per instance in the WAF whitelist.</description></item>
        /// <item><description><b>rtlog_quota</b>: Quota for the number of real-time log push tasks.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:rulesets_per_instance:less_than_or_equal</b>: Maximum number of rule groups per instance in WAF scan protection.</description></item>
        /// <item><description><b>ddos_instance</b>: Number of DDoS instances.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:rules_per_instance:less_than_or_equal</b>: Maximum number of WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:rules_per_instance:less_than_or_equal</b>: Maximum number of rules per instance for WAF custom rules.</description></item>
        /// <item><description><b>ruleNestedConditionalCount</b>: Nesting level of rules.</description></item>
        /// <item><description><b>waiting_room</b>: Waiting room.</description></item>
        /// <item><description><b>transition_rule</b>: Transformation rules.</description></item>
        /// <item><description><b>customHttpCert</b>: Number of custom certificates.</description></item>
        /// <item><description><b>free_cert</b>: Number of free certificates.</description></item>
        /// <item><description><b>preload</b>: Prefetch.</description></item>
        /// <item><description><b>refresh_cache_tag</b>: Refresh by cache tag.</description></item>
        /// <item><description><b>refresh_ignore_param</b>: Refresh without parameters.</description></item>
        /// <item><description><b>refresh_directory</b>: Refresh by folder.</description></item>
        /// <item><description><b>refresh_hostname</b>: Refresh by hostname.</description></item>
        /// <item><description><b>refresh_all</b>: Purge all caches.</description></item>
        /// <item><description><b>refresh_file</b>: URL refresh.</description></item>
        /// <item><description><b>wildcard</b>: Number of wildcard domain names.</description></item>
        /// <item><description><b>recordCount</b>: Number of Layer 7 records.</description></item>
        /// <item><description><b>siteCount</b>: Number of sites.</description></item>
        /// <item><description><b>httpsrule_quota</b>: Number of SSL/TLS rules.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf:phase:http_anti_scan:actions, waf:phase:http_bot:actions, siteCount</para>
        /// </summary>
        [NameInMap("QuotaName")]
        [Validation(Required=false)]
        public string QuotaName { get; set; }

    }

}

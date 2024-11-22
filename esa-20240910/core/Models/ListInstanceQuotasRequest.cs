// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstanceQuotasRequest : TeaModel {
        /// <summary>
        /// <para>The plan ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The quota names in the plan. Separate multiple names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: the actions in WAF scan protection rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: all actions in WAF bot management rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: the statistical objects for the custom device-based throttling in WAF bot management rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: the statistical objects for the custom IP address-based throttling in WAF bot management rules.</description></item>
        /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: the match operators in WAF bot management rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: the statistical objects for the custom session-based throttling in WAF bot management rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:fields</b>: the match fields in WAF bot management rules.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: the match operators in WAF whitelist rules.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: the match fields in WAF whitelist rules.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: the statistical objects for directory traversal blocking in WAF scan protection rules.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: the statistical objects for high-frequency scanning blocking in WAF scan protection rules.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: the match operators in WAF scan protection rules.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: the match fields in WAF scan protection rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:actions</b>: the actions in WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: the referenced rule groups in WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:actions</b>: the actions in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: the action durations in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: the statistical durations in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: the match characteristics in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: the match operators in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: the match fields in WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:actions</b>: the actions in custom WAF rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:symbols</b>: the match operators in custom WAF rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:match:fields</b>: the match fields in custom WAF rules.</description></item>
        /// <item><description><b>waiting_room|queuing_method</b>: the queuing method in Waiting Room.</description></item>
        /// <item><description><b>origin_rules|origin_scheme</b>: the origin protocol in origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_sni</b>: the origin Server Name Indication (SNI) in origin rules.</description></item>
        /// <item><description><b>origin_rules|origin_host</b>: the origin host in origin rules.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: TCP/UDP proxy.</description></item>
        /// <item><description><b>rtlog_service</b>: the availability to collect real-time logs.</description></item>
        /// <item><description><b>dashboard_traffic</b>: the value-added capability of traffic analytics.</description></item>
        /// <item><description><b>custom_name_server</b>: the availability to configure custom nameservers.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: the availability to enable WAF bot management.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: the availability to configure WAF whitelist rules.</description></item>
        /// <item><description><b>instantlog</b>: the availability to collect instant logs.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: the availability to enable WAF scan protection.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: the availability to configure reference rule groups in WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: the availability to configure WAF managed rules.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: the availability to configure whether to apply rate limiting to all requests that hit the cache.</description></item>
        /// <item><description><b>ddos</b>: DDoS mitigation.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: the availability to configure WAF rate limiting.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: the availability to configure custom WAF rules.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: the availability to configure custom error pages.</description></item>
        /// <item><description><b>rules_support_regex</b>: the support for regular expressions in rules engine.</description></item>
        /// <item><description><b>waiting_room_event</b>: scheduled events in Waiting Room.</description></item>
        /// <item><description><b>waiting_room_rule</b>: the availability to allow requests to bypass the waiting room.</description></item>
        /// <item><description><b>waiting_room|json_response</b>: the availability to enable JSON response in Waiting Room.</description></item>
        /// <item><description><b>waiting_room|disable_session_renewal</b>: the availability to disable session renewal in Waiting Room.</description></item>
        /// <item><description><b>origin_rules|dns_record</b>: DNS records in origin rules.</description></item>
        /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: the availability to configure whether to add geolocation headers in transform rules.</description></item>
        /// <item><description><b>tiered_cache|regional_enable</b>: regional tiered cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: the availability to configure whether to add the real IP address of a client to the request header.</description></item>
        /// <item><description><b>data_timerange</b>: minute-level time range for data query.</description></item>
        /// <item><description><b>cache_rules|edge_cache_ttl</b>: POP cache TTL.</description></item>
        /// <item><description><b>cache_rules|browser_cache_ttl</b>: browser cache TTL.</description></item>
        /// <item><description><b>fourLayerRecordCount</b>: the maximum number of records of websites for which TCP/UDP acceleration is enabled.</description></item>
        /// <item><description><b>waitingroomRuleCount</b>: the maximum number of rules per waiting room.</description></item>
        /// <item><description><b>waitingroomEventCount</b>: the maximum number of events per waiting room.</description></item>
        /// <item><description><b>waitingroom_custom_pathhost</b>: the availability to configure the hostname and path in Waiting Room.</description></item>
        /// <item><description><b>er_routers</b>: Edge Routine routes.</description></item>
        /// <item><description><b>cache_rules|rule_quota</b>: the maximum number of cache rules.</description></item>
        /// <item><description><b>configuration_rules|rule_quota</b>: the maximum number of configuration rules.</description></item>
        /// <item><description><b>redirect_rules|rule_quota</b>: the redirect rules.</description></item>
        /// <item><description><b>compression_rules|rule_quota</b>: the maximum number of compression rules.</description></item>
        /// <item><description><b>origin_rules|rule_quota</b>: the maximum number of origin rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:rulesets_per_instance:less_than_or_equal</b>: the maximum number of rulesets in WAF bot management per plan.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:rules_per_instance:less_than_or_equal</b>: the maximum number of WAF whitelist rules per plan.</description></item>
        /// <item><description><b>rtlog_quota</b>: the maximum number of real-time log delivery tasks.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:rulesets_per_instance:less_than_or_equal</b>: the maximum number of rulesets in WAF scan protection per plan.</description></item>
        /// <item><description><b>ddos_instance</b>: the number of Anti-DDoS Proxy instances.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:rules_per_instance:less_than_or_equal</b>: the maximum number of WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:rules_per_instance:less_than_or_equal</b>: the maximum number of custom WAF rules per plan.</description></item>
        /// <item><description><b>ruleNestedConditionalCount</b>: the number of nested layers in a rule.</description></item>
        /// <item><description><b>waiting_room_rule</b>: Waiting Room.</description></item>
        /// <item><description><b>transition_rule</b>: the maximum number of transform rules.</description></item>
        /// <item><description><b>customHttpCert</b>: the maximum number of custom certificates.</description></item>
        /// <item><description><b>free_cert</b>: the maximum number of free certificates.</description></item>
        /// <item><description><b>preload</b>: prefetch.</description></item>
        /// <item><description><b>refresh_cache_tag</b>: purge by cache tag.</description></item>
        /// <item><description><b>refresh_ignore_param</b>: purge by URL with specified parameters ignored.</description></item>
        /// <item><description><b>refresh_directory</b>: purge by directory.</description></item>
        /// <item><description><b>refresh_hostname</b>: purge by hostname.</description></item>
        /// <item><description><b>refresh_all</b>: purge all cache.</description></item>
        /// <item><description><b>refresh_file</b>: purge by URL.</description></item>
        /// <item><description><b>wildcard</b>: the maximum number of wildcard domains.</description></item>
        /// <item><description><b>recordCount</b>: the maximum number of Layer 7 records.</description></item>
        /// <item><description><b>siteCount</b>: the maximum number of websites that can be associated with the plan.</description></item>
        /// <item><description><b>https|rule_quota</b>: the maximum number of SSL/TLS rules.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>preload, free_cert</para>
        /// </summary>
        [NameInMap("QuotaNames")]
        [Validation(Required=false)]
        public string QuotaNames { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2882900****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListInstancesQuotaRequest : TeaModel {
        /// <summary>
        /// <para>Multiple instance IDs separated by commas (,). You can obtain instance IDs by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-xcdn-96wblslz****,sp-xcdn-81wblslz****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The quota name. Separate multiple names with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>waf:phase:http_anti_scan:actions</b>: WAF scan protection - action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:actions</b>: WAF bot management - all action enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: WAF bot management - custom device rate limiting statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: WAF bot management - custom IP rate limiting statistical object enumeration.</description></item>
        /// <item><description><b>waf:phase:http_bot:match:symbols</b>: WAF bot management - match operator enumeration.</description></item>
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
        /// <item><description><b>waiting_roomqueuing_method</b>: waiting room - queuing method.</description></item>
        /// <item><description><b>origin_rulesorigin_scheme</b>: back-to-origin rules - back-to-origin protocol.</description></item>
        /// <item><description><b>origin_rulesorigin_sni</b>: back-to-origin rules - back-to-origin SNI.</description></item>
        /// <item><description><b>origin_rulesorigin_host</b>: back-to-origin rules - back-to-origin host.</description></item>
        /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration.</description></item>
        /// <item><description><b>rtlog_service</b>: real-time log feature switch.</description></item>
        /// <item><description><b>dashboard_traffic</b>: value-added capability of network traffic analysis.</description></item>
        /// <item><description><b>custom_name_server</b>: custom NS name.</description></item>
        /// <item><description><b>waf:phase:http_bot:enable</b>: WAF bot management switch.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:enable</b>: WAF whitelist switch.</description></item>
        /// <item><description><b>instantlog</b>: instant log active or inactive.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:enable</b>: WAF scan protection switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: WAF managed rules - referenced rule group configuration switch.</description></item>
        /// <item><description><b>waf:phase:http_managed:enable</b>: WAF managed rules switch.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: WAF rate limiting - apply on cache-hit requests switch.</description></item>
        /// <item><description><b>ddos</b>: DDoS instance.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:enable</b>: WAF rate limiting rule phase switch.</description></item>
        /// <item><description><b>waf:phase:http_custom:enable</b>: WAF custom rule phase switch.</description></item>
        /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch.</description></item>
        /// <item><description><b>rules_support_regex</b>: whether the rule DPI engine supports regular expressions.</description></item>
        /// <item><description><b>waiting_room_event</b>: waiting room - scheduled event.</description></item>
        /// <item><description><b>waiting_room_rule</b>: waiting room - bypass waiting room.</description></item>
        /// <item><description><b>waiting_roomjson_response</b>: waiting room - enable JSON response.</description></item>
        /// <item><description><b>waiting_roomdisable_session_renewal</b>: waiting room - disable session renewal.</description></item>
        /// <item><description><b>origin_rulesdns_record</b>: back-to-origin rules - DNS record.</description></item>
        /// <item><description><b>managed_transformsadd_client_geolocation_headers</b>: whether the real client IP header is active in transform rules.</description></item>
        /// <item><description><b>tiered_cacheregional_enable</b>: area cache.</description></item>
        /// <item><description><b>real_client_ip_header</b>: client IP header.</description></item>
        /// <item><description><b>data_timerange</b>: data query time range in minutes.</description></item>
        /// <item><description><b>cache_rulesedge_cache_ttl</b>: cache - edge TTL.</description></item>
        /// <item><description><b>cache_rulesbrowser_cache_ttl</b>: cache - browser TTL.</description></item>
        /// <item><description><b>fourLayerRecordCount</b>: record count limit for Layer 4 acceleration.</description></item>
        /// <item><description><b>waitingroomRuleCount</b>: maximum number of rules per waiting room ID.</description></item>
        /// <item><description><b>waitingroomEventCount</b>: maximum number of events per waiting room ID.</description></item>
        /// <item><description><b>waitingroom_custom_pathhost</b>: waiting room - hostname and path.</description></item>
        /// <item><description><b>er_routers</b>: function routing.</description></item>
        /// <item><description><b>cache_rulesrule_quota</b>: cache rules.</description></item>
        /// <item><description><b>configuration_rulesrule_quota</b>: configuration rules.</description></item>
        /// <item><description><b>redirect_rulesrule_quota</b>: redirect rules.</description></item>
        /// <item><description><b>compression_rulesrule_quota</b>: compression rules.</description></item>
        /// <item><description><b>origin_rulesrule_quota</b>: back-to-origin rules.</description></item>
        /// <item><description><b>waf:phase:http_bot:rulesets_per_instance:less_than_or_equal</b>: WAF bot management - maximum number of rule groups per instance.</description></item>
        /// <item><description><b>waf:phase:http_whitelist:rules_per_instance:less_than_or_equal</b>: WAF whitelist - maximum number of rules per instance.</description></item>
        /// <item><description><b>rtlog_quota</b>: quota for real-time log push node count.</description></item>
        /// <item><description><b>waf:phase:http_anti_scan:rulesets_per_instance:less_than_or_equal</b>: WAF scan protection - maximum number of rule groups per instance.</description></item>
        /// <item><description><b>ddos_instance</b>: number of DDoS instances.</description></item>
        /// <item><description><b>waf:phase:http_ratelimit:rules_per_instance:less_than_or_equal</b>: maximum number of WAF rate limiting rules.</description></item>
        /// <item><description><b>waf:phase:http_custom:rules_per_instance:less_than_or_equal</b>: WAF custom rule phase - maximum number of rules per instance.</description></item>
        /// <item><description><b>ruleNestedConditionalCount</b>: number of nesting levels for rules.</description></item>
        /// <item><description><b>waiting_room</b>: waiting room.</description></item>
        /// <item><description><b>transition_rule</b>: transform rule.</description></item>
        /// <item><description><b>customHttpCert</b>: number of custom certificates.</description></item>
        /// <item><description><b>free_cert</b>: number of free certificates.</description></item>
        /// <item><description><b>preload</b>: resource prefetch.</description></item>
        /// <item><description><b>refresh_cache_tag</b>: refresh - cache tag.</description></item>
        /// <item><description><b>refresh_ignore_param</b>: refresh - purge without parameters.</description></item>
        /// <item><description><b>refresh_directory</b>: refresh - purge by folder.</description></item>
        /// <item><description><b>refresh_hostname</b>: refresh - purge by hostname.</description></item>
        /// <item><description><b>refresh_all</b>: refresh - purge all cache.</description></item>
        /// <item><description><b>refresh_file</b>: URL purge.</description></item>
        /// <item><description><b>wildcard</b>: number of wildcard domain names.</description></item>
        /// <item><description><b>recordCount</b>: number of Layer 7 records.</description></item>
        /// <item><description><b>siteCount</b>: number of sites.</description></item>
        /// <item><description><b>httpsrule_quota</b>: number of SSL/TLS rules.</description></item>
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

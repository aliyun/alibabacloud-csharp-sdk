// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListQuotasMinEffectPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the minimum required plan versions for the quotas.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotasMinEffectPlanResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotasMinEffectPlanResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The quota name. Valid values:</para>
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
            /// <item><description><b>waitingroom|wr_queueing_method</b>: The queuing method for the waiting room.</description></item>
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
            /// <item><description><b>waitingroom_event</b>: The scheduled event for the waiting room.</description></item>
            /// <item><description><b>waitingroom_rule</b>: The waiting room bypass rule.</description></item>
            /// <item><description><b>waitingroom|wr_json_response</b>: The JSON response switch for the waiting room.</description></item>
            /// <item><description><b>waitingroom|wr_disable_session_renewal</b>: The switch for disabling session renewal in the waiting room.</description></item>
            /// <item><description><b>origin_rules|dns_record</b>: The DNS record for origin rules.</description></item>
            /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: Specifies whether the real client IP header is active in transform rules.</description></item>
            /// <item><description><b>tiered_cache|regional_enable</b>: area caching.</description></item>
            /// <item><description><b>real_client_ip_header</b>: The client IP header.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf:phase:http_anti_scan:actions</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The threshold details of the quota.</para>
            /// </summary>
            [NameInMap("QuotaValueDetail")]
            [Validation(Required=false)]
            public List<ListQuotasMinEffectPlanResponseBodyQuotasQuotaValueDetail> QuotaValueDetail { get; set; }
            public class ListQuotasMinEffectPlanResponseBodyQuotasQuotaValueDetail : TeaModel {
                /// <summary>
                /// <para>Specifies whether the quota value is available in the plan version corresponding to the current site. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ture: Available.</description></item>
                /// <item><description>false: Not available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsEffect")]
                [Validation(Required=false)]
                public string IsEffect { get; set; }

                /// <summary>
                /// <para>The minimum required plan version for the quota value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>basic: Basic Edition.</description></item>
                /// <item><description>medium: Standard Edition.</description></item>
                /// <item><description>high: Advanced Edition.</description></item>
                /// <item><description>enterprise_standard_cn: Enterprise Edition.</description></item>
                /// </list>
                /// <para>The return value of this parameter follows these rules:</para>
                /// <list type="bullet">
                /// <item><description>If the quota value is already available in the current plan version, this parameter is left empty, which means the minimum required plan version is not displayed.</description></item>
                /// <item><description>If the quota value is not available in the current plan version, the minimum required plan version is displayed.</description></item>
                /// <item><description>If the current plan is already the Enterprise Edition, this parameter is always empty.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>basic</para>
                /// </summary>
                [NameInMap("MinEffectPlan")]
                [Validation(Required=false)]
                public string MinEffectPlan { get; set; }

                /// <summary>
                /// <para>The quota value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>quotaValue1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The threshold type of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>value: Enumeration type. An enumeration quota has multiple enumeration thresholds. For each enumeration threshold, the response indicates whether it is available in the current plan version. If it is not available, the response indicates the minimum required plan version.</description></item>
            /// <item><description>bool: Boolean type. A boolean quota is abstracted into two enumeration thresholds: true and false. To check whether the quota is available in the current plan version and to find the minimum required plan version, you only need to focus on the quota details where the enumeration value is true.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("QuotaValueType")]
            [Validation(Required=false)]
            public string QuotaValueType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

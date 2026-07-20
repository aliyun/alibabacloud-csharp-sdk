// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListQuotasMinEffectPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of minimum effective plan editions for quotas.</para>
        /// </summary>
        [NameInMap("Quotas")]
        [Validation(Required=false)]
        public List<ListQuotasMinEffectPlanResponseBodyQuotas> Quotas { get; set; }
        public class ListQuotasMinEffectPlanResponseBodyQuotas : TeaModel {
            /// <summary>
            /// <para>The quota name. Valid values:</para>
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
            /// <item><description><b>waitingroom|wr_queueing_method</b>: waiting room - queuing method.</description></item>
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
            /// <item><description><b>waitingroom_event</b>: waiting room - scheduled event.</description></item>
            /// <item><description><b>waitingroom_rule</b>: waiting room - bypass waiting room.</description></item>
            /// <item><description><b>waitingroom|wr_json_response</b>: waiting room - enable JSON response.</description></item>
            /// <item><description><b>waitingroom|wr_disable_session_renewal</b>: waiting room - disable session renewal.</description></item>
            /// <item><description><b>origin_rules|dns_record</b>: back-to-origin rule - DNS record.</description></item>
            /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: whether the real client IP header is active in transform rules.</description></item>
            /// <item><description><b>tiered_cache|regional_enable</b>: area cache.</description></item>
            /// <item><description><b>real_client_ip_header</b>: client IP header.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf:phase:http_anti_scan:actions</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// <para>The list of quota threshold details.</para>
            /// </summary>
            [NameInMap("QuotaValueDetail")]
            [Validation(Required=false)]
            public List<ListQuotasMinEffectPlanResponseBodyQuotasQuotaValueDetail> QuotaValueDetail { get; set; }
            public class ListQuotasMinEffectPlanResponseBodyQuotasQuotaValueDetail : TeaModel {
                /// <summary>
                /// <para>Indicates whether the quota value is available in the plan edition associated with the current site. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Available.</description></item>
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
                /// <para>The minimum plan edition in which the quota value is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>basic: Basic Edition.</description></item>
                /// <item><description>medium: Standard Edition.</description></item>
                /// <item><description>high: Pro Edition.</description></item>
                /// <item><description>enterprise_standard_cn: Enterprise Edition.</description></item>
                /// </list>
                /// <para>This parameter follows these rules:</para>
                /// <list type="bullet">
                /// <item><description>If the quota value is already available in the current edition, this parameter is empty, meaning the minimum available plan edition is not displayed.</description></item>
                /// <item><description>If the quota value is not available in the current edition, the minimum available edition is displayed.</description></item>
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
            /// <item><description>value: enumeration type. An enumeration-type quota has multiple enumeration thresholds. For each enumeration threshold, the system indicates whether it is available in the current edition and, if not, the minimum plan edition in which it becomes available.</description></item>
            /// <item><description>bool: Boolean type. A Boolean-type quota is abstracted into two enumeration thresholds: true and false. To check whether the quota is available in the current plan edition and the minimum available plan edition, you only need to check the quota details for the true enumeration in the quota details list.</description></item>
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

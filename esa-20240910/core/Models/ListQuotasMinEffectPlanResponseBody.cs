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
            /// <para>The name of the quota. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waf:phase:http_anti_scan:actions</b>: WAF scan protection - action enumeration</description></item>
            /// <item><description><b>waf:phase:http_bot:actions</b>: WAF bot management - all action enumerations</description></item>
            /// <item><description><b>waf:phase:http_bot:http_custom_cc_dev:characteristic:fields</b>: WAF bot management - statistical object enumeration for custom device rate limiting</description></item>
            /// <item><description><b>waf:phase:http_bot:http_custom_cc_ip:characteristic:fields</b>: WAF bot management - statistical object enumeration for custom IP rate limiting</description></item>
            /// <item><description><b><b>waf:phase:http_bot:match:symbols</b></b>: WAF bot management - match symbol enumeration</description></item>
            /// <item><description><b>waf:phase:http_bot:http_custom_cc:characteristic:fields</b>: WAF bot management - statistical object enumeration for custom session rate limiting</description></item>
            /// <item><description><b>waf:phase:http_bot:match:fields</b>: WAF bot management phase - match field enumeration</description></item>
            /// <item><description><b>waf:phase:http_whitelist:match:symbols</b>: WAF whitelist - match symbol enumeration</description></item>
            /// <item><description><b>waf:phase:http_whitelist:match:fields</b>: WAF whitelist - match field enumeration</description></item>
            /// <item><description><b>waf:phase:http_anti_scan:http_directory_traversal:characteristic:fields</b>: WAF scan protection - statistical object enumeration for folder traverse blocking</description></item>
            /// <item><description><b>waf:phase:http_anti_scan:http_high_frequency:characteristic:fields</b>: WAF scan protection - statistical object enumeration for high-frequency scan blocking</description></item>
            /// <item><description><b>waf:phase:http_anti_scan:match:symbols</b>: WAF scan protection - match symbol enumeration</description></item>
            /// <item><description><b>waf:phase:http_anti_scan:match:fields</b>: WAF scan protection - match field enumeration</description></item>
            /// <item><description><b>waf:phase:http_managed:actions</b>: WAF managed rules - action enumeration</description></item>
            /// <item><description><b>waf:phase:http_managed:group:reference:ids</b>: WAF managed rules - referenced rule group enumeration</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:actions</b>: WAF rate limiting - action enumeration</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:ttls</b>: WAF rate limiting - duration enumeration</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:intervals</b>: WAF rate limiting - statistical duration</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:http_ratelimit:characteristic:fields</b>: WAF rate limiting - match characteristic enumeration for control type rules</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:match:symbols</b>: WAF rate limiting rule phase - match symbol enumeration</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:match:fields</b>: WAF rate limiting rule phase - match field enumeration</description></item>
            /// <item><description><b>waf:phase:http_custom:actions</b>: WAF custom rule phase - action enumeration</description></item>
            /// <item><description><b>waf:phase:http_custom:match:symbols</b>: WAF custom rule phase - match symbol enumeration</description></item>
            /// <item><description><b>waf:phase:http_custom:match:fields</b>: WAF custom rule phase - match fields</description></item>
            /// <item><description><b>waitingroom|wr_queueing_method</b>: Waiting room - queuing method</description></item>
            /// <item><description><b>origin_rules|origin_scheme</b>: Back-to-origin rules - back-to-origin protocol</description></item>
            /// <item><description><b>origin_rules|origin_sni</b>: Back-to-origin rules - back-to-origin SNI</description></item>
            /// <item><description><b>origin_rules|origin_host</b>: Back-to-origin rules - back-to-origin host</description></item>
            /// <item><description><b>fourlayeracceleration</b>: Layer 4 acceleration</description></item>
            /// <item><description><b>rtlog_service</b>: Real-time log feature switch</description></item>
            /// <item><description><b>dashboard_traffic</b>: Value-added capability for network traffic analysis</description></item>
            /// <item><description><b>custom_name_server</b>: Custom NS name</description></item>
            /// <item><description><b>waf:phase:http_bot:enable</b>: WAF bot management switch</description></item>
            /// <item><description><b>waf:phase:http_whitelist:enable</b>: WAF whitelist switch</description></item>
            /// <item><description><b>instantlog</b>: Whether instant logs are active</description></item>
            /// <item><description><b>waf:phase:http_anti_scan:enable</b>: WAF scan protection switch</description></item>
            /// <item><description><b>waf:phase:http_managed:group:reference:enable</b>: WAF managed rules - configure referenced rule group switch</description></item>
            /// <item><description><b>waf:phase:http_managed:enable</b>: WAF managed rules switch</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:on_hit:enable</b>: WAF rate limiting - apply to cached requests switch</description></item>
            /// <item><description><b>ddos</b>: DDoS instance</description></item>
            /// <item><description><b>waf:phase:http_ratelimit:enable</b>: WAF rate limiting rule phase switch</description></item>
            /// <item><description><b>waf:phase:http_custom:enable</b>: WAF custom rule phase switch</description></item>
            /// <item><description><b>waf:phase:all:page:reference:enable</b>: WAF custom response page switch</description></item>
            /// <item><description><b>rules_support_regex</b>: Whether the rule DPI engine supports regular expression operations</description></item>
            /// <item><description><b>waitingroom_event</b>: Waiting room - scheduled events</description></item>
            /// <item><description><b>waitingroom_rule</b>: Waiting room - bypass waiting room</description></item>
            /// <item><description><b>waitingroom|wr_json_response</b>: Waiting room - enable JSON response</description></item>
            /// <item><description><b>waitingroom|wr_disable_session_renewal</b>: Waiting room - disable session renewal</description></item>
            /// <item><description><b>origin_rules|dns_record</b>: Back-to-origin rules - DNS record</description></item>
            /// <item><description><b>managed_transforms|add_client_geolocation_headers</b>: Whether the real client IP header is active in transformation rules</description></item>
            /// <item><description><b>tiered_cache|regional_enable</b>: Area cache</description></item>
            /// <item><description><b>real_client_ip_header</b>: Client IP header</description></item>
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
                /// <item><description>false: Unavailable.</description></item>
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
                /// <item><description>enterprise_standard_cn: Enterprise Edition.
                /// The return value of this parameter follows these rules:</description></item>
                /// <item><description>If the quota value is already available in the current plan version, this parameter is left empty, meaning the minimum required plan version is not displayed.</description></item>
                /// <item><description>If the quota value is unavailable in the current plan version, the minimum required plan version is displayed.</description></item>
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
            /// <item><description>value: enumeration type. A quota of the enumeration type has multiple enumeration thresholds. For each enumeration threshold, the response indicates whether it is available in the current plan version. If it is unavailable, the response indicates the minimum required plan version.</description></item>
            /// <item><description>bool: Boolean type. A quota of the Boolean type is abstracted into two enumeration thresholds: true and false. To check whether the quota is available in the current plan version and identify the minimum required plan version, you only need to focus on the quota details where the enumeration value is true.</description></item>
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

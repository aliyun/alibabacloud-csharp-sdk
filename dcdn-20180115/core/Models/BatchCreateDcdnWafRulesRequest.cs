// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchCreateDcdnWafRulesRequest : TeaModel {
        /// <summary>
        /// The configurations of the protection rule.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// ## Description of the RuleConfigs parameter
        /// 
        /// - RuleConfigs is a list slice, in which each struct represents a rule.
        /// - The fields in the RuleConfigs parameter vary based on the type of the protection policy whose ID is specified by the PolicyId parameter.
        /// 
        /// 
        /// ## Scenario 1:web RegEx protection (waf_group)
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | status | String | No | on | Specifies whether to enable the protection rule. Valid values: on and off. Default value: on. |
        /// | action | String | Yes | block | Specifies the action of the rule. Valid values: block and monitor. |
        /// Sample code for waf_group
        /// 
        /// ```
        /// // You can configure only one rule for a protection policy of the waf_group type. 
        /// [
        ///   {
        ///     "status": "on",
        ///     "action": "block"
        ///   }
        /// ]
        /// ```
        /// 
        /// ## Scenario 2: custom rules (custom_acl)
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | name | string | Yes | acl_1 | The name of the protection rule. The name can be up to 64 characters in length and can contain letters, digits, and underscores (_). |
        /// | status | string | No | on | Valid values: on and off. Default value: on. |
        /// | conditions | Condition | Yes | [ {"key": "URI", "subKey": "","opValue": "contain",  "values": "/login.php" }] | The trigger condition. For more information, see **Table 1 Fields in the Conditions parameter**. |
        /// | ccStatus | string | Yes | off | Specifies whether to enable rate limiting. Valid values: on and off. |
        /// | rateLimit | RateLimit | No | { "target": "Header", "subKey": "User-Agent", "interval": 5, "threshold": 2, "ttl": 1800} | The rules of rate limiting. If you set ccStatus to on, you must configure this parameter. For more information, see **Table 2 Fields in the rateLimit parameter**. |
        /// | effect | string | No | service | The effective scope of the rate limiting blacklist. If you set ccStatus to on, you must configure this parameter. Valid values: rule (takes effect for the current rule) and service (takes effect globally). |
        /// | action | string | Yes | deny | The action of the rule. Valid values: deny, js (JavaScript verification), and monitor. |
        /// Table 1 Fields in the Conditions parameter
        /// 
        /// | Field | Type | Required | Example | Description |
        /// | ----- | ---- | -------- | ------- | ----------- |
        /// | Key | string | Yes | Query String Parameter | The match field. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | subKey | string | No | action | The match subfield. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | opValue | String | Yes | eq | The logical symbol. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | values | String | No | js | The match content. Separate multiple values with commas (,). For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// Table 2 Fields in the rateLimit parameter
        /// 
        /// | Field | Type | Required | Example | Description |
        /// | ----- | ---- | -------- | ------- | ----------- |
        /// | target | string | Yes | Header | The statistical field of rate limiting. IP: calculates the frequency at which requests are sent from a specified IP address. Header: calculates the frequency of requests that contain the specified header. Query String Parameter: calculates the frequency of requests that contain the specified parameter. Cookie Name: calculates the frequency of requests that contain the specified cookie. Session: calculates the frequency of requests that are transmitted over a specified session. |
        /// | subKey | string | No | User-Agent | The subfield of the target field. If you set target to Header, Query String Parameter, or Cookie Name, you must configure subKey. |
        /// | Interval | Integer | Yes | 5 | The statistical interval. Valid values: 5 to 1800. Unit: seconds. |
        /// | threshold | Integer | Yes | 2 | The trigger threshold of rate limiting. Valid values: 2 to 500000. Unit: requests. |
        /// | ttl | Integer | Yes | 1800 | The validity period of the blacklist. Valid values: 60 to 86400. Unit: seconds. |
        /// | status | RateLimitStatus | No | {"code": "404", "ratio": 10} | The information about the HTTP status code. For more information, see **Table 3 Fields in the RateLimitStatus parameter**. |
        /// Table 3 Fields in the RateLimitStatus parameter
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | codet | string | Yes | 404 | The HTTP status code returned. |
        /// | ratio | Integer | No | 10 | The percentage of HTTP status codes. Valid values: 1 to 100. You can configure only one of the ratio and count fields. |
        /// | count | Integer | No | 10 | The number of times that the HTTP status code that was returned. Valid values: 2 to 50000. You can configure only one of the ratio and count fields. |
        /// Sample code for custom_acl
        /// 
        /// ```
        /// [
        ///   // Access control
        ///   {
        ///     "name": "acl_1",
        ///     "status": "off",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Query String Parameter",
        ///         "subKey": "action",
        ///         "opValue": "eq",
        ///         "values": "js"
        ///       }
        ///     ],
        ///     "ccStatus": "off",
        ///     "action": "js"
        ///   },
        ///   // Rate limiting
        ///   {
        ///     "name": "cc_1",
        ///     "status": "on",
        ///   	"conditions": 
        ///     [
        ///       {
        ///         "key": "URI",
        ///         "subKey": "",
        ///         "opValue": "contain",
        ///         "values": "/login.php"
        ///       },
        ///       {
        ///         "key": "IP",
        ///         "subKey": "",
        ///         "opValue": "ip-contain",
        ///         "values": "192.168.0.1/24"
        ///       }
        ///     ],
        ///     "ccStatus": "on",
        ///     "ratelimit":
        ///     {
        ///       "target": "Header",
        ///       "subKey": "User-Agent",
        ///       "interval": 5,
        ///       "threshold": 2,
        ///       "ttl": 1800,
        ///       "status":
        ///       {
        ///         "code": "404",
        ///         "ratio": 10
        ///       }
        ///     },
        ///     "effect": "service",
        ///     "action": "deny"
        ///   }
        /// ]
        /// ```
        /// 
        /// ## Scenario 3: whitelist (whitelist)
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | name | string | Yes | on | The name of the protection rule. The name can be up to 64 characters in length and can contain letters, digits, and underscores (_). |
        /// | status | string | No | on | Specifies whether to enable the protection rule. Default value: on. Valid values: on and off. off: disables the multiplexing feature for ports. |
        /// | conditions | Condition | Yes | [{ "key": "Http-Method","subKey": "","opValue": "match-one", "values": "GET,POST,DELETE" }] | The trigger condition of the rule. For more information, see **Table 1 Fields in the Conditions parameter**. |
        /// | tags | String | Yes | [ "waf_group",  "custom_acl"] | The types of the protection policies. |
        /// | regularTypes | String | No | [  [ "sqli", "xss","code_exec", "crlf", "lfilei",  "rfilei", "webshell","vvip", "other"] | The type of the regular expression. If the value of the tags field contains waf_group, you can specify this field. Valid values: ["sqli", "xss", "code_exec", "crlf", "lfilei", "rfilei", "webshell", "vvip", and "other"]. |
        /// | regularRules | String | No | [   "100001", "100002", "100003"] | The regular expression. If the value of the tags field contains waf_group, you can specify this field. You can configure only regularRules or regularTypes. The value must be a string that consists of six digits. |
        /// Sample code for whitelist:
        /// 
        /// ```
        /// [
        ///   // Skip all protection policies.
        ///   {
        ///     "name": "wl_all",
        ///     "status": "on",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Http-Method",
        ///         "subKey": "",
        ///         "opValue": "match-one",
        ///         "values": "GET,POST,DELETE"
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "waf_group",
        ///       "custom_acl",
        ///       "ip_blacklist",
        ///       "region_block"
        ///     ]
        ///   },
        ///   // Skip the ID of the rule that is specified in waf_group.
        ///   {
        ///     "name": "wl_waf_id",
        ///     "status": "off",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Cookie Name",
        ///         "subKey": "cdn-sec",
        ///         "opValue": "prefix-match",
        ///         "values": "a7sdsa9dsa8d8sa"
        ///       },
        ///       {
        ///         "key": "Referer",
        ///         "subKey": "",
        ///         "opValue": "none",
        ///         "values": ""
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "waf_group"
        ///     ],
        ///     "regularRules":
        ///     [
        ///       "100001",
        ///       "100002",
        ///       "100003"
        ///     ]
        ///   },
        ///   {
        ///   // Skip the type of rules that is specified in waf_group.
        ///     "name": "wl_waf_type",
        ///     "status": "on",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Query String",
        ///         "subKey": "",
        ///         "opValue": "exists",
        ///         "values": ""
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "waf_group"
        ///     ],
        ///     "regularTypes":
        ///     [
        ///       "sqli",
        ///       "xss",
        ///       "code_exec",
        ///       "crlf",
        ///       "lfilei",
        ///       "rfilei",
        ///       "webshell",
        ///       "vvip",
        ///       "other"
        ///     ]
        ///   },
        ///   // Skip custom rules.
        ///   {
        ///     "name": "wl_custom_acl",
        ///     "status": "on",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Http-Method",
        ///         "subKey": "",
        ///         "opValue": "match-one",
        ///         "values": "GET,POST,DELETE"
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "custom_acl"
        ///     ]
        ///   },
        ///   // Skip IP addresses in the blacklist.
        ///   {
        ///     "name": "wl_ip_blacklist",
        ///     "status": "on",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Http-Method",
        ///         "subKey": "",
        ///         "opValue": "match-one",
        ///         "values": "GET,POST,DELETE"
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "ip_blacklist"
        ///     ]
        ///   },
        ///   // Skip the region blocking
        ///   {
        ///     "name": "wl_region_block",
        ///     "status": "on",
        ///     "conditions":
        ///     [
        ///       {
        ///         "key": "Http-Method",
        ///         "subKey": "",
        ///         "opValue": "match-one",
        ///         "values": "GET,POST,DELETE"
        ///       }
        ///     ],
        ///     "tags":
        ///     [
        ///       "region_block"
        ///     ]
        ///   }
        /// ]
        /// ```
        /// 
        /// ## Scenario 4:IP address blacklist (ip_blacklist)
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | name | string | Yes | ipblacklist | The name of the protection rule. The name can be up to 64 characters in length and can contain letters, digits, and underscores (_). |
        /// | status | string | No | on | Specifies whether to enable the protection rule. Valid values: on and off. Default value: on. |
        /// | remoteAddr | []String | Yes | ["192.168.0.1","10.10.10.10/24","::1","abcd::abcd","BCDE::BCDE"] | Filter by IP address. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | action | string | Yes | deny | The action of the rule. Valid values: deny and monitor. |
        /// Sample code for ipblacklist:
        /// 
        /// ```
        /// [
        ///     {
        ///     "name": "ipblacklist",
        ///     "status": "on",
        ///     "remoteAddr": ["192.168.0.1","10.10.10.10/24","::1","abcd::abcd","BCDE::BCDE"],
        ///     "action": "deny"
        ///   }
        /// ]
        /// ```
        /// 
        /// ## Protection scenario 5: region blocking (region_block)
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | status | string | No | on | Specifies whether to enable the protection rule. Valid values: on and off. Default value: on. |
        /// | cnRegionList | string | No | 110000,TW,MO | The blocked regions in the Chinese mainland, separated by commas (,). For more information about the regions that can be blocked, see [DescribeDcdnWafGeoInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/describe-dcdn-waf-geo-info). |
        /// | otherRegionList | string | No | JP,GB | Blocked regions outside the Chinese mainland, separated by commas (,). For more information about the regions that can be blocked, see [DescribeDcdnWafGeoInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/describe-dcdn-waf-geo-info). |
        /// | action | string | Yes | deny | The action of the rule. Valid values: deny and monitor. |
        /// >  You must specify at least one of the ProcessId or ProcessName parameters.  Sample code for region_block:
        /// 
        /// ```
        /// [
        ///     {
        ///     "status": "on",
        ///     "cnRegionList": "110000,TW,MO",
        ///     "otherRegionList": "JP,GB",
        ///     "action": "deny"
        ///   }
        /// ]
        /// ```
        /// 
        /// ## Scenario 6: Bot management (bot)
        /// 
        /// **Rule template**All rules have the four parameters in the following table. For more information, see the rule classification.  
        /// 
        /// | Parameter | Type | Required | Description |
        /// | --------- | ---- | -------- | ----------- |
        /// | type | String | Yes | The type of the rule. For more information, see the rule classification. |
        /// | status | String | Yes | The status of the rule. Valid values: on and off. |
        /// | config | TargetType | No | Rule configuration. For more information, see Rule classification. |
        /// | action | String | No | Rule actions. For more information, see Rule classification. |
        /// **Rule category 1: protection target type**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | target_type | The type of the rule. Set the value to target_type. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | TargetType | No | {"target":"app"} | The configuration of the rule. Format:
        /// 
        /// (Required) target: the type of the protection target. Valid values: web (web pages and browsers) and app (apps). |
        /// | action | String | No | Empty | The action of the rule, which is not involved here. Leave the value empty. |
        /// Configuration example of the protection target type:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"target_type",
        ///     "status":"on",
        ///     "config":{"target":"app"},
        ///     "action":""
        ///   }
        /// ]
        /// ```
        /// **Rule classification 2: Web SDK integration**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | web_sdk | The type of the rule. Set the value to web_sdk. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | WebSdk | No | {"mode":"automatic","crossDomain":"example.com"} | The configuration of the rule. Format:
        /// 
        /// (Required) mode : the integration mode of the Web SDK. Valid values: automatic and manual.  
        /// 
        /// (Optional) crossDomain: cross-domain resource calling. This parameter takes effect only when the value of mode is automatic. |
        /// | action | String | No | Empty | The action of the rule, which is not involved here. Leave the value empty. |
        /// Configuration example of Web SDK integration:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"web_sdk",
        ///     "status":"on",
        ///     "config":{"mode":"automatic","crossDomain":"example.com"},
        ///     "action":""
        ///   }
        /// ]
        /// ```
        /// **Rule classification 3: protection target characteristics**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | traffic_feature | The type of the rule. Set the value to traffic_feature. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | TrafficFeature | Yes | {"conditions":[{"key":"Header","subKey":"User-Agent","opValue":"contain","values":"Chrome"},{"key":"IP","subKey":"","opValue":"ip-contain","values":"192.168.0.1/24"}]} | The configuration of the rule. For more information, see **condition**. |
        /// | action | String | No | Empty | The action of the rule, which is not involved here. Leave the value empty. |
        /// **condition** (match condition) 
        /// 
        /// | Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | key | String | Yes | Header | The match field. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | subKey | String | No | User-Agent | The match subfield. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | opValue | String | Yes | contain | The operator. For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// | values | String | No | Chrome | The match content. Separate multiple values with commas (,). For more information, see [DescribeDcdnWafFilterInfo](https://www.alibabacloud.com/help/en/dynamic-route-for-cdn/latest/obtain-the-matching-conditions-of-custom-protection-rules). |
        /// Configuration example of protection target characteristics:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"traffic_feature",
        ///     "status":"on",
        ///     "config":{"conditions":[{"key":"Header","subKey":"User-Agent","opValue":"contain","values":"Chrome"},{"key":"IP","subKey":"","opValue":"ip-contain","values":"192.168.0.1/24"}]},
        ///     "action":""
        ///   }
        /// ]
        /// ```
        /// **Rule classification 4: legitimate Bot management**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | intelligence_crawler | The type of the rule. Set the value to intelligence_crawler. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | IntelligenceCrawler | No | {"name":"intelligence_crawler_baidu"} | The configuration of the rule. For more information, see **name (spider whitelist)**. |
        /// | action | String | Yes | bypass | The action of the rule. Set the value to bypass. |
        /// **name (spider whitelist)**| Value | Description |
        /// | ----- | ----------- |
        /// | intelligence_crawler_all | Whitelist for authorized search engines, such as Google, Bing, Baidu, Sogou, 360, and Yandex. |
        /// | intelligence_crawler_baidu | Baidu spider whitelist |
        /// | intelligence_crawler_sogou | Sogou spider whitelist |
        /// | intelligence_crawler_360 | 360 spider whitelist |
        /// | intelligence_crawler_google | Google spider whitelist |
        /// | intelligence_crawler_bing | Bing spider whitelist |
        /// | intelligence_crawler_yandex | Yandex spider whitelist |
        /// Configuration example of legitimate Bot management:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"intelligence_crawler",
        ///     "status":"on",
        ///     "config":{"name":"intelligence_crawler_baidu"},
        ///     "action":"bypass"
        ///   },
        ///   {
        ///     "type":"intelligence_crawler",
        ///     "status":"on",
        ///     "config":{"name":"intelligence_crawler_google"},
        ///     "action":"bypass"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 5: script-based Bot block (JavaScript)**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | js | The type of the rule. Set the value to js. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | Js | No | Empty | The configuration of the rule, which is not involved here. Leave the value empty. |
        /// | action | String | Yes | js | The action of the rule. Set the value to js (JavaScript verification). |
        /// Configuration example of script-based Bot block (JavaScript)
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"js",
        ///     "status":"on",
        ///     "config":{},
        ///     "action":"js"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 6: advanced Bot defense (dynamic token-based authentication)**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | sigchl | The type of the rule. Set the value to sigchl. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | Sigchl | No | {"sigchl":["sig","replay","driver"]} | The configuration of the rule. Format:
        /// 
        /// (Required) sigchl : signature-based verification for request data. Valid values: sig (signature verification exception),replay (signature timestamp exception), and driver(WebDriver attack). |
        /// | action | String | Yes | sigchl | The action of the rule. Set the value to sigchl (block). |
        /// Configuration example of advanced Bot defense (dynamic token-based authentication):
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"sigchl",
        ///     "status":"on",
        ///     "config":{"sigchl":["sig","replay","driver"]},
        ///     "action":"sigchl"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 7: intelligent protection**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | algorithm | The type of the rule. Set the value to algorithm. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | Algorithm | No | Empty | The configuration of the rule, which is not involved here. Leave the value empty. |
        /// | action | String | Yes | captcha | The action of the rule. Valid values: monitor and captcha. |
        /// Configuration example of intelligent protection:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"algorithm",
        ///     "status":"on",
        ///     "config":{},
        ///     "action":"captcha"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 8: IP address throttling**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | custom_cc_ip | The type of the rule. Set the value to custom_cc_ip. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | CustomCcIp | Yes | {"interval":20,"target":"IP","threshold":50,"ttl":2800} | The configuration of the rule. For more information, see **Fields in the config parameter of IP address throttling**. |
        /// | action | String | Yes | monitor | The action of the rule. Valid values: deny, monitor, and captcha (only for web). |
        /// **Fields in the config parameter of IP address throttling**| Field | Type | Required | Example | Description |
        /// | ----- | ---- | -------- | ------- | ----------- |
        /// | target | String | Yes | IP | The statistical field of rate limiting. Set the value to IP. |
        /// | subKey | String | No | Empty | The subfield of the target field, which is not involved here. Leave the value empty. |
        /// | Interval | Integer | Yes | 20 | The statistical interval. Valid values: 5 to 1800. Unit: seconds. |
        /// | threshold | Integer | Yes | 50 | The trigger threshold of rate limiting. Valid values: 2 to 50000. Unit: calls. |
        /// | ttl | Integer | Yes | 2800 | The validity period of the blacklist. Valid values: 60 to 86400. Unit: seconds. |
        /// Configuration example of IP address throttling
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"custom_cc_ip",
        ///     "status":"on",
        ///     "config":{"interval":20,"target":"IP","threshold":50,"ttl":2800},
        ///     "action":"monitor"
        ///   },
        ///   {
        ///     "type":"custom_cc_ip",
        ///     "status":"on",
        ///     "config":{"interval":10,"target":"IP","threshold":30,"ttl":1800},
        ///     "action":"monitor"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 9: device throttling**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | custom_cc_dev | The type of the rule. Set the value to custom_cc_dev. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | CustomCcDev | Yes | {"interval":20,"target":"Header","subKey":"aliwaf_wxbb_umid","threshold":50,"ttl":2800} | The configuration of the rule. For more information, see **Fields in the config parameter of device throttling**. |
        /// | action | String | Yes | monitor | The action of the rule. Valid values: deny and monitor. |
        /// **Fields in the config parameter of device throttling**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | target | String | Yes | Header | The statistical field of rate limiting. Set the value to Header. |
        /// | subKey | String | No | aliwaf_wxbb_umid | The subfield of the target field. Set the value to aliwaf_wxbb_umid. |
        /// | Interval | Integer | Yes | 20 | The statistical interval. Valid values: 5 to 1800. Unit: seconds. |
        /// | threshold | Integer | Yes | 50 | The trigger threshold of rate limiting. Valid values: 2 to 50000. Unit: calls. |
        /// | ttl | Integer | Yes | 2800 | The validity period of the blacklist. Valid values: 60 to 86400. Unit: seconds. |
        /// Configuration example of device throttling
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"custom_cc_dev",
        ///     "status":"on",
        ///     "config":{"interval":20,"target":"Header","subKey":"aliwaf_wxbb_umid","threshold":50,"ttl":2800},
        ///     "action":"monitor"
        ///   },
        ///   {
        ///     "type":"custom_cc_dev",
        ///     "status":"on",
        ///     "config":{"interval":20,"target":"Header","subKey":"aliwaf_wxbb_umid","threshold":50,"ttl":2800},
        ///     "action":"deny"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 10: custom session-based throttling**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | custom_cc | The type of the rule. Set the value to custom_cc. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | CustomCcIp | Yes | {"interval":10,"target":"Query String Parameter","subKey":"arg","threshold":30,"ttl":1800} | The configuration of the rule. For more information, see **Fields in the config parameter of custom session-based throttling**. |
        /// | action | String | Yes | monitor | The action of the rule. Valid values: deny, monitor, and captcha (only for web). |
        /// **Fields in the config parameter of custom session-based throttling**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | target | String | Yes | Query String Parameter | The statistical fields for frequency control. Valid values: Header, calculates the frequency of requests that contain the specified header; Query String Parameter, calculates the frequency of requests that contain the specified parameter; Cookie Name, calculates the frequency of requests that contain the specified cookie; and Session, calculates the frequency of requests that are transmitted over a specified session. |
        /// | subKey | String | No | arg | The subfield of the target field. You can customize the value. |
        /// | Interval | Integer | Yes | 10 | The statistical interval. Valid values: 5 to 1800. Unit: seconds. |
        /// | threshold | Integer | Yes | 30 | The trigger threshold of rate limiting. Valid values: 2 to 50000. Unit: calls. |
        /// | ttl | Integer | Yes | 2800 | The validity period of the blacklist. Valid values: 60 to 86400. Unit: seconds. |
        /// Configuration example of custom session-based throttling
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"custom_cc",
        ///     "status":"on",
        ///     "config":{"interval":10,"target":"Query String Parameter","subKey":"arg","threshold":30,"ttl":1800},
        ///     "action":"deny"
        ///   },
        ///   {
        ///     "type":"custom_cc",
        ///     "status":"on",
        ///     "config":{"interval":10,"target":"Query String Parameter","subKey":"arg","threshold":30,"ttl":1800},
        ///     "action":"captcha"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 11: Bot threat intelligence library**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | intelligence | The type of the rule. Set the value to intelligence. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | Intelligence | No | Empty | The configuration of the rule, which is not involved here. Leave the value empty. |
        /// | action | String | Yes | captcha | The action of the rule. Valid values: monitor and captcha. |
        /// Configuration example of bot threat intelligence library:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"intelligence",
        ///     "status":"on",
        ///     "config":{},
        ///     "action":"captcha"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 12: data center blacklist**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | intelligence_idc | The type of the rule. Set the value to intelligence_idc. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | IntelligenceIdc | Yes | {"name":"intelligence_idc_alibaba"} | The configuration of the rule. For more information, see **Values of name**. |
        /// | action | String | Yes | captcha | The action of the rule. Valid values: deny, monitor, and captcha. |
        /// **Values of name**| Value | Description |
        /// | ----- | ----------- |
        /// | intelligence_idc_alibaba | Data center IP address library-Alibaba Cloud |
        /// | intelligence_idc_tencent | Data center IP address library-Tencent Cloud |
        /// | intelligence_idc_mtyun | Data center IP address library-Meituan Open Services |
        /// | intelligence_idc_vnet | Data center IP address library-21Vianet |
        /// | intelligence_idc_other | Data center IP address library-Others |
        /// Configuration example of data center blacklist
        /// 
        /// ```
        /// [
        ///   {
        ///     "type":"intelligence_idc",
        ///     "status":"on",
        ///     "config":{"name":"intelligence_idc_alibaba"},
        ///     "action":"captcha"
        ///   },
        ///   {
        ///     "type":"intelligence_idc",
        ///     "status":"on",
        ///     "config":{"name":"intelligence_idc_tencent"},
        ///     "action":"captcha"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 13: fake spider blocking**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | intelligence_fake_crawler | The type of the rule. Set the value to intelligence_fake_crawler. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Valid values: on and off. |
        /// | config | IntelligenceFakeCrawler | No | Empty | The configuration of the rule, which is not involved here. Leave the value empty. |
        /// | action | String | Yes | deny | The action of the rule. Set the value to deny. |
        /// Configuration example of fake spider blocking:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type": "intelligence_fake_crawler",
        ///     "status": "on",
        ///     "config":{},
        ///     "action": "deny"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 14: Bot characteristic detection**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | app_sdk | The type of the rule. Set the value to app_sdk. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | AppSdk | Yes | {"featureAbnormal":["simulator","proxy","root","debugged","hook","virtual","antiReplay","signInvalid"],"customSignStatus":"on","customSign":{"key":"header","value":"ua"}} | The configuration of the rule. For more information, see **Fields in the config parameter of Bot characteristic detection**. |
        /// | action | String | Yes | monitor | The action of the rule. Valid values: deny and monitor. |
        /// **Fields in the config parameter of Bot characteristic detection**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | featureAbnormal | []String | Yes | simulator | signInvalid: The app signature is invalid. 
        /// 
        /// antiReplay: The signature expired. 
        /// 
        /// simulator: Uses a simulator.
        /// 
        /// proxy: Uses a proxy.
        /// 
        /// root: Root device.
        /// 
        /// debugged: The debugging mode. 
        /// 
        /// hook: The app is hooked. 
        /// 
        /// virtual : Multiboxing. |
        /// | customSignStatus | String | No | on | Specifies whether to enable the custom signature field. Valid values: on and off. |
        /// | customSign | CustomSign | No | {"key":"header","value":"ua"} | The custom signature field. Format:  
        /// 
        ///   (Required) key : the name of the field. Valid values: header, arg, and cookie.  
        /// 
        ///  (Required) value: the value of the field. |
        /// Configuration example of Bot characteristic detection:
        /// 
        /// ```
        /// [
        ///   {
        ///     "type": "app_sdk",
        ///     "status": "on",
        ///     "config": {"featureAbnormal":["simulator","proxy","root","debugged","hook","virtual","antiReplay","signInvalid"],"customSignStatus":"on","customSign":{"key":"header","value":"ua"}},
        ///     "action": "monitor"
        ///   }
        /// ]
        /// ```
        /// **Rule classification 15: advanced protection (secondary packaging detection)**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | type | String | Yes | app_package | The type of the rule. Set the value to app_package. |
        /// | status | String | Yes | on | Specifies whether to enable the rule. Set the value to on. |
        /// | config | AppPackage | No | {"packageSigns":[{"name":"aaaaa","sign":"bbbb"},{"name":"cccc","sign":"dddd"}]} | The configuration of the rule. For more information, see **Fields in the packageSigns parameter**. |
        /// | action | String | Yes | monitor | The action of the rule. Valid values: deny and monitor. |
        /// **Fields in the packageSigns parameter**| Parameter | Type | Required | Example | Description |
        /// | --------- | ---- | -------- | ------- | ----------- |
        /// | name | String | Yes | aaaaa | The valid package name. |
        /// | sign | String | No | bbbb | The signature of the package. |
        /// Configuration examples of advanced protection (secondary packaging detection):
        /// 
        /// ```
        /// [
        ///   {
        ///     "type": "app_package",
        ///     "status": "on",
        ///     "config": {"packageSigns":[{"name":"aaaaa","sign":"bbbb"},{"name":"cccc","sign":"dddd"}]},
        ///     "action": "deny"
        ///   }
        /// ]
        /// ```
        /// **Configuration example of Bot management and web page/browser protection**```
        /// [
        ///     {
        ///         "type": "target_type",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "target": "web"
        ///         },
        ///         "action": ""
        ///     },
        ///     {
        ///         "type": "web_sdk",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "mode": "automatic",
        ///             "crossDomain": "example.com"
        ///         },
        ///         "action": ""
        ///     },
        ///     {
        ///         "type": "traffic_feature",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "conditions":
        ///             [
        ///                 {
        ///                     "key": "Header",
        ///                     "subKey": "User-Agent",
        ///                     "opValue": "contain",
        ///                     "values": "Chrome"
        ///                 },
        ///                 {
        ///                     "key": "IP",
        ///                     "subKey": "",
        ///                     "opValue": "ip-contain",
        ///                     "values": "192.168.0.1/24"
        ///                 }
        ///             ]
        ///         },
        ///         "action": ""
        ///     },
        ///     {
        ///         "type": "intelligence_crawler",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "name": "intelligence_crawler_baidu"
        ///         },
        ///         "action": "bypass"
        ///     },
        ///     {
        ///         "type": "intelligence_crawler",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "name": "intelligence_crawler_google"
        ///         },
        ///         "action": "bypass"
        ///     },
        ///     {
        ///         "type": "js",
        ///         "status": "on",
        ///         "config":
        ///         {},
        ///         "action": "js"
        ///     },
        ///     {
        ///         "type": "sigchl",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "sigchl":
        ///             [
        ///                 "sig",
        ///                 "replay",
        ///                 "driver"
        ///             ]
        ///         },
        ///         "action": "sigchl"
        ///     },
        ///     {
        ///         "type": "algorithm",
        ///         "status": "on",
        ///         "config":
        ///         {},
        ///         "action": "captcha"
        ///     },
        ///     {
        ///         "type": "custom_cc_ip",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 20,
        ///             "target": "IP",
        ///             "threshold": 50,
        ///             "ttl": 2800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc_ip",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "IP",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "Query String Parameter",
        ///             "subKey": "arg",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "deny"
        ///     },
        ///     {
        ///         "type": "custom_cc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "Query String Parameter",
        ///             "subKey": "arg",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "captcha"
        ///     },
        ///     {
        ///         "type": "intelligence",
        ///         "status": "on",
        ///         "config":
        ///         {},
        ///         "action": "captcha"
        ///     },
        ///     {
        ///         "type": "intelligence_idc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "name": "intelligence_idc_alibaba"
        ///         },
        ///         "action": "captcha"
        ///     },
        ///     {
        ///         "type": "intelligence_idc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "name": "intelligence_idc_tencent"
        ///         },
        ///         "action": "captcha"
        ///     },
        ///     {
        ///         "type": "intelligence_fake_crawler",
        ///         "status": "on",
        ///         "config":
        ///         {},
        ///         "action": "deny"
        ///     }
        /// ]
        /// ```
        /// **Configuration example of Bot management and app protection**```
        /// json
        /// [
        ///     {
        ///         "type": "target_type",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "target": "app"
        ///         },
        ///         "action": ""
        ///     },
        ///     {
        ///         "type": "traffic_feature",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "conditions":
        ///             [
        ///                 {
        ///                     "key": "Header",
        ///                     "subKey": "User-Agent",
        ///                     "opValue": "contain",
        ///                     "values": "Chrome"
        ///                 },
        ///                 {
        ///                     "key": "IP",
        ///                     "subKey": "",
        ///                     "opValue": "ip-contain",
        ///                     "values": "192.168.0.1/24"
        ///                 }
        ///             ]
        ///         },
        ///         "action": ""
        ///     },
        ///     {
        ///         "type": "custom_cc_ip",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 20,
        ///             "target": "IP",
        ///             "threshold": 50,
        ///             "ttl": 2800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc_ip",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "IP",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc_dev",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 20,
        ///             "target": "Header",
        ///             "subKey": "aliwaf_wxbb_umid",
        ///             "threshold": 50,
        ///             "ttl": 2800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc_dev",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 20,
        ///             "target": "Header",
        ///             "subKey": "aliwaf_wxbb_umid",
        ///             "threshold": 50,
        ///             "ttl": 2800
        ///         },
        ///         "action": "deny"
        ///     },
        ///     {
        ///         "type": "custom_cc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "Query String Parameter",
        ///             "subKey": "arg",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "custom_cc",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "interval": 10,
        ///             "target": "Query String Parameter",
        ///             "subKey": "arg",
        ///             "threshold": 30,
        ///             "ttl": 1800
        ///         },
        ///         "action": "deny"
        ///     },
        ///     {
        ///         "type": "app_sdk",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "featureAbnormal":
        ///             [
        ///                 "simulator",
        ///                 "proxy",
        ///                 "root",
        ///                 "debugged",
        ///                 "hook",
        ///                 "virtual",
        ///                 "antiReplay",
        ///                 "signInvalid"
        ///             ],
        ///             "customSignStatus": "on",
        ///             "customSign":
        ///             {
        ///                 "key": "header",
        ///                 "value": "ua"
        ///             }
        ///         },
        ///         "action": "monitor"
        ///     },
        ///     {
        ///         "type": "app_package",
        ///         "status": "on",
        ///         "config":
        ///         {
        ///             "packageSigns":
        ///             [
        ///                 {
        ///                     "name": "aaaaa",
        ///                     "sign": "bbbb"
        ///                 },
        ///                 {
        ///                     "name": "cccc",
        ///                     "sign": "dddd"
        ///                 }
        ///             ]
        ///         },
        ///         "action": "deny"
        ///     }
        /// ]
        /// ```
        /// </summary>
        [NameInMap("RuleConfigs")]
        [Validation(Required=false)]
        public string RuleConfigs { get; set; }

    }

}

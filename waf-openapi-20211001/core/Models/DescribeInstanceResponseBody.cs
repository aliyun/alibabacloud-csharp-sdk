// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// The details of the WAF instance.
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyDetails Details { get; set; }
        public class DescribeInstanceResponseBodyDetails : TeaModel {
            /// <summary>
            /// The maximum number of IP addresses that can be added to the match content of a match condition. For more information, see [Match conditions](~~374354~~).
            /// </summary>
            [NameInMap("AclRuleMaxIpCount")]
            [Validation(Required=false)]
            public long? AclRuleMaxIpCount { get; set; }

            /// <summary>
            /// Indicates whether the scan protection module is supported. Valid values:
            /// 
            /// *   **true:** The scan protection module is supported.
            /// *   **false:** The scan protection module is not supported.
            /// </summary>
            [NameInMap("AntiScan")]
            [Validation(Required=false)]
            public bool? AntiScan { get; set; }

            /// <summary>
            /// The maximum number of scan protection rule templates that can be configured.
            /// </summary>
            [NameInMap("AntiScanTemplateMaxCount")]
            [Validation(Required=false)]
            public long? AntiScanTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of back-to-origin IP addresses that can be configured.
            /// </summary>
            [NameInMap("BackendMaxCount")]
            [Validation(Required=false)]
            public long? BackendMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the basic protection rule module is supported. Valid values:
            /// 
            /// *   **true:** The basic protection rule module is supported.
            /// *   **false:** The basic protection rule module is not supported.
            /// </summary>
            [NameInMap("BaseWafGroup")]
            [Validation(Required=false)]
            public bool? BaseWafGroup { get; set; }

            /// <summary>
            /// The maximum number of protection rules that can be included in a basic protection rule template.
            /// </summary>
            [NameInMap("BaseWafGroupRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BaseWafGroupRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of basic protection rule templates that can be configured.
            /// </summary>
            [NameInMap("BaseWafGroupRuleTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BaseWafGroupRuleTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the bot management module is supported. Valid values:
            /// 
            /// *   **true:** The bot management module is supported.
            /// *   **false:** The bot management module is not supported.
            /// </summary>
            [NameInMap("Bot")]
            [Validation(Required=false)]
            public bool? Bot { get; set; }

            /// <summary>
            /// Indicates whether bot management for app protection is supported. Valid values:
            /// 
            /// *   **true:** Bot management for app protection is supported.
            /// *   **false:** Bot management for app protection is not supported.
            /// </summary>
            [NameInMap("BotApp")]
            [Validation(Required=false)]
            public string BotApp { get; set; }

            /// <summary>
            /// The maximum number of bot management rule templates that can be configured.
            /// </summary>
            [NameInMap("BotTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BotTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether bot management for website protection is supported. Valid values:
            /// 
            /// *   **true:** Bot management for website protection is supported.
            /// *   **false:** Bot management for website protection is not supported.
            /// </summary>
            [NameInMap("BotWeb")]
            [Validation(Required=false)]
            public string BotWeb { get; set; }

            /// <summary>
            /// The maximum number of CNAMEs that can be added.
            /// </summary>
            [NameInMap("CnameResourceMaxCount")]
            [Validation(Required=false)]
            public long? CnameResourceMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the custom response module is supported. Valid values:
            /// 
            /// *   **true:** The custom response module is supported.
            /// *   **false:** The custom response module is not supported.
            /// </summary>
            [NameInMap("CustomResponse")]
            [Validation(Required=false)]
            public bool? CustomResponse { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in a custom response rule template.
            /// </summary>
            [NameInMap("CustomResponseRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of custom response rule templates that can be configured.
            /// </summary>
            [NameInMap("CustomResponseTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the custom rule module is supported. Valid values:
            /// 
            /// *   **true:** The custom rule module is supported.
            /// *   **false:** The custom rule module is not supported.
            /// </summary>
            [NameInMap("CustomRule")]
            [Validation(Required=false)]
            public bool? CustomRule { get; set; }

            /// <summary>
            /// The action that can be included in a custom rule.
            /// </summary>
            [NameInMap("CustomRuleAction")]
            [Validation(Required=false)]
            public string CustomRuleAction { get; set; }

            /// <summary>
            /// The match conditions that can be used in a custom rule. For more information, see **Match condition parameters** in the "**Parameters of custom rules (custom_acl)**" section in the [CreateDefenseRule](~~CreateDefenseRule~~) topic.
            /// </summary>
            [NameInMap("CustomRuleCondition")]
            [Validation(Required=false)]
            public string CustomRuleCondition { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in a custom rule template.
            /// </summary>
            [NameInMap("CustomRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The statistical object for rate limiting in a custom rule.
            /// </summary>
            [NameInMap("CustomRuleRatelimitor")]
            [Validation(Required=false)]
            public string CustomRuleRatelimitor { get; set; }

            /// <summary>
            /// The maximum number of custom rule templates that can be configured.
            /// </summary>
            [NameInMap("CustomRuleTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomRuleTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of protected object groups that can be configured.
            /// </summary>
            [NameInMap("DefenseGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseGroupMaxCount { get; set; }

            /// <summary>
            /// The maximum number of protected objects that can be included in a protected object group.
            /// </summary>
            [NameInMap("DefenseObjectInGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInGroupMaxCount { get; set; }

            /// <summary>
            /// The maximum number of protected objects to which a protection rule template can be applied.
            /// </summary>
            [NameInMap("DefenseObjectInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of protected objects that can be configured.
            /// </summary>
            [NameInMap("DefenseObjectMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the data leakage prevention module is supported. Valid values:
            /// 
            /// *   **true:** The data leakage prevention module is supported.
            /// *   **false:** The data leakage prevention module is not supported.
            /// </summary>
            [NameInMap("Dlp")]
            [Validation(Required=false)]
            public bool? Dlp { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in a data leakage prevention rule template.
            /// </summary>
            [NameInMap("DlpRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of data leakage prevention rule templates that can be configured.
            /// </summary>
            [NameInMap("DlpTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether exclusive IP addresses are supported. Valid values:
            /// 
            /// *   **true:** Exclusive IP addresses are supported.
            /// *   **false:** Exclusive IP addresses are not supported.
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// Indicates whether global server load balancing (GSLB) is supported. Valid values:
            /// 
            /// *   **true:** GSLB is supported.
            /// *   **false:** GSLB is not supported.
            /// </summary>
            [NameInMap("Gslb")]
            [Validation(Required=false)]
            public bool? Gslb { get; set; }

            /// <summary>
            /// The HTTP port range that is supported. For more information, see [View supported ports](~~385578~~).
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// The HTTPS port range that is supported. For more information, see [View supported ports](~~385578~~).
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// Indicates whether the IP address blacklist module is supported. Valid values:
            /// 
            /// *   **true:** The IP address blacklist module is supported.
            /// *   **false:** The IP address blacklist module is not supported.
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public bool? IpBlacklist { get; set; }

            /// <summary>
            /// The maximum number of IP addresses that can be added to an IP address blacklist rule.
            /// </summary>
            [NameInMap("IpBlacklistIpInRuleMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistIpInRuleMaxCount { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in an IP address blacklist rule template.
            /// </summary>
            [NameInMap("IpBlacklistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of IP address blacklist rule templates that can be configured.
            /// </summary>
            [NameInMap("IpBlacklistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether IPv6 is supported. Valid values:
            /// 
            /// *   **true:** IPv6 is supported.
            /// *   **false:** IPv6 is not supported.
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public bool? Ipv6 { get; set; }

            /// <summary>
            /// Indicates whether the log collection feature is supported. Valid values:
            /// 
            /// *   **true:** The log collection feature is supported.
            /// *   **false:** The log collection feature is not supported.
            /// </summary>
            [NameInMap("LogService")]
            [Validation(Required=false)]
            public bool? LogService { get; set; }

            /// <summary>
            /// Indicates whether major event protection is supported. Valid values:
            /// 
            /// *   **true:** Major event protection is supported.
            /// *   **false:** Major event protection is not supported.
            /// </summary>
            [NameInMap("MajorProtection")]
            [Validation(Required=false)]
            public bool? MajorProtection { get; set; }

            /// <summary>
            /// The maximum number of major event protection rule templates that can be configured.
            /// </summary>
            [NameInMap("MajorProtectionTemplateMaxCount")]
            [Validation(Required=false)]
            public long? MajorProtectionTemplateMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the website tamper-proofing module is supported. Valid values:
            /// 
            /// *   **true:** The website tamper-proofing module is supported.
            /// *   **false:** The website tamper-proofing module is not supported.
            /// </summary>
            [NameInMap("Tamperproof")]
            [Validation(Required=false)]
            public bool? Tamperproof { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in a website tamper-proofing rule template.
            /// </summary>
            [NameInMap("TamperproofRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of website tamper-proofing rule templates that can be configured.
            /// </summary>
            [NameInMap("TamperproofTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist in a batch.
            /// </summary>
            [NameInMap("VastIpBlacklistInFileMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInFileMaxCount { get; set; }

            /// <summary>
            /// The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist on a page.
            /// </summary>
            [NameInMap("VastIpBlacklistInOperationMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInOperationMaxCount { get; set; }

            /// <summary>
            /// The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist per Alibaba Cloud account.
            /// </summary>
            [NameInMap("VastIpBlacklistMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistMaxCount { get; set; }

            /// <summary>
            /// Indicates whether the whitelist module is supported. Valid values:
            /// 
            /// *   **true:** The whitelist module is supported.
            /// *   **false:** The whitelist module is not supported.
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public bool? Whitelist { get; set; }

            /// <summary>
            /// The logical operators that can be used in a whitelist rule. For more information, see **Match condition parameters** in the "**Parameters of whitelist rules (whitelist)**" section in the [CreateDefenseRule](~~CreateDefenseRule~~) topic.
            /// </summary>
            [NameInMap("WhitelistLogical")]
            [Validation(Required=false)]
            public string WhitelistLogical { get; set; }

            /// <summary>
            /// The match fields that can be used in a whitelist rule. For more information, see **Match condition parameters** in the "**Parameters of whitelist rules (whitelist)**" section in the [CreateDefenseRule](~~CreateDefenseRule~~) topic.
            /// </summary>
            [NameInMap("WhitelistRuleCondition")]
            [Validation(Required=false)]
            public string WhitelistRuleCondition { get; set; }

            /// <summary>
            /// The maximum number of rules that can be included in a whitelist rule template.
            /// </summary>
            [NameInMap("WhitelistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// The maximum number of whitelist rule templates that can be configured.
            /// </summary>
            [NameInMap("WhitelistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistTemplateMaxCount { get; set; }

        }

        /// <summary>
        /// The edition of the WAF instance.
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The expiration time of the WAF instance.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Indicates whether the WAF instance has overdue payments. Valid values:
        /// 
        /// *   **0**: The WAF instance does not have overdue payments.
        /// *   **1**: The WAF instance has overdue payments.
        /// </summary>
        [NameInMap("InDebt")]
        [Validation(Required=false)]
        public string InDebt { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The billing method of the WAF instance. Valid values:
        /// 
        /// *   **POSTPAY:** The WAF instance uses the pay-as-you-go billing method.
        /// *   **PREPAY:** The WAF instance uses the subscription billing method.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou:** the Chinese mainland
        /// *   **ap-southeast-1:** outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The purchase time of the WAF instance. The time is in the UNIX timestamp format. The time is displayed in UTC. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The status of the WAF instance. Valid values:
        /// 
        /// *   **1:** The WAF instance is in a normal state.
        /// *   **2:** The WAF instance has expired.
        /// *   **3:** The WAF instance has been released.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}

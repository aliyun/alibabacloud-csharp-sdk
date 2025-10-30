// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the WAF instance.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyDetails Details { get; set; }
        public class DescribeInstanceResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The maximum number of IP addresses that can be added to the match content of a match condition. For more information, see <a href="https://help.aliyun.com/document_detail/374354.html">Match conditions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AclRuleMaxIpCount")]
            [Validation(Required=false)]
            public long? AclRuleMaxIpCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the scan protection module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The scan protection module is supported.</description></item>
            /// <item><description><b>false:</b> The scan protection module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AntiScan")]
            [Validation(Required=false)]
            public bool? AntiScan { get; set; }

            /// <summary>
            /// <para>The maximum number of scan protection rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AntiScanTemplateMaxCount")]
            [Validation(Required=false)]
            public long? AntiScanTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of back-to-origin IP addresses that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BackendMaxCount")]
            [Validation(Required=false)]
            public long? BackendMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the basic protection rule module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The basic protection rule module is supported.</description></item>
            /// <item><description><b>false:</b> The basic protection rule module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BaseWafGroup")]
            [Validation(Required=false)]
            public bool? BaseWafGroup { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that can be included in a basic protection rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BaseWafGroupRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BaseWafGroupRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of basic protection rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BaseWafGroupRuleTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BaseWafGroupRuleTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the bot management module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The bot management module is supported.</description></item>
            /// <item><description><b>false:</b> The bot management module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bot")]
            [Validation(Required=false)]
            public bool? Bot { get; set; }

            /// <summary>
            /// <para>Indicates whether bot management for app protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> Bot management for app protection is supported.</description></item>
            /// <item><description><b>false:</b> Bot management for app protection is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BotApp")]
            [Validation(Required=false)]
            public string BotApp { get; set; }

            /// <summary>
            /// <para>The maximum number of bot management rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BotTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BotTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether bot management for website protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> Bot management for website protection is supported.</description></item>
            /// <item><description><b>false:</b> Bot management for website protection is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BotWeb")]
            [Validation(Required=false)]
            public string BotWeb { get; set; }

            /// <summary>
            /// <para>The maximum number of CNAMEs that can be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CnameResourceMaxCount")]
            [Validation(Required=false)]
            public long? CnameResourceMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom response module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The custom response module is supported.</description></item>
            /// <item><description><b>false:</b> The custom response module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomResponse")]
            [Validation(Required=false)]
            public bool? CustomResponse { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in a custom response rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomResponseRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of custom response rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CustomResponseTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the custom rule module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The custom rule module is supported.</description></item>
            /// <item><description><b>false:</b> The custom rule module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomRule")]
            [Validation(Required=false)]
            public bool? CustomRule { get; set; }

            /// <summary>
            /// <para>The action that can be included in a custom rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("CustomRuleAction")]
            [Validation(Required=false)]
            public string CustomRuleAction { get; set; }

            /// <summary>
            /// <para>The match conditions that can be used in a custom rule. For more information, see <b>Match condition parameters</b> in the &quot;<b>Parameters of custom rules (custom_acl)</b>&quot; section in the <a href="~~CreateDefenseRule~~">CreateDefenseRule</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("CustomRuleCondition")]
            [Validation(Required=false)]
            public string CustomRuleCondition { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in a custom rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The statistical object for rate limiting in a custom rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>header</para>
            /// </summary>
            [NameInMap("CustomRuleRatelimitor")]
            [Validation(Required=false)]
            public string CustomRuleRatelimitor { get; set; }

            /// <summary>
            /// <para>The maximum number of custom rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CustomRuleTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomRuleTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protected object groups that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseGroupMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protected objects that can be included in a protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseObjectInGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInGroupMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protected objects to which a protection rule template can be applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseObjectInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protected objects that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20,000</para>
            /// </summary>
            [NameInMap("DefenseObjectMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the data leakage prevention module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The data leakage prevention module is supported.</description></item>
            /// <item><description><b>false:</b> The data leakage prevention module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Dlp")]
            [Validation(Required=false)]
            public bool? Dlp { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in a data leakage prevention rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DlpRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of data leakage prevention rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DlpTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpTemplateMaxCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ElasticQps")]
            [Validation(Required=false)]
            public int? ElasticQps { get; set; }

            /// <summary>
            /// <para>Indicates whether exclusive IP addresses are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> Exclusive IP addresses are supported.</description></item>
            /// <item><description><b>false:</b> Exclusive IP addresses are not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ExtendQps")]
            [Validation(Required=false)]
            public int? ExtendQps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("FreeQps")]
            [Validation(Required=false)]
            public int? FreeQps { get; set; }

            /// <summary>
            /// <para>Indicates whether global server load balancing (GSLB) is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> GSLB is supported.</description></item>
            /// <item><description><b>false:</b> GSLB is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Gslb")]
            [Validation(Required=false)]
            public bool? Gslb { get; set; }

            /// <summary>
            /// <para>The HTTP port range that is supported. For more information, see <a href="https://help.aliyun.com/document_detail/385578.html">View supported ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS port range that is supported. For more information, see <a href="https://help.aliyun.com/document_detail/385578.html">View supported ports</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>Indicates whether the IP address blacklist module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The IP address blacklist module is supported.</description></item>
            /// <item><description><b>false:</b> The IP address blacklist module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public bool? IpBlacklist { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses that can be added to an IP address blacklist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("IpBlacklistIpInRuleMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistIpInRuleMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in an IP address blacklist rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("IpBlacklistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP address blacklist rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpBlacklistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> IPv6 is supported.</description></item>
            /// <item><description><b>false:</b> IPv6 is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public bool? Ipv6 { get; set; }

            /// <summary>
            /// <para>Indicates whether the log collection feature is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The log collection feature is supported.</description></item>
            /// <item><description><b>false:</b> The log collection feature is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogService")]
            [Validation(Required=false)]
            public bool? LogService { get; set; }

            /// <summary>
            /// <para>Indicates whether major event protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> Major event protection is supported.</description></item>
            /// <item><description><b>false:</b> Major event protection is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MajorProtection")]
            [Validation(Required=false)]
            public bool? MajorProtection { get; set; }

            /// <summary>
            /// <para>The maximum number of major event protection rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MajorProtectionTemplateMaxCount")]
            [Validation(Required=false)]
            public long? MajorProtectionTemplateMaxCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("QpsBillingCap")]
            [Validation(Required=false)]
            public int? QpsBillingCap { get; set; }

            /// <summary>
            /// <para>Indicates whether the website tamper-proofing module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The website tamper-proofing module is supported.</description></item>
            /// <item><description><b>false:</b> The website tamper-proofing module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Tamperproof")]
            [Validation(Required=false)]
            public bool? Tamperproof { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in a website tamper-proofing rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TamperproofRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of website tamper-proofing rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TamperproofTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist in a batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2,000</para>
            /// </summary>
            [NameInMap("VastIpBlacklistInFileMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInFileMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist on a page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("VastIpBlacklistInOperationMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInOperationMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses or CIDR blocks that can be added to an IP address blacklist per Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50,000</para>
            /// </summary>
            [NameInMap("VastIpBlacklistMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the whitelist module is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> The whitelist module is supported.</description></item>
            /// <item><description><b>false:</b> The whitelist module is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public bool? Whitelist { get; set; }

            /// <summary>
            /// <para>The logical operators that can be used in a whitelist rule. For more information, see <b>Match condition parameters</b> in the &quot;<b>Parameters of whitelist rules (whitelist)</b>&quot; section in the <a href="~~CreateDefenseRule~~">CreateDefenseRule</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>contain</para>
            /// </summary>
            [NameInMap("WhitelistLogical")]
            [Validation(Required=false)]
            public string WhitelistLogical { get; set; }

            /// <summary>
            /// <para>The match fields that can be used in a whitelist rule. For more information, see <b>Match condition parameters</b> in the &quot;<b>Parameters of whitelist rules (whitelist)</b>&quot; section in the <a href="~~CreateDefenseRule~~">CreateDefenseRule</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("WhitelistRuleCondition")]
            [Validation(Required=false)]
            public string WhitelistRuleCondition { get; set; }

            /// <summary>
            /// <para>The maximum number of rules that can be included in a whitelist rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("WhitelistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of whitelist rule templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WhitelistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistTemplateMaxCount { get; set; }

        }

        /// <summary>
        /// <para>The edition of the WAF instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_version</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The expiration time of the WAF instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4809859200000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the WAF instance has overdue payments. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The WAF instance does not have overdue payments.</description></item>
        /// <item><description><b>1</b>: The WAF instance has overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InDebt")]
        [Validation(Required=false)]
        public string InDebt { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>POSTPAY:</b> The WAF instance uses the pay-as-you-go billing method.</description></item>
        /// <item><description><b>PREPAY:</b> The WAF instance uses the subscription billing method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1:</b> outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The purchase time of the WAF instance. The time is in the UNIX timestamp format. The time is displayed in UTC. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668496310000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1:</b> The WAF instance is in a normal state.</description></item>
        /// <item><description><b>2:</b> The WAF instance has expired.</description></item>
        /// <item><description><b>3:</b> The WAF instance has been released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}

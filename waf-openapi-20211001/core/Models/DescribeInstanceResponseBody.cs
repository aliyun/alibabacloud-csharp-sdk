// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyDetails Details { get; set; }
        public class DescribeInstanceResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The maximum number of IP addresses that can be added to the match content. For more information about match content, refer to <a href="https://help.aliyun.com/document_detail/374354.html">Match condition description</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AclRuleMaxIpCount")]
            [Validation(Required=false)]
            public long? AclRuleMaxIpCount { get; set; }

            /// <summary>
            /// <para>Indicates whether Agentic API security is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AgenticApisec")]
            [Validation(Required=false)]
            public bool? AgenticApisec { get; set; }

            /// <summary>
            /// <para>Specifies whether scan protection is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AntiScan")]
            [Validation(Required=false)]
            public bool? AntiScan { get; set; }

            /// <summary>
            /// <para>The maximum number of scan protection templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AntiScanTemplateMaxCount")]
            [Validation(Required=false)]
            public long? AntiScanTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Indicates whether API security is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Apisec")]
            [Validation(Required=false)]
            public bool? Apisec { get; set; }

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
            /// <para>Specifies whether basic protection rules are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BaseWafGroup")]
            [Validation(Required=false)]
            public bool? BaseWafGroup { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that can be included in a single basic protection rule template.</para>
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
            /// <para>Specifies whether bot management is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Bot")]
            [Validation(Required=false)]
            public bool? Bot { get; set; }

            /// <summary>
            /// <para>Indicates whether scenario-specific protection against app crawlers is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BotApp")]
            [Validation(Required=false)]
            public string BotApp { get; set; }

            /// <summary>
            /// <para>The maximum number of bot management protection templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("BotTemplateMaxCount")]
            [Validation(Required=false)]
            public long? BotTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Specifies whether scenario-specific protection against web crawlers is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
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
            /// <para>Indicates whether custom responses are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomResponse")]
            [Validation(Required=false)]
            public bool? CustomResponse { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single custom response template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomResponseRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of custom response templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CustomResponseTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomResponseTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Specifies whether custom rules are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomRule")]
            [Validation(Required=false)]
            public bool? CustomRule { get; set; }

            /// <summary>
            /// <para>The strings included in custom rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("CustomRuleAction")]
            [Validation(Required=false)]
            public string CustomRuleAction { get; set; }

            /// <summary>
            /// <para>The match conditions for custom rules. For more information, refer to the parameter description of <b>custom rule (custom_acl) conditions</b> in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("CustomRuleCondition")]
            [Validation(Required=false)]
            public string CustomRuleCondition { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single custom rule template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("CustomRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? CustomRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The rate limiting object for custom rules.</para>
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
            /// <para>The maximum number of protection groups that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseGroupMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protection objects that a protection group can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseObjectInGroupMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInGroupMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protection objects that can be associated with a single template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DefenseObjectInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protection objects that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("DefenseObjectMaxCount")]
            [Validation(Required=false)]
            public long? DefenseObjectMaxCount { get; set; }

            /// <summary>
            /// <para>Specifies whether data leak prevention is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Dlp")]
            [Validation(Required=false)]
            public bool? Dlp { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single information leak prevention template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DlpRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of information leak prevention templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DlpTemplateMaxCount")]
            [Validation(Required=false)]
            public long? DlpTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The burstable QPS value for the subscription instance with pay-as-you-go billing for burstable capacity. For more information, see <a href="https://help.aliyun.com/document_detail/441231.html">WAF 3.0 editions</a>.</para>
            /// <remarks>
            /// <para>This parameter has no practical meaning for <b>pay-as-you-go</b> instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("ElasticQps")]
            [Validation(Required=false)]
            public int? ElasticQps { get; set; }

            /// <summary>
            /// <para>Specifies whether exclusive IP addresses are supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// <para>The extended QPS value of the subscription instance. For more information, see <a href="https://help.aliyun.com/document_detail/441231.html">WAF 3.0 editions</a>.</para>
            /// <remarks>
            /// <para>This parameter is not applicable to <b>pay-as-you-go</b> instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ExtendQps")]
            [Validation(Required=false)]
            public int? ExtendQps { get; set; }

            /// <summary>
            /// <para>The free QPS value included in the subscription plan. For more information, see <a href="https://help.aliyun.com/document_detail/441231.html">WAF 3.0 editions</a>.</para>
            /// <remarks>
            /// <para>This parameter has no practical meaning for <b>pay-as-you-go</b> instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("FreeQps")]
            [Validation(Required=false)]
            public int? FreeQps { get; set; }

            /// <summary>
            /// <para>Specifies whether Global Server Load Balancing (GSLB) is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Gslb")]
            [Validation(Required=false)]
            public bool? Gslb { get; set; }

            /// <summary>
            /// <para>The available HTTP port range. For more information, refer to <a href="https://help.aliyun.com/document_detail/385578.html">Ports supported by WAF</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// <para>The available HTTPS port range. For more information, refer to <a href="https://help.aliyun.com/document_detail/385578.html">Ports supported by WAF</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

            /// <summary>
            /// <para>Indicates whether hybrid cloud is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HybridCloud")]
            [Validation(Required=false)]
            public bool? HybridCloud { get; set; }

            /// <summary>
            /// <para>The number of hybrid cloud extended nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HybridCloudNodeExtend")]
            [Validation(Required=false)]
            public int? HybridCloudNodeExtend { get; set; }

            /// <summary>
            /// <para>Indicates whether the IP blacklist is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IpBlacklist")]
            [Validation(Required=false)]
            public bool? IpBlacklist { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses that can be added to a blacklist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("IpBlacklistIpInRuleMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistIpInRuleMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single blacklist template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("IpBlacklistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of blacklist templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("IpBlacklistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? IpBlacklistTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>Specifies whether IPv6 is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public bool? Ipv6 { get; set; }

            /// <summary>
            /// <para>Specifies whether the log service is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogService")]
            [Validation(Required=false)]
            public bool? LogService { get; set; }

            /// <summary>
            /// <para>Specifies whether critical event protection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MajorProtection")]
            [Validation(Required=false)]
            public bool? MajorProtection { get; set; }

            /// <summary>
            /// <para>The maximum number of critical event protection templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MajorProtectionTemplateMaxCount")]
            [Validation(Required=false)]
            public long? MajorProtectionTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The QPS billing protection threshold for the pay-as-you-go edition. For more information, see <a href="https://help.aliyun.com/document_detail/2249021.html">Traffic billing protection</a> for pay-as-you-go.</para>
            /// <remarks>
            /// <para>This parameter has no practical meaning for <b>subscription</b> instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("QpsBillingCap")]
            [Validation(Required=false)]
            public int? QpsBillingCap { get; set; }

            /// <summary>
            /// <para>Indicates whether the multi-account management feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ResourceDirectory")]
            [Validation(Required=false)]
            public bool? ResourceDirectory { get; set; }

            /// <summary>
            /// <para>Specifies whether web tamper proofing is supported. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Tamperproof")]
            [Validation(Required=false)]
            public bool? Tamperproof { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single web tamper proofing template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TamperproofRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of web tamper proofing protection templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TamperproofTemplateMaxCount")]
            [Validation(Required=false)]
            public long? TamperproofTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses that can be imported to the IP blacklist in a single bulk import.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("VastIpBlacklistInFileMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInFileMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP addresses that can be added to the IP blacklist in a single page operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("VastIpBlacklistInOperationMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistInOperationMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of IP blacklist entries that a single user can configure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("VastIpBlacklistMaxCount")]
            [Validation(Required=false)]
            public long? VastIpBlacklistMaxCount { get; set; }

            /// <summary>
            /// <para>Specifies whether the IP whitelist is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public bool? Whitelist { get; set; }

            /// <summary>
            /// <para>The logical operators for whitelist rules. For more information, refer to the parameter description of <b>whitelist rule (whitelist) conditions</b> in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>contain</para>
            /// </summary>
            [NameInMap("WhitelistLogical")]
            [Validation(Required=false)]
            public string WhitelistLogical { get; set; }

            /// <summary>
            /// <para>The match fields for whitelist rules. For more information, refer to the parameter description of <b>whitelist rule (whitelist) conditions</b> in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("WhitelistRuleCondition")]
            [Validation(Required=false)]
            public string WhitelistRuleCondition { get; set; }

            /// <summary>
            /// <para>The maximum number of protection rules that a single whitelist template can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("WhitelistRuleInTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistRuleInTemplateMaxCount { get; set; }

            /// <summary>
            /// <para>The maximum number of whitelist templates that can be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WhitelistTemplateMaxCount")]
            [Validation(Required=false)]
            public long? WhitelistTemplateMaxCount { get; set; }

        }

        /// <summary>
        /// <para>The WAF edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default_version</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The time when the instance expires. The value is a UNIX timestamp. Unit: milliseconds. Format: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4809859200000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the current instance has an overdue payment. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InDebt")]
        [Validation(Required=false)]
        public string InDebt { get; set; }

        /// <summary>
        /// <para>The WAF instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The instance execution status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>commodity_converting</b>: The commodity is being converted.</para>
        /// </description></item>
        /// <item><description><para><b>commodity_convert_check_failed</b>: The commodity conversion check failed.</para>
        /// </description></item>
        /// <item><description><para><b>commodity_convert_process_failed</b>: The commodity conversion failed.</para>
        /// </description></item>
        /// <item><description><para><b>order_create_failed</b>: The order failed to be created.</para>
        /// </description></item>
        /// <item><description><para><b>order_pending_payment</b>: The order is pending payment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>order_pending_payment</para>
        /// </summary>
        [NameInMap("ProcessStatus")]
        [Validation(Required=false)]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
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
        /// <para>The purchase time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668496310000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The current status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Normal.</description></item>
        /// <item><description><b>2</b>: Expired.</description></item>
        /// <item><description><b>3</b>: Released.</description></item>
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

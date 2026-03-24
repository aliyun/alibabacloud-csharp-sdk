// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeChargeModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of billing modules for WAF.</para>
        /// </summary>
        [NameInMap("ChargeModules")]
        [Validation(Required=false)]
        public List<DescribeChargeModuleResponseBodyChargeModules> ChargeModules { get; set; }
        public class DescribeChargeModuleResponseBodyChargeModules : TeaModel {
            /// <summary>
            /// <para>The pricing model of the billing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NORMAL_PRICE</b>: tiered pricing.</para>
            /// </description></item>
            /// <item><description><para><b>STEP_ACCUMULATION</b>: tiered pricing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL_PRICE</para>
            /// </summary>
            [NameInMap("ChargeMode")]
            [Validation(Required=false)]
            public string ChargeMode { get; set; }

            /// <summary>
            /// <para>The detailed pricing information for the billing module.</para>
            /// </summary>
            [NameInMap("ChargeModeDetails")]
            [Validation(Required=false)]
            public List<string> ChargeModeDetails { get; set; }

            /// <summary>
            /// <para>The code of the billing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domainCount</b>: the number of domain names added to WAF in CNAME record mode.</para>
            /// </description></item>
            /// <item><description><para><b>qps</b>: the peak queries per second (QPS).</para>
            /// </description></item>
            /// <item><description><para><b>request</b>: the basic traffic fee.</para>
            /// </description></item>
            /// <item><description><para><b>ipBlacklistRuleCount</b>: the number of IP blacklist rules.</para>
            /// </description></item>
            /// <item><description><para><b>customAclBaseRuleCount</b>: the number of basic rules in custom protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>customAclAdvanceRuleCount</b>: the number of advanced rules in custom protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>antiScanRuleCount</b>: the number of scan protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>customResponseRuleCount</b>: the number of custom response rules.</para>
            /// </description></item>
            /// <item><description><para><b>ipv6</b>: IPv6 protection.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: intelligent load balancing.</para>
            /// </description></item>
            /// <item><description><para><b>exclusiveIpCount</b>: the number of exclusive IP addresses.</para>
            /// </description></item>
            /// <item><description><para><b>ccRuleCount</b>: the number of HTTP flood protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>regionBlockRuleCount</b>: the number of rules in the region blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>tamperproofRuleCount</b>: the number of web tamper-proofing rules.</para>
            /// </description></item>
            /// <item><description><para><b>dlpRuleCount</b>: the number of data leakage prevention rules.</para>
            /// </description></item>
            /// <item><description><para><b>botTraffic</b>: the traffic fee for bot management.</para>
            /// </description></item>
            /// <item><description><para><b>aiWhiteListTemplateCount</b>: the number of intelligent whitelist templates.</para>
            /// </description></item>
            /// <item><description><para><b>apisecResourceCount</b>: the number of protected objects for which API security is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>apisecTraffic</b>: the traffic fee for API security.</para>
            /// </description></item>
            /// <item><description><para><b>compliance</b>: the number of protocol compliance templates.</para>
            /// </description></item>
            /// <item><description><para><b>riskTraffic</b>: the number of times that risk identification in bot management is matched.</para>
            /// </description></item>
            /// <item><description><para><b>assetStatus</b>: asset center.</para>
            /// </description></item>
            /// <item><description><para><b>nonPort</b>: custom ports protection.</para>
            /// </description></item>
            /// <item><description><para><b>customAclCaptcha</b>: the number of times that sliders are used for custom protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>wafBaseTemplateCount</b>: the number of core web protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>instanceFee</b>: the WAF instance fee.</para>
            /// </description></item>
            /// <item><description><para><b>spikeThrottleRuleCount</b>: the number of peak traffic throttling rules.</para>
            /// </description></item>
            /// <item><description><para><b>botWebTemplateCount</b>: the number of web protection templates in bot management.</para>
            /// </description></item>
            /// <item><description><para><b>botAppTemplateCount</b>: the number of app protection templates in bot management.</para>
            /// </description></item>
            /// <item><description><para><b>customAclBotRuleCount</b>: the number of advanced custom rules in bot management.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domainCount</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The billing cycle of the billing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Hour</b>: hourly billing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("PeriodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

            /// <summary>
            /// <para>The usage type of the billing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>template</b>: template.</para>
            /// </description></item>
            /// <item><description><para><b>qps</b>: QPS.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: domain name.</para>
            /// </description></item>
            /// <item><description><para><b>rule</b>: rule.</para>
            /// </description></item>
            /// <item><description><para><b>ip</b>: IP address.</para>
            /// </description></item>
            /// <item><description><para><b>resource</b>: protected object.</para>
            /// </description></item>
            /// <item><description><para><b>request</b>: request.</para>
            /// </description></item>
            /// <item><description><para><b>function</b>: feature enablement.</para>
            /// </description></item>
            /// <item><description><para><b>time</b>: number of times.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

            /// <summary>
            /// <para>The billing unit coefficient of the billing module.</para>
            /// <remarks>
            /// <para>The usage unit for the module is determined by multiplying the <b>UsageUnitFactor</b> by the <b>UsageType</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsageUnitFactor")]
            [Validation(Required=false)]
            public int? UsageUnitFactor { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

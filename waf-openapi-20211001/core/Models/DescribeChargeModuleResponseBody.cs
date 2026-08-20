// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeChargeModuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of WAF pricing module information.</para>
        /// </summary>
        [NameInMap("ChargeModules")]
        [Validation(Required=false)]
        public List<DescribeChargeModuleResponseBodyChargeModules> ChargeModules { get; set; }
        public class DescribeChargeModuleResponseBodyChargeModules : TeaModel {
            /// <summary>
            /// <para>The pricing mode of the pricing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NORMAL_PRICE</b>: standard pricing.</description></item>
            /// <item><description><b>STEP_ACCUMULATION</b>: tiered pricing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL_PRICE</para>
            /// </summary>
            [NameInMap("ChargeMode")]
            [Validation(Required=false)]
            public string ChargeMode { get; set; }

            /// <summary>
            /// <para>The pricing details of the pricing module.</para>
            /// </summary>
            [NameInMap("ChargeModeDetails")]
            [Validation(Required=false)]
            public List<string> ChargeModeDetails { get; set; }

            /// <summary>
            /// <para>The pricing unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SeCU</para>
            /// </summary>
            [NameInMap("ChargeUnit")]
            [Validation(Required=false)]
            public string ChargeUnit { get; set; }

            /// <summary>
            /// <para>The pricing module identity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domainCount</b>: the number of CNAME-connected domain names.</description></item>
            /// <item><description><b>qps</b>: the peak QPS.</description></item>
            /// <item><description><b>request</b>: the basic traffic fee.</description></item>
            /// <item><description><b>ipBlacklistRuleCount</b>: the number of IP blacklist rules.</description></item>
            /// <item><description><b>customAclBaseRuleCount</b>: the number of Basic Policies in custom rules.</description></item>
            /// <item><description><b>customAclAdvanceRuleCount</b>: the number of advanced rules in custom rules.</description></item>
            /// <item><description><b>antiScanRuleCount</b>: the number of scan protection rules.</description></item>
            /// <item><description><b>customResponseRuleCount</b>: the number of custom response rules.</description></item>
            /// <item><description><b>ipv6</b>: IPv6.</description></item>
            /// <item><description><b>gslb</b>: intelligent load balancing.</description></item>
            /// <item><description><b>exclusiveIpCount</b>: the number of exclusive IP addresses.</description></item>
            /// <item><description><b>ccRuleCount</b>: the number of HTTP flood mitigation rules.</description></item>
            /// <item><description><b>regionBlockRuleCount</b>: the number of Location Blacklist rules.</description></item>
            /// <item><description><b>tamperproofRuleCount</b>: the number of web tamper proofing rules.</description></item>
            /// <item><description><b>dlpRuleCount</b>: the number of information leak prevention rules.</description></item>
            /// <item><description><b>botTraffic</b>: the Bot management traffic fee.</description></item>
            /// <item><description><b>aiWhiteListTemplateCount</b>: the number of intelligent whitelist templates.</description></item>
            /// <item><description><b>apisecResourceCount</b>: the number of protected objects with API security enabled.</description></item>
            /// <item><description><b>apisecTraffic</b>: the API security traffic fee.</description></item>
            /// <item><description><b>compliance</b>: the number of protocol compliance templates.</description></item>
            /// <item><description><b>riskTraffic</b>: the number of risk identification hits in Bot management.</description></item>
            /// <item><description><b>assetStatus</b>: the asset center.</description></item>
            /// <item><description><b>nonPort</b>: non-standard ports.</description></item>
            /// <item><description><b>customAclCaptcha</b>: the number of custom rule slider verification attempts.</description></item>
            /// <item><description><b>wafBaseTemplateCount</b>: the number of web core protection rules.</description></item>
            /// <item><description><b>instanceFee</b>: the WAF instance fee.</description></item>
            /// <item><description><b>spikeThrottleRuleCount</b>: the number of peak traffic throttling rules.</description></item>
            /// <item><description><b>botWebTemplateCount</b>: the number of web protection templates in Bot management.</description></item>
            /// <item><description><b>botAppTemplateCount</b>: the number of app protection templates in Bot management.</description></item>
            /// <item><description><b>customAclBotRuleCount</b>: the number of advanced custom rules in Bot management.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domainCount</para>
            /// </summary>
            [NameInMap("ModuleCode")]
            [Validation(Required=false)]
            public string ModuleCode { get; set; }

            /// <summary>
            /// <para>The billing period type of the pricing module. Valid values:</para>
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
            /// <para>The usage type of the pricing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>template</b>: template.</description></item>
            /// <item><description><b>qps</b>: QPS.</description></item>
            /// <item><description><b>domain</b>: domain name.</description></item>
            /// <item><description><b>rule</b>: rule.</description></item>
            /// <item><description><b>ip</b>: IP address.</description></item>
            /// <item><description><b>resource</b>: protected object.</description></item>
            /// <item><description><b>reqest</b>: request.</description></item>
            /// <item><description><b>function</b>: feature enablement.</description></item>
            /// <item><description><b>time</b>: number of times.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("UsageType")]
            [Validation(Required=false)]
            public string UsageType { get; set; }

            /// <summary>
            /// <para>The billing unit factor of the pricing module.</para>
            /// <remarks>
            /// <para>The billing unit factor <b>UsageUnitFactor</b> multiplied by the usage type <b>UsageType</b> forms the billing unit of the module.</para>
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

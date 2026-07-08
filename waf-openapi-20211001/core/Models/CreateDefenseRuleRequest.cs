// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The scenario to which the protection rule is applied.</para>
        /// <para>If <b>DefenseType</b> is set to <b>template</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>waf_group</b>: basic protection.</para>
        /// </description></item>
        /// <item><description><para><b>waf_base</b>: web core protection.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: scan protection.</para>
        /// </description></item>
        /// <item><description><para><b>ip_blacklist</b>: IP address blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_acl</b>: custom rule.</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: geo-blocking.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response.</para>
        /// </description></item>
        /// <item><description><para><b>cc</b>: HTTP flood protection.</para>
        /// </description></item>
        /// <item><description><para><b>tamperproof</b>: webpage tamper-proofing.</para>
        /// </description></item>
        /// <item><description><para><b>dlp</b>: data leakage prevention.</para>
        /// </description></item>
        /// <item><description><para><b>spike_throttle</b>: rate limiting for bursts of traffic.</para>
        /// </description></item>
        /// <item><description><para><b>bot_manager</b>: bot management.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>DefenseType</b> is set to <b>resource</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>account_identifier</b>: account identification.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response.</para>
        /// </description></item>
        /// <item><description><para><b>waf_codec</b>: decoding.</para>
        /// </description></item>
        /// </list>
        /// <para>If <b>DefenseType</b> is set to <b>global</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>regular_custom</b>: custom regular expression.</para>
        /// </description></item>
        /// <item><description><para><b>address_book</b>: address book.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can apply a global custom response to a protected object or a rule. If you configure custom response rules at different levels, the rule with the finest-grained scope takes precedence. The priority is as follows: rule &gt; protected object &gt; default page.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The type of the protection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>template</b> (default): a template-based protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>resource</b>: a rule for a specific protected object.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: a global protection rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to get the ID of your WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: Chinese mainland.</para>
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
        /// <para>The protected object to which the rule applies.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>resource</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sec****-waf</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The details of the protection rule. This value is a JSON string.</para>
        /// <remarks>
        /// <para>The parameters in the JSON string vary based on the value of <b>DefenseScene</b>. For more information, see <b>Protection rule parameters</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule template.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>template</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1122</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

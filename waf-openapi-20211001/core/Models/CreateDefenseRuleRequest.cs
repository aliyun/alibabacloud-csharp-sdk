// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario for the rule.</para>
        /// <para>When <b>DefenseType</b> is <b>template</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>waf_group</b>: basic protection.</para>
        /// </description></item>
        /// <item><description><para><b>waf_base</b>: new version of Web core protection.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: scan protection.</para>
        /// </description></item>
        /// <item><description><para><b>ip_blacklist</b>: IP blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_acl</b>: custom rules.</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: location blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: legacy custom response.</para>
        /// </description></item>
        /// <item><description><para><b>cc</b>: HTTP flood protection.</para>
        /// </description></item>
        /// <item><description><para><b>tamperproof</b>: webpage tamper protection.</para>
        /// </description></item>
        /// <item><description><para><b>dlp</b>: data leak prevention.</para>
        /// </description></item>
        /// <item><description><para><b>spike_throttle</b>: peak traffic throttling.</para>
        /// </description></item>
        /// </list>
        /// <para>When <b>DefenseType</b> is <b>resource</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>account_identifier</b>: account extraction.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: new version of custom response.</para>
        /// </description></item>
        /// <item><description><para><b>waf_codec</b>: decoding.</para>
        /// </description></item>
        /// </list>
        /// <para>When <b>DefenseType</b> is <b>global</b>, valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>regular_custom</b>: custom regex.</para>
        /// </description></item>
        /// <item><description><para><b>address_book</b>: address book.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: new version of custom response.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For globally configured custom responses, users can reference them under protected objects or rules. When referenced at different levels, the effective logic follows this order: rule level &gt; protected object level &gt; default page.</para>
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
        /// <item><description><para><b>template</b> (default): template-based protection rules.</para>
        /// </description></item>
        /// <item><description><para><b>resource</b>: rules applied at the protected object level.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: global-level rules.</para>
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
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The protected object associated with the rule.</para>
        /// <remarks>
        /// <para>Provide this parameter only when <b>DefenseType</b> is <b>resource</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sec****-waf</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The rule configuration content, specified as a JSON string.</para>
        /// <remarks>
        /// <para>The specific parameters vary based on the specified <b>DefenseType</b> (<b>DefenseScene</b>). For details, see <b>Protection Rule Parameter Descriptions</b>.</para>
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
        /// <para>The ID of the protection template to which the rule belongs.</para>
        /// <remarks>
        /// <para>Provide this parameter only when <b>DefenseType</b> is <b>template</b>.</para>
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

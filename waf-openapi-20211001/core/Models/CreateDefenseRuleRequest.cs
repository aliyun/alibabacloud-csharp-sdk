// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The WAF protection scenario to create.</para>
        /// <para>When the protection rule type <b>DefenseType</b> is set to <b>template</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>waf_group</b>: basic protection.</para>
        /// </description></item>
        /// <item><description><para><b>waf_base</b>: new version of Web Core Protection.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: Scan Protection.</para>
        /// </description></item>
        /// <item><description><para><b>ip_blacklist</b>: IP Blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_acl</b>: Custom Rule.</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: Whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: Location Blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: legacy Custom Response.</para>
        /// </description></item>
        /// <item><description><para><b>cc</b>: HTTP Flood Protection.</para>
        /// </description></item>
        /// <item><description><para><b>tamperproof</b>: web tamper proofing.</para>
        /// </description></item>
        /// <item><description><para><b>dlp</b>: Information Leak Prevention.</para>
        /// </description></item>
        /// <item><description><para><b>spike_throttle</b>: peak traffic throttling.</para>
        /// </description></item>
        /// <item><description><para><b>bot_manager</b>: BOT Management.</para>
        /// </description></item>
        /// </list>
        /// <para>When the protection rule type <b>DefenseType</b> is set to <b>resource</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>account_identifier</b>: Account Extraction.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: new version of Custom Response.</para>
        /// </description></item>
        /// <item><description><para><b>waf_codec</b>: Decoding.</para>
        /// </description></item>
        /// <item><description><para><b>websdk</b>: WebSDK Integration.</para>
        /// </description></item>
        /// </list>
        /// <para>When the protection rule type <b>DefenseType</b> is set to <b>global</b>, valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>regular_custom</b>: Custom Regex.</para>
        /// </description></item>
        /// <item><description><para><b>address_book</b>: Address Book.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: new version of Custom Response.</para>
        /// <remarks>
        /// <para>For the custom response in global configuration, users can reference it at the protected object or rule level. When custom response rules are referenced at different dimensions, the actual effective logic is: rule level &gt; protected object level &gt; default page.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The type of the protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run mode. If you do not specify this parameter, a normal request is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A dry run request is sent. The system only checks whether the request meets the execution conditions without performing the specified operation. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the error code Defense.Control.DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b>: A normal request is sent. The specified operation is performed after the request passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of your current WAF instance.</para>
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
        /// <para>The protected object associated with the rule to be created.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The rule configuration content, which is a string converted from a JSON-formatted array of parameters.</para>
        /// <remarks>
        /// <para>The specific parameters vary depending on the specified <b>protection rule type</b> (<b>DefenseScene</b>). For more information, refer to <b>Protection rule parameter descriptions</b>.</para>
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
        /// <para>The ID of the protection template for the protection rule to be created.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>template</b>.
        /// There is an upper limit on the number of rules that can be created within the same protection template. For specific limits, refer to <b>Rule quantity limits</b>. When the rule quantity has reached the upper limit, you can call the <a href="https://help.aliyun.com/document_detail/461613.html">CreateDefenseTemplate</a> operation to create a new protection template. You can also call the <a href="https://help.aliyun.com/document_detail/461422.html">ModifyDefenseRule</a> operation to modify an existing rule.</para>
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

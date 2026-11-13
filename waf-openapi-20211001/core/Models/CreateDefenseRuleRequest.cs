// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The WAF protection scenario to be created.</para>
        /// <para>Valid values when the protection rule type <b>DefenseType</b> is set to <b>template</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>waf_group</b>: basic protection.</para>
        /// </description></item>
        /// <item><description><para><b>waf_base</b>: new version of web core protection.</para>
        /// </description></item>
        /// <item><description><para><b>antiscan</b>: scan protection.</para>
        /// </description></item>
        /// <item><description><para><b>ip_blacklist</b>: IP blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>custom_acl</b>: custom rules.</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>region_block</b>: area blocking.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response of the old version.</para>
        /// </description></item>
        /// <item><description><para><b>cc</b>: HTTP flood protection.</para>
        /// </description></item>
        /// <item><description><para><b>tamperproof</b>: web tamper-proofing.</para>
        /// </description></item>
        /// <item><description><para><b>dlp</b>: data leak prevention.</para>
        /// </description></item>
        /// <item><description><para><b>spike_throttle</b>: peak traffic throttling.</para>
        /// </description></item>
        /// <item><description><para><b>bot_manager</b>: bot management.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values when the protection rule type <b>DefenseType</b> is set to <b>resource</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>account_identifier</b>: account extraction.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response of the new version.</para>
        /// </description></item>
        /// <item><description><para><b>waf_codec</b>: decoding.</para>
        /// </description></item>
        /// <item><description><para><b>websdk</b>: WebSDK integration.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values when the protection rule type <b>DefenseType</b> is set to <b>global</b>:</para>
        /// <list type="bullet">
        /// <item><description><para><b>regular_custom</b>: custom regular expressions.</para>
        /// </description></item>
        /// <item><description><para><b>address_book</b>: address book.</para>
        /// </description></item>
        /// <item><description><para><b>custom_response</b>: custom response of the new version.</para>
        /// <remarks>
        /// <para>For globally configured custom responses, you can reference them under protected objects or rules. When custom response rules are referenced at different dimensions, the actual effective priority is: rule level &gt; protected object level &gt; default page.</para>
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
        /// <para>Specifies whether to enable the dry run mode. If this parameter is not specified, a normal request is initiated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: initiates a dry run request. The system only checks whether the request meets the execution conditions and does not perform the operations specified in the request. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the error code Defense.Control.DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b>: initiates a normal request. The system performs the operations specified in the request after the check succeeds.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of your WAF instance.</para>
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
        /// <para>The protected object corresponding to the created rule.</para>
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
        /// <para>The type of the protected target. This parameter applies to rules where <b>DefenseType</b> is set to <b>resource</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>single</b> (default): a single protected object.</description></item>
        /// <item><description><b>group</b>: a protection group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The rule configuration content, which is converted into a string in JSON format constructed by a series of parameters.</para>
        /// <remarks>
        /// <para>The specific parameters involved vary depending on the specified <b>protection rule type</b> (<b>DefenseScene</b>). For more information, see <b>Protection rule parameter description</b>.</para>
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
        /// The number of rules that can be created in a single protection template is limited. For more information, see <b>Rule quantity limits</b>. If the limit is reached, you can call the <a href="https://help.aliyun.com/document_detail/461613.html">CreateDefenseTemplate</a> operation to create a new protection template, or call the <a href="https://help.aliyun.com/document_detail/461422.html">ModifyDefenseRule</a> operation to modify an existing rule.</para>
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

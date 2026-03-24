// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario. For more information, see the <b>DefenseScene</b> parameter of the <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bot_custom_acl</para>
        /// </summary>
        [NameInMap("DefenseSubScene")]
        [Validation(Required=false)]
        public string DefenseSubScene { get; set; }

        /// <summary>
        /// <para>The description of the protection template.</para>
        /// <list type="bullet">
        /// <item><description><b>bot_custom_acl</b>: Represents the protection template for advanced custom rules in bot management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to get the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: Represents the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Represents regions outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the protection template. The name must be 1 to 255 characters long and can contain letters, digits, Chinese characters, underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>The names of templates for the same protection scenario (<b>DefenseScene</b>) must be unique.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test221</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The origin of the protection template. The value must be <b>custom</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("TemplateOrigin")]
        [Validation(Required=false)]
        public string TemplateOrigin { get; set; }

        /// <summary>
        /// <para>Indicates whether the protection template is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public int? TemplateStatus { get; set; }

        /// <summary>
        /// <para>The type of the protection template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>user_default</b>: The user\&quot;s default template.</para>
        /// </description></item>
        /// <item><description><para><b>user_custom</b>: A user-defined template.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The protected objects to unbind when you create a default template. Use the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when you create a <b>default template</b> (<b>TemplateType</b> is set to <b>user_default</b>).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// </summary>
        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}

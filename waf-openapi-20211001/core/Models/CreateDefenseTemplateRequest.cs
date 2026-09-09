// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario. For more information, see the <b>DefenseScene</b> parameter in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The sub-scenario of the protection template. This parameter is supported only for the advanced bot management scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("DefenseSubScene")]
        [Validation(Required=false)]
        public string DefenseSubScene { get; set; }

        /// <summary>
        /// <para>The description of the protection template to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The detailed template information, which is a JSON-formatted string. Different key-value pairs represent different attributes of the protected object. For more information, see the Detail description.</para>
        /// <remarks>
        /// <para>This parameter applies only to the new version of basic protection (<b>waf_base</b>) and the new version of bot management (<b>bot_manager</b>) protection scenarios. This parameter is required for the new version of bot management (<b>bot_manager</b>) protection scenario.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;trafficFeature&quot;:&quot;{\&quot;global\&quot;:0,\&quot;excludeStatus\&quot;:1,\&quot;conditions\&quot;:[{\&quot;key\&quot;:\&quot;URL\&quot;,\&quot;opValue\&quot;:\&quot;not-contain\&quot;,\&quot;values\&quot;:\&quot;test\&quot;}]}&quot;}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run mode. If you do not specify this parameter, a normal request is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: A dry run request is sent. The system checks whether the request meets the execution conditions without performing the specified operation. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the error code Defense.Control.DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: A normal request is sent. The specified operation is performed after the request passes the check.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the ID of the current WAF instance.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the protection template to create. The name must be 1 to 255 characters in length and can contain Chinese characters, letters, digits, underscores (_), periods (.), and hyphens (-).</para>
        /// <remarks>
        /// <para>Template names must be unique within the same protection scenario (<b>DefenseScene</b>).</para>
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
        /// <para>The source of the protection template to create. Set the value to <b>custom</b>, which indicates user-defined.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("TemplateOrigin")]
        [Validation(Required=false)]
        public string TemplateOrigin { get; set; }

        /// <summary>
        /// <para>The status of the protection template to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
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
        /// <para>The templatetype of the protection template to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>user_default</b>: default protection.</description></item>
        /// <item><description><b>user_custom</b>: custom protection.</description></item>
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
        /// <para>The protected object groups to unbind when creating a default protection template. Use the format [<b>&quot;group1&quot;,&quot;group2&quot;,……</b>].</para>
        /// <remarks>
        /// <para>This parameter takes effect only when creating a <b>default template</b> (when <b>TemplateType</b> is set to <b>user_default</b>).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects to unbind when creating a default protection template. Use the format [<b>&quot;XX1&quot;,&quot;XX2&quot;,……</b>].</para>
        /// <remarks>
        /// <para>This parameter takes effect only when creating a <b>default template</b> (when <b>TemplateType</b> is set to <b>user_default</b>).</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}

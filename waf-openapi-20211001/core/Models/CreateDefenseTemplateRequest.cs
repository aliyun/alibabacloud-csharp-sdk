// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which you want to use the protection rule template. For more information, see the description of the <b>DefenseScene</b> parameter in the <a href="~~CreateDefenseRule~~">CreateDefenseRule</a> topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The description of the protection rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland.</description></item>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the protection rule template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test221</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The origin of the protection rule template that you want to create. Set the value to <b>custom</b>. The value specifies that the protection rule template is a custom template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("TemplateOrigin")]
        [Validation(Required=false)]
        public string TemplateOrigin { get; set; }

        /// <summary>
        /// <para>The status of the protection rule template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0:</b> disabled.</description></item>
        /// <item><description><b>1:</b> enabled.</description></item>
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
        /// <para>The type of the protection rule template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>user_default:</b> default template.</description></item>
        /// <item><description><b>user_custom:</b> custom template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

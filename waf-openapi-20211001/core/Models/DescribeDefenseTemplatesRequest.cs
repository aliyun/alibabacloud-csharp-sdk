// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which the protection template is used.</para>
        /// <list type="bullet">
        /// <item><description><b>waf_group</b>: basic protection.</description></item>
        /// <item><description><b>antiscan</b>: scan protection.</description></item>
        /// <item><description><b>ip_blacklist</b>: IP address blacklist.</description></item>
        /// <item><description><b>custom_acl</b>: custom rule.</description></item>
        /// <item><description><b>whitelist</b>: whitelist.</description></item>
        /// <item><description><b>region_block</b>: region blacklist.</description></item>
        /// <item><description><b>custom_response</b>: custom response.</description></item>
        /// <item><description><b>cc</b>: HTTP flood protection.</description></item>
        /// <item><description><b>tamperproof</b>: website tamper-proofing.</description></item>
        /// <item><description><b>dlp</b>: data leakage prevention.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region_block</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The sub-scenario in which the protection template is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web</b>: bot management for website protection.</description></item>
        /// <item><description><b>app</b>: bot management for app protection.</description></item>
        /// <item><description><b>basic</b>: bot management for basic protection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("DefenseSubScene")]
        [Validation(Required=false)]
        public string DefenseSubScene { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-pe33b****03</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the protected object or protected object group.</para>
        /// <remarks>
        /// <para> If you specify ResourceType, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxxqiu.cc-ecs</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvyknl****fa</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the protected resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>single</b>: protected object. This is the default value.</description></item>
        /// <item><description><b>group</b>: protected object group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify Resource, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the protection template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The IDs of the protection templates that you want to query. Separate multiple template IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>189731,189539,189538,189531,189540,189542,189541</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        /// <summary>
        /// <para>The name of the protection template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testTemplateName</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the protection template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>user_default</b>: default template.</description></item>
        /// <item><description><b>user_custom</b>: custom template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>user_default</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}

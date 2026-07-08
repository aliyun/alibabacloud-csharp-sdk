// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario. For more information, see the description of the <b>DefenseScene</b> parameter in the <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region_block</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// <para>The sub-scenario of the protection template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>web</b>: the web protection template for bot management.</para>
        /// </description></item>
        /// <item><description><para><b>app</b>: the app protection template for bot management.</para>
        /// </description></item>
        /// <item><description><para><b>basic</b>: the basic protection template for bot management.</para>
        /// </description></item>
        /// <item><description><para><b>bot_custom_acl</b>: the advanced custom protection rule template for bot management.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("DefenseSubScene")]
        [Validation(Required=false)]
        public string DefenseSubScene { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The name of the protected object or protected object group, or the ID of the protected asset.</para>
        /// <remarks>
        /// <para>You must specify the Resource and ResourceType parameters to filter query results.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ruiqiu.cc-ecs</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <item><description><para><b>single</b> (default): a protected object.</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: a protected object group.</para>
        /// </description></item>
        /// <item><description><para><b>asset</b>: a protected asset.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify the Resource and ResourceType parameters to filter query results.</para>
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
        /// <para>39395</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The IDs of the protection templates that you want to query. You can specify this parameter to query the protected objects for which multiple protection templates take effect. Separate multiple template IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>189731,189539,189538,189531,189540,189542,189541</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        /// <summary>
        /// <para>The name of the protection template to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the protection template that you want to create. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>user_default</b>: default protection template.</para>
        /// </description></item>
        /// <item><description><para><b>user_custom</b>: custom protection template.</para>
        /// </description></item>
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

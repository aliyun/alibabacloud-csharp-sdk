// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario. For more information, see the <b>DefenseScene</b> parameter in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
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
        /// <item><description><b>web</b>: BOT management web protection scenario template.</description></item>
        /// <item><description><b>app</b>: BOT management app protection scenario template.</description></item>
        /// <item><description><b>basic</b>: BOT management basic protection template.</description></item>
        /// <item><description><b>bot_custom_acl</b>: BOT management advanced custom rule protection template.</description></item>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The page number to return in a paging query request. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
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
        /// <para>The name of the protected object, protection group, or the ID of the protected asset.</para>
        /// <remarks>
        /// <para>This parameter is used together with the ResourceType parameter. Both parameters must have values for filtering to take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ruiqiu.cc-ecs</para>
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
        /// <para>The type of the protected resource.</para>
        /// <remarks>
        /// <para>This parameter is used together with the Resource parameter. Both parameters must have values for filtering to take effect.</para>
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
        /// <para>The IDs of the protection templates to query. You can specify this parameter to query the protected resources associated with multiple protection templates. Separate multiple template IDs with commas (,).</para>
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
        /// <para>The templatetype of the protection template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>user_default</b>: user default protection.</description></item>
        /// <item><description><b>user_custom</b>: user custom protection.</description></item>
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

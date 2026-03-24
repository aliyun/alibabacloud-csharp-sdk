// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The protection scenario to modify. For more information, see the <b>DefenseScene</b> parameter in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
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
        /// <item><description><para><b>template</b> (default): a template protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>resource</b>: a rule for a specific protected object.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: a global rule.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of your WAF instance.</para>
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
        /// <para>The region of the WAF instance. Valid values:</para>
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
        /// <para>The protected object for which you want to modify the rule.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>resource</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rencs***-waf</para>
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
        /// <para>The details of the protection rule, in a JSON string format. Specify the rule ID and the configuration of the protection rule to modify. The details include the following:</para>
        /// <list type="bullet">
        /// <item><description><para><b>id</b>: The ID of the rule. This parameter is required. Data type: Long.</para>
        /// </description></item>
        /// <item><description><para>Configuration of the protection rule: The parameters are the same as the <b>Rules</b> parameter of the <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a> operation. For more information, see the description of the protection rule parameters in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;id&quot;: 2344,
        ///             &quot;policyId&quot;: 1012,
        ///             &quot;action&quot;: &quot;block&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The ID of the protection template.</para>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>template</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5325</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

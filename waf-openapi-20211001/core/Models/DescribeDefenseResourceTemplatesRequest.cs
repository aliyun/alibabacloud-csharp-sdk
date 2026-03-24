// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-9lb36****0e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland</para>
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
        /// <para>The name of the protected object or protected object group, or the ID of the protected asset to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mitsuichemicals.cn-waf</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2ax2y5****pi</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of protected resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>single</b> (default): A protected object.</para>
        /// </description></item>
        /// <item><description><para><b>group</b>: A protected object group.</para>
        /// </description></item>
        /// <item><description><para><b>asset</b>: A protected asset.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20111098</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoRuleName</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of protection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>defense</b> (default): A protection rule.</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: A whitelist rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The name of the protection template to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test221</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}

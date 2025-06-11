// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The module to which the protection rule that you want to create belongs.</para>
        /// <list type="bullet">
        /// <item><description><b>waf_group:</b> the basic protection rule module.</description></item>
        /// <item><description><b>antiscan:</b> the scan protection module.</description></item>
        /// <item><description><b>ip_blacklist:</b> the IP address blacklist module.</description></item>
        /// <item><description><b>custom_acl:</b> the custom rule module.</description></item>
        /// <item><description><b>whitelist:</b> the whitelist module.</description></item>
        /// <item><description><b>region_block:</b> the region blacklist module.</description></item>
        /// <item><description><b>custom_response:</b> the custom response module.</description></item>
        /// <item><description><b>cc:</b> the HTTP flood protection module.</description></item>
        /// <item><description><b>tamperproof:</b> the website tamper-proofing module.</description></item>
        /// <item><description><b>dlp:</b> the data leakage prevention module.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_group</para>
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The ID of the rule template for which you want to create a protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1122</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyTemplateResourcesRequest : TeaModel {
        [NameInMap("BindAssets")]
        [Validation(Required=false)]
        public List<string> BindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups that you want to associate with the template. Specify the value in the [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("BindResourceGroups")]
        [Validation(Required=false)]
        public List<string> BindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects that you want to associate with the template. Specify the value in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("BindResources")]
        [Validation(Required=false)]
        public List<string> BindResources { get; set; }

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
        /// <para>The region ID of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland</description></item>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2291</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("UnbindAssets")]
        [Validation(Required=false)]
        public List<string> UnbindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups that you want to disassociate from the template. Specify the value in the [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects that you want to disassociate from the template. Specify the value in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}

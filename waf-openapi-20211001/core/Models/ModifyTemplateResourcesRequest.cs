// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyTemplateResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the protected assets to attach. The value is in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("BindAssets")]
        [Validation(Required=false)]
        public List<string> BindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups to attach. The value is in the [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("BindResourceGroups")]
        [Validation(Required=false)]
        public List<string> BindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects to attach. The value is in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("BindResources")]
        [Validation(Required=false)]
        public List<string> BindResources { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The ID of the protection template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2291</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The IDs of the protected assets to detach. The value is in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("UnbindAssets")]
        [Validation(Required=false)]
        public List<string> UnbindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups to detach. The value is in the [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects to detach. The value is in the [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>] format.</para>
        /// </summary>
        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}

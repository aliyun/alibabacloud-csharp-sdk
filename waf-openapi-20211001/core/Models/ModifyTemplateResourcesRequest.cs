// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyTemplateResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the protected assets to associate, in the format of [&quot;XX1&quot;,&quot;XX2&quot;,...].</para>
        /// </summary>
        [NameInMap("BindAssets")]
        [Validation(Required=false)]
        public List<string> BindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups to associate, in the format of [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>].</para>
        /// </summary>
        [NameInMap("BindResourceGroups")]
        [Validation(Required=false)]
        public List<string> BindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects to associate, in the format of [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>].</para>
        /// </summary>
        [NameInMap("BindResources")]
        [Validation(Required=false)]
        public List<string> BindResources { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run mode. If you do not specify this parameter, a normal request is sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: A dry run request is sent. The system checks whether the request meets the execution conditions without performing the specified operation. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the error code Defense.Control.DryRunOperation is returned.</description></item>
        /// <item><description><b>false</b>: A normal request is sent. The specified operation is performed after the request passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the current WAF instance.</para>
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
        /// <para>The IDs of the protected assets to disassociate, in the format of [&quot;XX1&quot;,&quot;XX2&quot;,...].</para>
        /// </summary>
        [NameInMap("UnbindAssets")]
        [Validation(Required=false)]
        public List<string> UnbindAssets { get; set; }

        /// <summary>
        /// <para>The protected object groups to disassociate, in the format of [<b>&quot;group1&quot;,&quot;group2&quot;,...</b>].</para>
        /// </summary>
        [NameInMap("UnbindResourceGroups")]
        [Validation(Required=false)]
        public List<string> UnbindResourceGroups { get; set; }

        /// <summary>
        /// <para>The protected objects to disassociate, in the format of [<b>&quot;XX1&quot;,&quot;XX2&quot;,...</b>].</para>
        /// </summary>
        [NameInMap("UnbindResources")]
        [Validation(Required=false)]
        public List<string> UnbindResources { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// <para>The proxy type of the hybrid cloud cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>service</b>: SDK-based integration.</para>
        /// </description></item>
        /// <item><description><para><b>cname</b>: CNAME-based reverse proxy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cname</para>
        /// </summary>
        [NameInMap("ClusterProxyType")]
        [Validation(Required=false)]
        public string ClusterProxyType { get; set; }

        /// <summary>
        /// <para>The name of the hybrid cloud node group that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groupName1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public int? GroupName { get; set; }

        /// <summary>
        /// <para>The type of the hybrid cloud node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>protect</b>: protection node group.</para>
        /// </description></item>
        /// <item><description><para><b>control</b>: control node group.</para>
        /// </description></item>
        /// <item><description><para><b>storage</b>: storage node group.</para>
        /// </description></item>
        /// <item><description><para><b>controlStorage</b>: control and storage node group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>protect</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-********w0b</para>
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
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance resides. Valid values:</para>
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
        /// <para>The ID of the resource group to which the WAF instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

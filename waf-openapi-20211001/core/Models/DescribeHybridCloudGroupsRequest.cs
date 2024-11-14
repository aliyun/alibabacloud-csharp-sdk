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
        /// <para>The type of proxy cluster that is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>service</b>: service-based traffic mirroring.</description></item>
        /// <item><description><b>cname</b>: reverse proxy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cname</para>
        /// </summary>
        [NameInMap("ClusterProxyType")]
        [Validation(Required=false)]
        public string ClusterProxyType { get; set; }

        /// <summary>
        /// <para>The name of the node group that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>groupName1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public int? GroupName { get; set; }

        /// <summary>
        /// <para>The type of the node group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>protect</b></description></item>
        /// <item><description><b>control</b></description></item>
        /// <item><description><b>storage</b></description></item>
        /// <item><description><b>controlStorage</b></description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the WAF instance. Valid values:</para>
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

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

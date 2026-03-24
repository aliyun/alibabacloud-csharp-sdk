// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserAssetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query information about hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asset_num</b>: the total number of API assets.</para>
        /// </description></item>
        /// <item><description><para><b>asset_active</b>: the number of active APIs.</para>
        /// </description></item>
        /// <item><description><para><b>asset_newborn</b>: the number of APIs that are added today.</para>
        /// </description></item>
        /// <item><description><para><b>asset_offline</b>: the number of inactive APIs.</para>
        /// </description></item>
        /// <item><description><para><b>asset_bot</b>: the number of APIs that receive bot requests.</para>
        /// </description></item>
        /// <item><description><para><b>asset_cross_border</b>: the number of APIs that are used for cross-border data transmission.</para>
        /// </description></item>
        /// <item><description><para><b>sensitive_api</b>: the number of APIs whose responses contain sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>sensitive_domain</b>: the number of sites whose responses contain sensitive data.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asset_num</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The time to query. The value is a UNIX timestamp in seconds. The time is in Coordinated Universal Time (UTC).</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1723435200</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        [Obsolete]
        public string Days { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-uax37ijm***</para>
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

    }

}

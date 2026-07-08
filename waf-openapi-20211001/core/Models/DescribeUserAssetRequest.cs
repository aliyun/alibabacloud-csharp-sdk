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
        /// <para>This parameter applies only to hybrid cloud scenarios. You can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to obtain hybrid cloud cluster information.</para>
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
        /// <item><description><b>asset_num</b>: total number of API assets.</description></item>
        /// <item><description><b>asset_active</b>: number of active APIs.</description></item>
        /// <item><description><b>asset_newborn</b>: number of APIs added today.</description></item>
        /// <item><description><b>asset_offline</b>: number of inactive APIs.</description></item>
        /// <item><description><b>asset_bot</b>: number of APIs with bot requests.</description></item>
        /// <item><description><b>asset_cross_border</b>: number of APIs with cross-border data transfer.</description></item>
        /// <item><description><b>sensitive_api</b>: number of APIs with sensitive data in responses.</description></item>
        /// <item><description><b>sensitive_domain</b>: number of sites with sensitive data in responses.</description></item>
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
        /// <para>The query time in UNIX timestamp format (UTC). Unit: seconds.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1723435200</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        [Obsolete]
        public string Days { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the WAF instance.</para>
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

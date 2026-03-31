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
        /// <para>For hybrid cloud scenarios only, you can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asset_num</b>: total number of APIs</description></item>
        /// <item><description><b>asset_active</b>: number of active APIs</description></item>
        /// <item><description><b>asset_newborn</b>: number of new APIs</description></item>
        /// <item><description><b>asset_offline</b>: number of deactivated APIs</description></item>
        /// <item><description><b>asset_bot</b>: number of APIs that are called by bots</description></item>
        /// <item><description><b>asset_cross_border</b>: number of APIs that are called for cross-border data transfer</description></item>
        /// <item><description><b>sensitive_api</b>: number of response-sensitive APIs</description></item>
        /// <item><description><b>sensitive_domain</b>: number of response-sensitive domain names</description></item>
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
        /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
        /// <remarks>
        /// <para>Notice: The parameter has been deprecated.</para>
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
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland</description></item>
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

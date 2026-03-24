// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserApiRequestRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The API operation.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated. Use the ApiId parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/v1/know</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
        [Obsolete]
        public string ApiFormat { get; set; }

        /// <summary>
        /// <para>The ID of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3799f0695c0d687f3295d132fe49bc14</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to obtain information about hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The domain name or IP address of the API operation.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is deprecated. Use the ApiId parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c.***.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        [Obsolete]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-zxu38***</para>
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
        /// <para>The type of statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>api_ip</b>: total traffic.</para>
        /// </description></item>
        /// <item><description><para><b>api_cross_border_ip</b>: cross-border traffic.</para>
        /// </description></item>
        /// <item><description><para><b>api_bot_ip</b>: bot traffic.</para>
        /// </description></item>
        /// <item><description><para><b>remote_region</b>: geographic location statistics.</para>
        /// </description></item>
        /// <item><description><para><b>client_id</b>: client type statistics.</para>
        /// </description></item>
        /// <item><description><para><b>http_referer</b>: Referer statistics.</para>
        /// </description></item>
        /// <item><description><para><b>api_cnt</b>: total number of calls.</para>
        /// </description></item>
        /// <item><description><para><b>bot_cnt</b>: number of bot requests.</para>
        /// </description></item>
        /// <item><description><para><b>cross_border_cnt</b>: number of cross-border requests.</para>
        /// </description></item>
        /// <item><description><para><b>api_freq</b>: call frequency.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>api_ip</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

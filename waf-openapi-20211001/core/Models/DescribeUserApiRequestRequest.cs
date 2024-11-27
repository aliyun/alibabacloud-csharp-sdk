// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserApiRequestRequest : TeaModel {
        /// <summary>
        /// <para>The API.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated, please use ApiId to query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/api/v1/know</para>
        /// </summary>
        [NameInMap("ApiFormat")]
        [Validation(Required=false)]
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
        /// <para>The domain name or IP address of the API.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated, please use ApiId to query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c.***.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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

        /// <summary>
        /// <para>The type of the statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>api_ip</b>: total traffic</description></item>
        /// <item><description><b>api_cross_border_ip</b>: cross-border traffic</description></item>
        /// <item><description><b>api_bot_ip</b>: bot traffic</description></item>
        /// <item><description><b>remote_region</b>: geographical location</description></item>
        /// <item><description><b>client_id</b>: client type</description></item>
        /// <item><description><b>http_referer</b>: Referer</description></item>
        /// <item><description><b>api_cnt</b>: total number of calls</description></item>
        /// <item><description><b>bot_cnt</b>: number of bot calls</description></item>
        /// <item><description><b>cross_border_cnt</b>: number of cross-border requests</description></item>
        /// <item><description><b>api_freq</b>: call frequency</description></item>
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

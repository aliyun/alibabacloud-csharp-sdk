// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protected resource. WAF automatically generates this ID when you add the resource to WAF.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2839876.html">CreateCloudResource</a> to add a resource. Then, view the resource ID in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-8vbdlsd********81e22-80-ecs</para>
        /// </summary>
        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. You do not need to specify this parameter for the first request.</para>
        /// <remarks>
        /// <para>If a value is returned for this parameter, it indicates that a next page is available. To retrieve the next page of data, include the returned <b>NextToken</b> in your next request. Repeat this process until no value is returned, which indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The port of the cloud service that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

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
        /// <para>The ID of the resource instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-8vbdlsd********81e22</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

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
        /// <para>The cloud service to which the resource belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>mse</b>: Microservices Engine (MSE).</para>
        /// </description></item>
        /// <item><description><para><b>fc</b>: Function Compute (FC).</para>
        /// </description></item>
        /// <item><description><para><b>sae</b>: Serverless App Engine (SAE).</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: Classic Load Balancer (CLB) that uses the TCP protocol.</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: CLB that uses the HTTP or HTTPS protocol.</para>
        /// </description></item>
        /// <item><description><para><b>apig</b>: API Gateway (APIG).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Not all cloud services are available in all regions. If you specify this parameter, make sure that the specified cloud service is available in the selected region. Otherwise, the request may fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-lbj****cn0c</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The UID of the account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11769793******</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The domain name of the resource. This parameter is available when you query FC or SAE resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc-domain-test</para>
        /// </summary>
        [NameInMap("ResourceDomain")]
        [Validation(Required=false)]
        public string ResourceDomain { get; set; }

        /// <summary>
        /// <para>The name of the function. This parameter is available when you query FC resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc-test</para>
        /// </summary>
        [NameInMap("ResourceFunction")]
        [Validation(Required=false)]
        public string ResourceFunction { get; set; }

        /// <summary>
        /// <para>The ID of the resource instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-43glijk0fr****gths</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-name</para>
        /// </summary>
        [NameInMap("ResourceInstanceName")]
        [Validation(Required=false)]
        public string ResourceInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm4gh****wela</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the resource instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-name</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The cloud service to which the resource belongs. By default, instances of Application Load Balancer (ALB), Microservices Engine (MSE), Function Compute (FC), and Serverless App Engine (SAE) are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>alb</b>: ALB</para>
        /// </description></item>
        /// <item><description><para><b>mse</b>: MSE</para>
        /// </description></item>
        /// <item><description><para><b>fc</b>: FC</para>
        /// </description></item>
        /// <item><description><para><b>sae</b>: SAE</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS)</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: Classic Load Balancer (CLB) that uses TCP</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: CLB that uses HTTP or HTTPS</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each cloud service supports different regions. If you specify this parameter, make sure the region you specify for the ResourceRegionId parameter supports this service. Otherwise, the query may fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alb</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides. For more information, see the &quot;Regions and supported products&quot; section in this topic.</para>
        /// <remarks>
        /// <para>Each cloud service supports different regions. If you specify the ResourceProduct parameter, make sure the region you specify for this parameter supports that service. Otherwise, the query may fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The name of the route. This parameter is available when you query MSE resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-default-traffic</para>
        /// </summary>
        [NameInMap("ResourceRouteName")]
        [Validation(Required=false)]
        public string ResourceRouteName { get; set; }

    }

}

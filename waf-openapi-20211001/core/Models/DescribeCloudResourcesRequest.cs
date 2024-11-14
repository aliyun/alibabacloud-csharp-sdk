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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
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
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The domain name. You can use this parameter if you set ResourceProduct to fc or sae.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc-domain-test</para>
        /// </summary>
        [NameInMap("ResourceDomain")]
        [Validation(Required=false)]
        public string ResourceDomain { get; set; }

        /// <summary>
        /// <para>The function name. You can use this parameter if you set ResourceProduct to fc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc-test</para>
        /// </summary>
        [NameInMap("ResourceFunction")]
        [Validation(Required=false)]
        public string ResourceFunction { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-43glijk0fr****gths</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-name</para>
        /// </summary>
        [NameInMap("ResourceInstanceName")]
        [Validation(Required=false)]
        public string ResourceInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
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
        /// <para>The name of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-name</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The cloud service to which the resource belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>alb</b>: Application Load Balancer (ALB).</description></item>
        /// <item><description><b>mse</b>: Microservices Engine (MSE).</description></item>
        /// <item><description><b>fc</b>: Function Compute.</description></item>
        /// <item><description><b>sae</b>: Serverless App Engine (SAE).</description></item>
        /// </list>
        /// <remarks>
        /// <para> Different cloud services are available in different regions. The specified cloud service must be available in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alb</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

        /// <summary>
        /// <para>The region ID of the resource. For information about region IDs, see the following table.</para>
        /// <remarks>
        /// <para> Different cloud services are available in different regions. The specified cloud service must be available in the specified region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The route name. You can use this parameter if you set ResourceProduct to mse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-default-traffic</para>
        /// </summary>
        [NameInMap("ResourceRouteName")]
        [Validation(Required=false)]
        public string ResourceRouteName { get; set; }

    }

}

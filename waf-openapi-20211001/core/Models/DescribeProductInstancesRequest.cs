// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The Web Application Firewall (WAF) instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the current WAF instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-zxu****9d02</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704********9107</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The page number of the returned page. Default value: <b>1</b>.</para>
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
        /// <para>The protection status of WAF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>all</b>: All protected.</para>
        /// </description></item>
        /// <item><description><para><b>any</b>: Protected.</para>
        /// </description></item>
        /// <item><description><para><b>part</b>: Partially protected.</para>
        /// </description></item>
        /// <item><description><para><b>non</b>: Not protected.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ResourceInstanceAccessStatus")]
        [Validation(Required=false)]
        public string ResourceInstanceAccessStatus { get; set; }

        /// <summary>
        /// <para>The instance ID of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zeugkfj81jvo****4tqm</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the instance added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.X.X.1</para>
        /// </summary>
        [NameInMap("ResourceInstanceIp")]
        [Validation(Required=false)]
        public string ResourceInstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the instance added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoInstanceName</para>
        /// </summary>
        [NameInMap("ResourceInstanceName")]
        [Validation(Required=false)]
        public string ResourceInstanceName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The public IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.X.X.1</para>
        /// </summary>
        [NameInMap("ResourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz6ql****5uzi</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleResourceName</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>clb4</b>: Layer 4 CLB.</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb7</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-chengdu</b>: China (Chengdu).</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: China (Beijing).</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou</b>: China (Zhangjiakou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen).</para>
        /// </description></item>
        /// <item><description><para><b>cn-qingdao</b>: China (Qingdao).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-3</b>: Malaysia (Kuala Lumpur).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5</b>: Indonesia (Jakarta).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

    }

}

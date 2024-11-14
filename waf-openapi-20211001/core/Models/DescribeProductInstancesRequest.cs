// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704********9107</para>
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
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2zeugkfj81jvo****4tqm</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// <para>The IP address of the instance that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.X.X.1</para>
        /// </summary>
        [NameInMap("ResourceInstanceIp")]
        [Validation(Required=false)]
        public string ResourceInstanceIp { get; set; }

        /// <summary>
        /// <para>The name of the instance that is added to WAF.</para>
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
        /// <para>The cloud service to which the instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clb4</b>: Layer 4 Classic Load Balancer (CLB).</description></item>
        /// <item><description><b>clb7</b>: Layer 7 CLB.</description></item>
        /// <item><description><b>ecs</b>: Elastic Compute Service (ECS).</description></item>
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
        /// <item><description><b>cn-chengdu</b>: China (Chengdu).</description></item>
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou).</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai).</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen).</description></item>
        /// <item><description><b>cn-qingdao</b>: China (Qingdao).</description></item>
        /// <item><description><b>cn-hongkong</b>: China (Hong Kong).</description></item>
        /// <item><description><b>ap-southeast-3</b>: Malaysia (Kuala Lumpur).</description></item>
        /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta).</description></item>
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

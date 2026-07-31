// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the current WAF instance.</para>
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
        /// <para>The UID of the resource ownership user.</para>
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
        /// <para>The number of entries per page when paging. Default value: <b>10</b>.</para>
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
        /// <para>The domain name that is added to WAF.</para>
        /// <remarks>
        /// <para>This parameter is supported only when the cloud service type is ddos.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.c**sw.net">www.c**sw.net</a></para>
        /// </summary>
        [NameInMap("ResourceDomain")]
        [Validation(Required=false)]
        public string ResourceDomain { get; set; }

        /// <summary>
        /// <para>The WAF protection status.</para>
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
        /// <para>The public IP address of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.X.X.1</para>
        /// </summary>
        [NameInMap("ResourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceIp { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
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
        /// <para>The instance name of the cloud service.</para>
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
        /// <item><description><para><b>ecs</b>: ECS.</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: NLB.</para>
        /// </description></item>
        /// <item><description><para><b>ddos</b>: Anti-DDoS.</para>
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
        /// <para>The region ID of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-chengdu</b>: China Southwest 1 (Chengdu).</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: China North 2 (Beijing).</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou</b>: China North 3 (Zhangjiakou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou</b>: China East 1 (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China East 2 (Shanghai).</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China South 1 (Shenzhen).</para>
        /// </description></item>
        /// <item><description><para><b>cn-qingdao</b>: China North 1 (Qingdao).</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: Hong Kong (China).</para>
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

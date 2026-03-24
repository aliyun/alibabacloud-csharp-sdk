// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DeleteCloudResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protected resource. WAF automatically generates this ID when you add the cloud service to WAF.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2839876.html">CreateCloudResource</a> to add a resource and then view the resource ID in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-****py9kcm2n6nuesiu2a-80-clb4</para>
        /// </summary>
        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to view the ID of your WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The port of the cloud service that is added to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        [Obsolete]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the cloud service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1*****jqnnqk5uj2p</para>
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        [Obsolete]
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The type of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>clb4</b>: Layer 4 CLB.</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: ECS.</para>
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
        [Obsolete]
        public string ResourceProduct { get; set; }

    }

}

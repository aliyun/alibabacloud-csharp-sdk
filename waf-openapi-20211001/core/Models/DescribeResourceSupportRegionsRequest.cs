// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceSupportRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to view the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region to which the WAF instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: indicates the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: indicates regions outside the Chinese mainland.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzpks****kdjq</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The cloud product to which the resource belongs. By default, instances of ALB, MSE, FC, and SAE products are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>alb</b>: indicates the ALB product.</para>
        /// </description></item>
        /// <item><description><para><b>mse</b>: indicates the MSE product.</para>
        /// </description></item>
        /// <item><description><para><b>fc</b>: indicates the FC product.</para>
        /// </description></item>
        /// <item><description><para><b>sae</b>: indicates the SAE product.</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: indicates the ECS product.</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: indicates the CLB(TCP) product.</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: indicates the CLB(HTTP/HTTPS) product.</para>
        /// </description></item>
        /// <item><description><para><b>apig</b>: indicates the APIG product.</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: indicates the NLB product.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each product supports different regions. When the product filter field has a value, you need to refer to the regions supported by the product. Otherwise, the filtering may fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>clb7</para>
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

    }

}

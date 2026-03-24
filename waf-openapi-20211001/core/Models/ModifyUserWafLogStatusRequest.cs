// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyUserWafLogStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-mp9153****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the log storage region. If this parameter is not specified, Simple Log Service is enabled in the region where the WAF instance resides.</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the default region where Simple Log Service is enabled for a WAF instance in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: the default region where Simple Log Service is enabled for a WAF instance outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/2712598.html">DescribeUserSlsLogRegions</a> to query the available log storage regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("LogRegionId")]
        [Validation(Required=false)]
        public string LogRegionId { get; set; }

        /// <summary>
        /// <para>Indicates whether Simple Log Service is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Simple Log Service is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Simple Log Service is enabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public int? LogStatus { get; set; }

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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

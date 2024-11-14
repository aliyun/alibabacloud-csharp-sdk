// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateApiExportRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <remarks>
        /// <para>For hybrid cloud scenarios only, you can call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to query the hybrid cloud clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>993</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-zxu3***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The extended parameters of the data export task. The parameter value is in the JSON format. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>instanceId</b>: the instance ID</description></item>
        /// <item><description><b>clusterId</b>: the ID of the hybrid cloud cluster</description></item>
        /// <item><description><b>orderKey</b>: the name of the field used to sort exported data</description></item>
        /// <item><description><b>orderWay</b>: the sorting method of the exported data</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;orderWay&quot;: &quot;asc&quot;,
        ///     &quot;orderKey&quot;: &quot;endTs&quot;,
        ///     &quot;instanceId&quot;: &quot;waf_v3prepaid_public_cn-****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The region in which the Web Application Firewall (WAF) instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b> (default): Chinese mainland.</description></item>
        /// <item><description><b>cn-hongkong</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region in which the Web Application Firewall (WAF) instance is deployed. Valid values:</para>
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
        /// <para>The type of the data export task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>apisec_api</b>: API tasks</description></item>
        /// <item><description><b>apisec_abnormal</b>: API risk tasks</description></item>
        /// <item><description><b>apisec_event</b>: API security event tasks</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apisec_api</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

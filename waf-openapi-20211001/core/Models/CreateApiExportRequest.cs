// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateApiExportRequest : TeaModel {
        /// <summary>
        /// <para>The hybrid cloud cluster ID.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. You can call <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> to obtain hybrid cloud cluster information.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the ID of the current WAF instance.</para>
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
        /// <para>The extended parameters of the export task. You can filter the exported content by specifying conditions. The value is a JSON string constructed from a series of parameters.</para>
        /// <remarks>
        /// <para>The specific parameters vary depending on the specified <b>export task type</b> (<b>Type</b>). For more information, refer to <b>Export task parameter description</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;startTime&quot;: 1741449600,
        ///     &quot;endTime&quot;: 1744079820,
        ///     &quot;sensitiveLevel&quot;: &quot;L1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The language type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the export task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>apisec_api</b> (default): API asset task.</para>
        /// </description></item>
        /// <item><description><para><b>apisec_abnormal</b>: API risk task.</para>
        /// </description></item>
        /// <item><description><para><b>apisec_event</b>: API security event task.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apisec_api</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}

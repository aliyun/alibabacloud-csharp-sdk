// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTimeSeriesMetricShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the query. Multiple filter conditions have a logical AND relationship.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-tl32ast****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies the content of the returned data. Different metrics correspond to different data content. This operation supports the following metrics:</para>
        /// <list type="bullet">
        /// <item><description><para>mitigated_requests: Returns the time series statistics of blocked requests.</para>
        /// </description></item>
        /// <item><description><para>monitored_requests: Returns the time series statistics of requests that hit only observation-type rules.</para>
        /// </description></item>
        /// <item><description><para>mitigated_requests_group_by_defense_scene: Returns data grouped by module. It records a time series graph of the hit count for each module. A single request may hit multiple modules. Therefore, the hit count returned by this metric may not be consistent with the number of requests.</para>
        /// </description></item>
        /// <item><description><para>mitigated_requests_group_by_block_defense_scene: Returns data grouped by module. It records a time series graph of the number of blocked requests for each module. A single request is blocked by only one module. Therefore, the count returned by this metric is consistent with the number of requests.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mitigated_requests</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTopNMetricShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the query. If you specify multiple filter conditions, all conditions must be met (logical AND).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The maximum number of entries to return. Results are sorted in descending order. Maximum value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The metric by which to query and rank data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>real_client_ip: Returns the top N source IP addresses of requests that are sent to WAF. The data is aggregated by source IP address and sorted in descending order.</para>
        /// </description></item>
        /// <item><description><para>http_user_agent: Returns the top N user agents of requests that are sent to WAF. The data is aggregated by user agent and sorted in descending order.</para>
        /// </description></item>
        /// <item><description><para>request_path: Returns the top N request URLs. The data is aggregated by URL and sorted in descending order.</para>
        /// </description></item>
        /// <item><description><para>matched_host_by_total_requests: Returns the top N protected objects by total number of requests received.</para>
        /// </description></item>
        /// <item><description><para>matched_host_by_qps: Returns the top N protected objects by queries per second (QPS).</para>
        /// </description></item>
        /// <item><description><para>matched_host_by_status: Returns the top N protected objects based on a specific WAF-returned HTTP status code. The data is aggregated by protected object and sorted in descending order. If you set Metric to this value, you must specify the status field in the Conditions parameter of Filter. The format is as follows:<br> {&quot;Key&quot;:&quot;status&quot;,&quot;OpValue&quot;:&quot;eq&quot;,&quot;Values&quot;:&quot;200&quot;}<br></para>
        /// </description></item>
        /// <item><description><para>matched_host_by_upstream_status: Returns the top N protected objects based on a specific origin server-returned HTTP status code. The data is aggregated by protected object and sorted in descending order. If you set Metric to this value, you must specify the upstream_status field in the Conditions parameter of Filter. The format is as follows:<br> {&quot;Key&quot;:&quot;upstream_status&quot;,&quot;OpValue&quot;:&quot;eq&quot;,&quot;Values&quot;:&quot;200&quot;}<br></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>matched_host_by_upstream_status</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance resides. Valid values:</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeNetworkFlowTopNMetricShrinkRequest : TeaModel {
        /// <summary>
        /// <para>An array of filter conditions. Multiple filter parameters use AND logic.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The Web Application Firewall (WAF) instance ID.</para>
        /// <remarks>
        /// <para> Call the <a href="https://help.aliyun.com/document_detail/140857.html">DescribeInstanceInfo</a> operation to retrieve the WAF instance ID.</para>
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
        /// <para>Returns up to 10 data entries, sorted in descending order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>Specifies the data type to be returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>real_client_ip: The top N requests, sorted in descending order by source IP address, aggregated from all the current user\&quot;s WAF requests.</description></item>
        /// <item><description>request_path: The top N requests, sorted in descending order by user-agent, aggregated from all the current user\&quot;s WAF requests.</description></item>
        /// <item><description>request_path: The top N requests, sorted in descending order by request URL, aggregated from all the current user\&quot;s WAF requests.</description></item>
        /// <item><description>matched_host_by_total_requests: The top N protected objects and their request counts for the current user.</description></item>
        /// <item><description>matched_host_by_qps: The top N protected objects and their queries per second (QPS) values.</description></item>
        /// <item><description>matched_host_by_status: When using it, you must specify status in the Conditions field of the Filter parameter. If the HTTP response code returned by WAF matches the status specified in the Conditions, then the top N data is returned, sorted in descending order by protected objects. The format for specifying the status is as follows:\
        /// {&quot;Key&quot;:&quot;status&quot;,&quot;OpValue&quot;:&quot;eq&quot;,&quot;Values&quot;:&quot;200&quot;}</description></item>
        /// <item><description>matched_host_by_upstream_status: When using it, you must specify upstream_status in the Conditions field of the Filter parameter. If the HTTP response code returned by the origin server matches the upstream_status specified, the top N data is returned, sorted in descending order by protected objects. The format for specifying the upstream_status is as follows:\
        /// {&quot;Key&quot;:&quot;upstream_status&quot;,&quot;OpValue&quot;:&quot;eq&quot;,&quot;Values&quot;:&quot;200&quot;}</description></item>
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
        /// <para>The region ID of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: The Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}

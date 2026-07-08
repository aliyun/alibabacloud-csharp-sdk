// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network access mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: access over the Internet.</para>
        /// </description></item>
        /// <item><description><para><b>vpc</b>: access over an Express Connect circuit.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>The region for Express Connect circuit access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: Hangzhou.</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing</b>: Beijing.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: Shanghai.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AccessRegion")]
        [Validation(Required=false)]
        public string AccessRegion { get; set; }

        /// <summary>
        /// <para>The name of the hybrid cloud cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The listening ports for the HTTP protocol. Separate multiple ports with commas (,), such as <b>port1,port2,port3</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,8080</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The listening ports for the HTTPS protocol. Separate multiple ports with commas (,), such as <b>port1,port2,port3</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443,8443</para>
        /// </summary>
        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. It no longer returns meaningful data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>deprecated</para>
        /// </summary>
        [NameInMap("LogFieldsNotReturned")]
        [Validation(Required=false)]
        [Obsolete]
        public string LogFieldsNotReturned { get; set; }

        /// <summary>
        /// <para>The maximum number of protection nodes that can be added to the hybrid cloud cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtectionServerCount")]
        [Validation(Required=false)]
        public int? ProtectionServerCount { get; set; }

        /// <summary>
        /// <para>Indicates whether the proxy gateway is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The proxy gateway is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The proxy gateway is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>The type of the hybrid cloud cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cname</b>: reverse proxy cluster. Traffic is forwarded through CNAME resolution.</para>
        /// </description></item>
        /// <item><description><para><b>service</b>: transparent proxy cluster. Traffic is forwarded at the service level.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cname</para>
        /// </summary>
        [NameInMap("ProxyType")]
        [Validation(Required=false)]
        public string ProxyType { get; set; }

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
        /// <para>The description of the hybrid cloud cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

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
        /// <para>The configuration of the bypass rule, in JSON format. This includes settings such as circuit breaker thresholds, request body size limits, and timeout values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;enable&quot;: true,
        ///       &quot;param&quot;: {
        ///             &quot;breaker&quot;: {
        ///                   &quot;duration&quot;: 1,
        ///                   &quot;failed&quot;: 1,
        ///                   &quot;recent_failed&quot;: 1
        ///             },
        ///             &quot;disable_protect&quot;: false,
        ///             &quot;max_request_body_len&quot;: 1,
        ///             &quot;timeout&quot;: 1
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>Indicates whether manual bypass is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Manual bypass is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Manual bypass is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>The type of the bypass rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bypass</b>: skips WAF security checks and allows traffic to pass through directly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bypass</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}

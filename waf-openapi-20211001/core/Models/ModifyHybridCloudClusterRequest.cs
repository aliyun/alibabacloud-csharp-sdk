// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network access mode of the hybrid cloud cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>internet</b>: access over the Internet.</para>
        /// </description></item>
        /// <item><description><para><b>vpc</b>: access over a leased line through a virtual private cloud (VPC).</para>
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
        /// <para>The region in which the leased line resides. This parameter is required when AccessMode is set to vpc. Valid values:</para>
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
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("AccessRegion")]
        [Validation(Required=false)]
        public string AccessRegion { get; set; }

        /// <summary>
        /// <para>The name of the hybrid cloud cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-example-***</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The list of HTTP ports supported by the hybrid cloud cluster. Separate multiple ports with commas (,). Format: <b>port1,port2,port3</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,8080</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The list of HTTPS ports supported by the hybrid cloud cluster. Separate multiple ports with commas (,). Format: <b>port1,port2,port3</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443,8443</para>
        /// </summary>
        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>The ID of the hybrid cloud cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The log fields that are excluded from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log_example</para>
        /// </summary>
        [NameInMap("LogFieldsNotReturned")]
        [Validation(Required=false)]
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
        /// <para>Indicates whether the proxy gateway is enabled. Valid values:</para>
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
        /// <item><description><para><b>cname</b>: a reverse proxy cluster.</para>
        /// </description></item>
        /// <item><description><para><b>service</b>: a service cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>service</para>
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
        /// <para>The remarks of the hybrid cloud cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remarkExample</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the WAF instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The rule configuration in JSON format. This includes settings such as the circuit breaker, request body length limit, and timeout.</para>
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
        /// <para>Indicates whether the rule is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: The rule is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bypass</b>: WAF bypasses security checks.</description></item>
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

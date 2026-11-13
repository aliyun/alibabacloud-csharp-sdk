// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network access mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet</b>: Internet access.</description></item>
        /// <item><description><b>vpc</b>: Private network access over Express Connect.</description></item>
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
        /// <para>The region for Express Connect access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Hangzhou.</description></item>
        /// <item><description><b>cn-beiijng</b>: Beijing.</description></item>
        /// <item><description><b>cn-shanghai</b>: Shanghai.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AccessRegion")]
        [Validation(Required=false)]
        public string AccessRegion { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The list of available ports for the HTTP protocol. The value is a string. If multiple ports are specified, use the <b>port1,port2,port3</b> format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80,8080</para>
        /// </summary>
        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        /// <summary>
        /// <para>The list of available ports for the HTTPS protocol. The value is a string. If multiple ports are specified, use the <b>port1,port2,port3</b> format.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated and no longer returns meaningful data.</para>
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
        /// <para>The number of protection nodes that can be added to the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProtectionServerCount")]
        [Validation(Required=false)]
        public int? ProtectionServerCount { get; set; }

        /// <summary>
        /// <para>The proxy gateway mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ProxyStatus")]
        [Validation(Required=false)]
        public string ProxyStatus { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cname</b>: Reverse proxy cluster.</description></item>
        /// <item><description><b>service</b>: Service cluster.</description></item>
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
        /// <item><description><b>cn-hangzhou</b>: The Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: Outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remark.</para>
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
        /// <para>The rule configuration.</para>
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
        /// <para>The manual bypass status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enabled.</description></item>
        /// <item><description><b>off</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>bypass</b>: Skips security checks and directly allows traffic.</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudClusterRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Hybrid Cloud WAF cluster.</para>
        /// <remarks>
        /// <para>This parameter applies only to hybrid cloud scenarios. Call the <a href="https://help.aliyun.com/document_detail/2849376.html">DescribeHybridCloudClusters</a> operation to obtain information about Hybrid Cloud WAF clusters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>428</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        /// <summary>
        /// <para>The configuration of the traffic redirection rule, in JSON format.</para>
        /// <remarks>
        /// <para>The modes are mutually exclusive. You can select only one mode. If you change the mode, all traffic redirection rules in the previous mode are cleared.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>check_mode</b>: the traffic redirection mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>all</b>: redirects all traffic.</para>
        /// </description></item>
        /// <item><description><para><b>part</b>: redirects a specific portion of traffic.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>type</b>: the match type for the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exact</b>: exact match.</para>
        /// </description></item>
        /// <item><description><para><b>regex</b>: regular expression match.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>substance</b>: the match value of the rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full volume drainage:{\&quot;check_mode\&quot;: \&quot;all\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;122\&quot;}
        /// Specified partial drainage：{\&quot;check_mode\&quot;: \&quot;part\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;12222\&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The status of the traffic redirection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// <para>The type of the traffic redirection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pullin</b>: traffic redirection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pullin</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}

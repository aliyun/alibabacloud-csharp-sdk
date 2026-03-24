// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterRuleRequest : TeaModel {
        /// <summary>
        /// <para>[Deprecated] The hybrid cloud cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10*</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster rule resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdbc-clusterrule-*******ym0w</para>
        /// </summary>
        [NameInMap("ClusterRuleResourceId")]
        [Validation(Required=false)]
        public string ClusterRuleResourceId { get; set; }

        /// <summary>
        /// <para>The Web Application Firewall (WAF) instance ID.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/140857.html">DescribeInstanceInfo</a> to query the current WAF instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-n6w***x52m</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: The Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Outside the Chinese mainland.</para>
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
        /// <para>The traffic routing rule configuration:</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The mode cannot be changed after it is selected.</para>
        /// <list type="bullet">
        /// <item><description><para><b>check_mode</b> Defines the traffic scope for the routing rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>all</b>: Routes all traffic.</para>
        /// </description></item>
        /// <item><description><para><b>part</b>: Routes a specified portion of traffic.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>type</b>: The rule\&quot;s match type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exact</b>: Exact match</para>
        /// </description></item>
        /// <item><description><para><b>regex</b>: Regular expression match.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>substance</b>: The value of the rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;check_mode\&quot;: \&quot;all\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;122\&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
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
        /// <para>[Deprecated] The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pullin</b>: Traffic routing configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pullin</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}

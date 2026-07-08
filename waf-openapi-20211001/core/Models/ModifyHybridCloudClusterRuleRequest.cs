// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterRuleRequest : TeaModel {
        /// <summary>
        /// <para>[Deprecated] The ID of the hybrid cloud cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10*</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// <para>The resource ID of the cluster rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdbc-clusterrule-*******ym0w</para>
        /// </summary>
        [NameInMap("ClusterRuleResourceId")]
        [Validation(Required=false)]
        public string ClusterRuleResourceId { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/140857.html">DescribeInstanceInfo</a> to query instance ID of the current WAF instance.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The traffic redirection rule configuration.</para>
        /// <para><notice>The mode cannot be modified.</notice></para>
        /// <list type="bullet">
        /// <item><description><b>check_mode</b>: The mode. Valid values:<list type="bullet">
        /// <item><description><b>all</b>: full traffic redirection.</description></item>
        /// <item><description><b>part</b>: partial traffic redirection.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>type</b>: The rule matching type. Valid values:<list type="bullet">
        /// <item><description><b>exact</b>: exact match.</description></item>
        /// <item><description><b>regex</b>: regular expression.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>substance</b>: The rule value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;check_mode\&quot;: \&quot;all\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;122\&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The rule status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
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
        /// <item><description><b>pullin</b>: traffic redirection configuration.</description></item>
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

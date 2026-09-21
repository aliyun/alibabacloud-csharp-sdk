// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateInterceptionRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter must be from an ACK cluster. You can call the DescribeClustersV1 operation of Container Service for Kubernetes (ACK) to query existing clusters, or call the CreateCluster operation to create a cluster, and then call the DescribeGroupedContainerInstances operation of Security Center to obtain the ID of a managed cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c35xxxa416</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas-test-cnnf</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The list of destination objects. The metric descriptions are as follows:</para>
        /// <list type="bullet">
        /// <item><description>targetId: The ID of the destination object. You can invoke the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to obtain this parameter.</description></item>
        /// <item><description>ports: The list of destination port ranges.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;targetId&quot;: 600036,
        ///             &quot;ports&quot;: [
        ///                   &quot;1/65535&quot;
        ///             ]
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("DstTargetList")]
        [Validation(Required=false)]
        public Dictionary<string, object> DstTargetList { get; set; }

        /// <summary>
        /// <para>The interception mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Block Mode.</description></item>
        /// <item><description><b>2</b>: Alert mode.</description></item>
        /// <item><description><b>3</b>: Allow mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InterceptType")]
        [Validation(Required=false)]
        public long? InterceptType { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderIndex")]
        [Validation(Required=false)]
        public long? OrderIndex { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule-1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>customize: user-defined rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The source object. The metric description is as follows:</para>
        /// <list type="bullet">
        /// <item><description>targetId: The ID of the source object. You can invoke the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to obtain this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;targetId&quot;:301940}</para>
        /// </summary>
        [NameInMap("SrcTarget")]
        [Validation(Required=false)]
        public Dictionary<string, object> SrcTarget { get; set; }

    }

}

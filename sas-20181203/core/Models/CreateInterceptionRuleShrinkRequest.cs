// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateInterceptionRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of container clusters.</para>
        /// </remarks>
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
        /// <para>The information about the destination network object. The value of this parameter contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>targetId: the ID of the destination network object. You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to query the ID.</description></item>
        /// <item><description>ports: the destination port ranges.</description></item>
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
        public string DstTargetListShrink { get; set; }

        /// <summary>
        /// <para>The action on traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: blocks traffic.</description></item>
        /// <item><description><b>2</b>: allows traffic and generates alerts.</description></item>
        /// <item><description><b>3</b>: allows traffic and does not generate alerts.</description></item>
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
        /// <para>The priority of the defense rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderIndex")]
        [Validation(Required=false)]
        public long? OrderIndex { get; set; }

        /// <summary>
        /// <para>The name of the defense rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-rule-1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies the status of the defense rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disables the rule.</description></item>
        /// <item><description><b>1</b>: enables the rule.</description></item>
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
        /// <para>The type of the defense rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>customize: custom rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The source network object. The value of this parameter contains the following field:</para>
        /// <list type="bullet">
        /// <item><description>targetId: the ID of the source network object. You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to query the ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;targetId&quot;:301940}</para>
        /// </summary>
        [NameInMap("SrcTarget")]
        [Validation(Required=false)]
        public string SrcTargetShrink { get; set; }

    }

}

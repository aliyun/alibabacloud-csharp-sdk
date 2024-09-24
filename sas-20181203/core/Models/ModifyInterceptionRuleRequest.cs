// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyInterceptionRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/182997.html">DescribeGroupedContainerInstances</a> operation to query the IDs of container clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c17ef568f81884cdab402decd5fcd****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The destination objects of the rule. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description>targetId: the ID of the destination object. You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to query the ID.</description></item>
        /// <item><description>ports: the destination port ranges.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;targetId&quot;:600069,&quot;ports&quot;:[&quot;80/8088&quot;]}</para>
        /// </summary>
        [NameInMap("DstTarget")]
        [Validation(Required=false)]
        public Dictionary<string, object> DstTarget { get; set; }

        /// <summary>
        /// <para>The interception mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: block</description></item>
        /// <item><description><b>2</b>: alert</description></item>
        /// <item><description><b>3</b>: allow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InterceptType")]
        [Validation(Required=false)]
        public int? InterceptType { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderIndex")]
        [Validation(Required=false)]
        public long? OrderIndex { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500018</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tetsRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// <para>The source object of the rule. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description>targetId: the ID of the source object. You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to query the ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;targetId&quot;:400989}</para>
        /// </summary>
        [NameInMap("SrcTarget")]
        [Validation(Required=false)]
        public Dictionary<string, object> SrcTarget { get; set; }

    }

}

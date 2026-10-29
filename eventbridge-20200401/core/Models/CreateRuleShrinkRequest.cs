// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Filter rule for Simple Message Queue (formerly MNS) (SMQ)</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the event bus.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyEventBus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The list of event targets.</para>
        /// </summary>
        [NameInMap("EventTargets")]
        [Validation(Required=false)]
        public string EventTargetsShrink { get; set; }

        /// <summary>
        /// <para>The event pattern in JSON format. The following patterns are supported:</para>
        /// <list type="bullet">
        /// <item><description>stringEqual pattern</description></item>
        /// <item><description>stringExpression pattern
        /// Each field supports up to five expressions in a map structure.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;source&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;acs.&quot;
        ///     }
        ///   ],
        ///   &quot;type&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;oss:ObjectReplication&quot;
        ///     }
        ///   ],
        ///   &quot;subject&quot;: [
        ///     {
        ///       &quot;prefix&quot;: &quot;acs:oss:cn-hangzhou:123456789098****:my-movie-bucket/&quot;,
        ///       &quot;suffix&quot;: &quot;.txt&quot;
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("FilterPattern")]
        [Validation(Required=false)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// <para>The name of the event rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMQRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLE: The rule is enabled. This is the default status.</description></item>
        /// <item><description>DISABLE: The rule is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

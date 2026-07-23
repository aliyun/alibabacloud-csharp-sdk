// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the event rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMQ filter rule</para>
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
        /// <para>A list of event targets.</para>
        /// </summary>
        [NameInMap("EventTargets")]
        [Validation(Required=false)]
        public string EventTargetsShrink { get; set; }

        /// <summary>
        /// <para>The event pattern, in JSON format. Supported pattern types are <c>stringEqual</c> and <c>stringExpression</c>. Each field can contain a maximum of five expressions in a map structure.</para>
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
        /// <para>The status of the event rule. Valid values: <c>ENABLE</c>: The rule is enabled. This is the default value. <c>DISABLE</c>: The rule is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

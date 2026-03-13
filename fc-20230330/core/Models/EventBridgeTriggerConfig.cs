// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventBridgeTriggerConfig : TeaModel {
        /// <summary>
        /// <para>Whether to invoke the function in asynchronous mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>false</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asyncInvocationType")]
        [Validation(Required=false)]
        public bool? AsyncInvocationType { get; set; }

        /// <summary>
        /// <para>The event pattern. The value is in the JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/181432.html">Event patterns</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("eventRuleFilterPattern")]
        [Validation(Required=false)]
        public string EventRuleFilterPattern { get; set; }

        /// <summary>
        /// <para>The event destination configurations.</para>
        /// </summary>
        [NameInMap("eventSinkConfig")]
        [Validation(Required=false)]
        public EventSinkConfig EventSinkConfig { get; set; }

        /// <summary>
        /// <para>The event source configurations.</para>
        /// </summary>
        [NameInMap("eventSourceConfig")]
        [Validation(Required=false)]
        public EventSourceConfig EventSourceConfig { get; set; }

        /// <summary>
        /// <para>The runtime configurations.</para>
        /// </summary>
        [NameInMap("runOptions")]
        [Validation(Required=false)]
        public RunOptions RunOptions { get; set; }

        /// <summary>
        /// <para>Whether to enable the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("triggerEnable")]
        [Validation(Required=false)]
        public bool? TriggerEnable { get; set; }

    }

}

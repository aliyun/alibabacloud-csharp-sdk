// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class EventBridgeTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The method used by the trigger to invoke the function. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: synchronous call.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: asynchronous invocation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asyncInvocationType")]
        [Validation(Required=false)]
        public bool? AsyncInvocationType { get; set; }

        /// <summary>
        /// <para>Event pattern. Use JSON format. For detailed rules, see <a href="https://help.aliyun.com/document_detail/181432.html">event pattern</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("eventRuleFilterPattern")]
        [Validation(Required=false)]
        public string EventRuleFilterPattern { get; set; }

        /// <summary>
        /// <para>Event target configuration</para>
        /// </summary>
        [NameInMap("eventSinkConfig")]
        [Validation(Required=false)]
        public EventSinkConfig EventSinkConfig { get; set; }

        /// <summary>
        /// <para>Event source configuration.</para>
        /// </summary>
        [NameInMap("eventSourceConfig")]
        [Validation(Required=false)]
        public EventSourceConfig EventSourceConfig { get; set; }

        /// <summary>
        /// <para>Environment parameter configuration</para>
        /// </summary>
        [NameInMap("runOptions")]
        [Validation(Required=false)]
        public RunOptions RunOptions { get; set; }

        /// <summary>
        /// <para>Whether to enable the trigger. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enable the trigger.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disable the trigger.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>true</b></para>
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

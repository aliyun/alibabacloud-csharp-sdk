// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TimerTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The trigger period expression. You can specify to trigger based on a time interval. For example, the expression @every 4m indicates that the triggering is performed every four minutes. You can also specify to trigger based on a cron expression, for example, 0 0 4 \* \* \*.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 4 * * *</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>Specify whether to enable the trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Enter custom parameters. The trigger message is used as the value of the payload in the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;workflowInstanceId&quot;:&quot;39639&quot;}</para>
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

    }

}

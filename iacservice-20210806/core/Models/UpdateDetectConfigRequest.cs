// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateDetectConfigRequest : TeaModel {
        /// <summary>
        /// <para><b>Alert address list</b></para>
        /// </summary>
        [NameInMap("alarmConfigs")]
        [Validation(Required=false)]
        public List<UpdateDetectConfigRequestAlarmConfigs> AlarmConfigs { get; set; }
        public class UpdateDetectConfigRequestAlarmConfigs : TeaModel {
            /// <summary>
            /// <para>Alert address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:example@example.com">example@example.com</a></para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Alerting method.<br>Currently, only <c>cms</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Idempotent token, format: [0-9a-zA-Z-]{1,64}. We recommend using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para><b>Cron expression (UTC+8)</b>. Required when the trigger type is Cron.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 0 ? * 1</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para><b>Description</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>this is description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Drift detection name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("detectConfigName")]
        [Validation(Required=false)]
        public string DetectConfigName { get; set; }

        /// <summary>
        /// <para><b>Whether the detection feature is enabled. The default value is true.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para><b>Trigger type</b>  </para>
        /// <list type="bullet">
        /// <item><description>Manual: Execute manually  </description></item>
        /// <item><description>Cron: Trigger periodically</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}

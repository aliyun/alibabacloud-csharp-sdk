// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateDetectConfigRequest : TeaModel {
        /// <summary>
        /// <para>List of alerting addresses</para>
        /// </summary>
        [NameInMap("alarmConfigs")]
        [Validation(Required=false)]
        public List<CreateDetectConfigRequestAlarmConfigs> AlarmConfigs { get; set; }
        public class CreateDetectConfigRequestAlarmConfigs : TeaModel {
            /// <summary>
            /// <para>Alerting address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx">https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx</a></para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>Alerting method. Currently only <c>cms</c> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Idempotence token, format: <c>[0-9a-zA-Z-]{1,64}</c>. It is recommended to use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Cron expression (UTC+8). Required when trigger type is <c>Cron</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 0 ? * 1</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>Description, up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Detection configuration Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("detectConfigName")]
        [Validation(Required=false)]
        public string DetectConfigName { get; set; }

        /// <summary>
        /// <para>Whether the Detection feature is Enabled. The default value is <c>true</c>.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Trigger type  </para>
        /// <list type="bullet">
        /// <item><description>Manual: Execute manually  </description></item>
        /// <item><description>Cron: Trigger on a schedule</description></item>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateDetectConfigRequest : TeaModel {
        [NameInMap("alarmConfigs")]
        [Validation(Required=false)]
        public List<UpdateDetectConfigRequestAlarmConfigs> AlarmConfigs { get; set; }
        public class UpdateDetectConfigRequestAlarmConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:example@example.com">example@example.com</a></para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0 0 0 ? * 1</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>this is description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("detectConfigName")]
        [Validation(Required=false)]
        public string DetectConfigName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}

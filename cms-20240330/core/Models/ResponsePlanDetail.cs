// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ResponsePlanDetail : TeaModel {
        /// <summary>
        /// <para>The number of seconds for automatic recovery. If no new trigger occurs within this duration, the event is automatically recovered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The list of escalation plan IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;esc-uuid-xxx&quot;]</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The action integration push settings.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public ResponsePlanDetailPushingSetting PushingSetting { get; set; }
        public class ResponsePlanDetailPushingSetting : TeaModel {
            /// <summary>
            /// <para>The list of action integration IDs triggered by alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;action-uuid-xxx&quot;]</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>The list of action integration IDs triggered by recovery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;action-uuid-yyy&quot;]</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

        }

        /// <summary>
        /// <para>The repeat notification configuration.</para>
        /// </summary>
        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public ResponsePlanDetailRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class ResponsePlanDetailRepeatNotifySetting : TeaModel {
            /// <summary>
            /// <para>The target event status at which repeated notifications stop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RECOVERED</para>
            /// </summary>
            [NameInMap("endIncidentState")]
            [Validation(Required=false)]
            public string EndIncidentState { get; set; }

            /// <summary>
            /// <para>The interval for repeated notifications, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("repeatInterval")]
            [Validation(Required=false)]
            public int? RepeatInterval { get; set; }

        }

    }

}

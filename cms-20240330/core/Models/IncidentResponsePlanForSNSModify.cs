// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResponsePlanForSNSModify : TeaModel {
        /// <summary>
        /// <para>The auto recovery time, in seconds. After this period, the incident is automatically resolved.</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The IDs of the escalation policies.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The push setting for notifications.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModifyPushingSetting PushingSetting { get; set; }
        public class IncidentResponsePlanForSNSModifyPushingSetting : TeaModel {
            /// <summary>
            /// <para>The IDs of the alert actions.</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>The IDs of the restore actions.</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            /// <summary>
            /// <para>The UUID of the notification template.</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>The repeat notification setting.</para>
        /// </summary>
        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModifyRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class IncidentResponsePlanForSNSModifyRepeatNotifySetting : TeaModel {
            /// <summary>
            /// <para>The incident state that stops repeat notifications.</para>
            /// </summary>
            [NameInMap("endIncidentState")]
            [Validation(Required=false)]
            public string EndIncidentState { get; set; }

            /// <summary>
            /// <para>The repeat interval for notifications, in seconds.</para>
            /// </summary>
            [NameInMap("repeatInterval")]
            [Validation(Required=false)]
            public int? RepeatInterval { get; set; }

        }

    }

}

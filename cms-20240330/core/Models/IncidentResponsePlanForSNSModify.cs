// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResponsePlanForSNSModify : TeaModel {
        /// <summary>
        /// <para>The auto-recovery time. Unit: seconds. After this is configured, if no new events are generated for the incident within this period, the incident is automatically marked as resolved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The list of escalation policy IDs. Associates with IncidentEscalationPolicy to define step-by-step escalation rules when an incident is not handled as expected, such as notifying a supervisor if the incident is not acknowledged within 30 minutes.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The action integration execution configuration that defines automated actions to trigger when an incident occurs and when it is recovered.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModifyPushingSetting PushingSetting { get; set; }
        public class IncidentResponsePlanForSNSModifyPushingSetting : TeaModel {
            /// <summary>
            /// <para>The list of action IDs to execute when an event is triggered. Actions must be created in advance by calling CreateAlertAction.</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>The list of action IDs to execute when an event is recovered.</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            /// <summary>
            /// <para>Deprecated. This parameter does not take effect even if a value is passed in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uuid</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>The repeat notification settings. When an incident remains unresolved, notifications are sent repeatedly at a fixed interval.</para>
        /// </summary>
        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSModifyRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class IncidentResponsePlanForSNSModifyRepeatNotifySetting : TeaModel {
            /// <summary>
            /// <para>The incident status at which repeat notifications stop. Repeat notifications are no longer sent after the incident reaches this status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("endIncidentState")]
            [Validation(Required=false)]
            public string EndIncidentState { get; set; }

            /// <summary>
            /// <para>The repeat notification interval. Unit: seconds.</para>
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

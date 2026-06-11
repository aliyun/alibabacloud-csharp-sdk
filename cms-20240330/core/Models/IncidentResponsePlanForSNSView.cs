// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentResponsePlanForSNSView : TeaModel {
        /// <summary>
        /// <para>The duration, in seconds, after which an incident without new alerts is automatically resolved.</para>
        /// </summary>
        [NameInMap("autoRecoverSeconds")]
        [Validation(Required=false)]
        public long? AutoRecoverSeconds { get; set; }

        /// <summary>
        /// <para>The time when the incident response plan was created, in UTC and in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates if the incident response plan is enabled. Valid values: <c>true</c> and <c>false</c>.</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The IDs of the escalation policies.</para>
        /// </summary>
        [NameInMap("escalationId")]
        [Validation(Required=false)]
        public List<string> EscalationId { get; set; }

        /// <summary>
        /// <para>The mode of the incident response plan. Valid values: <c>AUTO</c> and <c>MANUAL</c>.</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The name of the incident response plan.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The settings for sending notifications.</para>
        /// </summary>
        [NameInMap("pushingSetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSViewPushingSetting PushingSetting { get; set; }
        public class IncidentResponsePlanForSNSViewPushingSetting : TeaModel {
            /// <summary>
            /// <para>The IDs of actions to run when an alert is triggered.</para>
            /// </summary>
            [NameInMap("alertActionIds")]
            [Validation(Required=false)]
            public List<string> AlertActionIds { get; set; }

            /// <summary>
            /// <para>The IDs of actions to run when the incident is resolved.</para>
            /// </summary>
            [NameInMap("restoreActionIds")]
            [Validation(Required=false)]
            public List<string> RestoreActionIds { get; set; }

            /// <summary>
            /// <para>The ID of the notification template.</para>
            /// </summary>
            [NameInMap("templateUuid")]
            [Validation(Required=false)]
            public string TemplateUuid { get; set; }

        }

        /// <summary>
        /// <para>The settings for repeated notifications.</para>
        /// </summary>
        [NameInMap("repeatNotifySetting")]
        [Validation(Required=false)]
        public IncidentResponsePlanForSNSViewRepeatNotifySetting RepeatNotifySetting { get; set; }
        public class IncidentResponsePlanForSNSViewRepeatNotifySetting : TeaModel {
            /// <summary>
            /// <para>The incident state at which repeated notifications stop. For example, <c>resolved</c>.</para>
            /// </summary>
            [NameInMap("endIncidentState")]
            [Validation(Required=false)]
            public string EndIncidentState { get; set; }

            /// <summary>
            /// <para>The interval, in seconds, for repeated notifications.</para>
            /// </summary>
            [NameInMap("repeatInterval")]
            [Validation(Required=false)]
            public int? RepeatInterval { get; set; }

        }

        /// <summary>
        /// <para>The source of the incident.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The synchronization source type.</para>
        /// </summary>
        [NameInMap("syncFromType")]
        [Validation(Required=false)]
        public string SyncFromType { get; set; }

        /// <summary>
        /// <para>The type of the incident response plan.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the incident response plan was last updated, in UTC and in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The unique ID of the incident response plan.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentMemberStruct : TeaModel {
        /// <summary>
        /// <para>Acknowledgement Information Structure.</para>
        /// </summary>
        [NameInMap("acknowledge")]
        [Validation(Required=false)]
        public IncidentMemberStructAcknowledge Acknowledge { get; set; }
        public class IncidentMemberStructAcknowledge : TeaModel {
            /// <summary>
            /// <para>Acknowledgement level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("breakLevel")]
            [Validation(Required=false)]
            public string BreakLevel { get; set; }

            /// <summary>
            /// <para>Verification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741234567890</para>
            /// </summary>
            [NameInMap("verifyTime")]
            [Validation(Required=false)]
            public long? VerifyTime { get; set; }

        }

        /// <summary>
        /// <para>Contact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-12345</para>
        /// </summary>
        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// <para>Contact list.</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<IncidentMemberStructContacts> Contacts { get; set; }
        public class IncidentMemberStructContacts : TeaModel {
            /// <summary>
            /// <para>Channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>Contact ID (masked).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-12345</para>
            /// </summary>
            [NameInMap("contactMask")]
            [Validation(Required=false)]
            public string ContactMask { get; set; }

        }

        /// <summary>
        /// <para>Escalation phase information.</para>
        /// </summary>
        [NameInMap("escalation")]
        [Validation(Required=false)]
        public IncidentMemberStructEscalation Escalation { get; set; }
        public class IncidentMemberStructEscalation : TeaModel {
            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Notify the operations team.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Event Escalation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>escalation-001</para>
            /// </summary>
            [NameInMap("incidentEscalationId")]
            [Validation(Required=false)]
            public string IncidentEscalationId { get; set; }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Phase one.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Escalation phase index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("stageIndex")]
            [Validation(Required=false)]
            public string StageIndex { get; set; }

            /// <summary>
            /// <para>Title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alert escalated to the operations team.</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>Incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>incident-001</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>Event Member ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member-001</para>
        /// </summary>
        [NameInMap("incidentMemberId")]
        [Validation(Required=false)]
        public string IncidentMemberId { get; set; }

        /// <summary>
        /// <para>Schedule group.</para>
        /// </summary>
        [NameInMap("scheduleGroup")]
        [Validation(Required=false)]
        public IncidentMemberStructScheduleGroup ScheduleGroup { get; set; }
        public class IncidentMemberStructScheduleGroup : TeaModel {
            /// <summary>
            /// <para>Contact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group-001</para>
            /// </summary>
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Night shift duty team.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-08 10:18:58</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>User ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4123456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}

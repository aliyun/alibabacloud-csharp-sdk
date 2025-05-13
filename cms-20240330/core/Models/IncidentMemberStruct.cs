// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentMemberStruct : TeaModel {
        [NameInMap("acknowledge")]
        [Validation(Required=false)]
        public IncidentMemberStructAcknowledge Acknowledge { get; set; }
        public class IncidentMemberStructAcknowledge : TeaModel {
            [NameInMap("breakLevel")]
            [Validation(Required=false)]
            public string BreakLevel { get; set; }

            [NameInMap("verifyTime")]
            [Validation(Required=false)]
            public long? VerifyTime { get; set; }

        }

        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<IncidentMemberStructContacts> Contacts { get; set; }
        public class IncidentMemberStructContacts : TeaModel {
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            [NameInMap("contactMask")]
            [Validation(Required=false)]
            public string ContactMask { get; set; }

        }

        [NameInMap("escalation")]
        [Validation(Required=false)]
        public IncidentMemberStructEscalation Escalation { get; set; }
        public class IncidentMemberStructEscalation : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("incidentEscalationId")]
            [Validation(Required=false)]
            public string IncidentEscalationId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("stageIndex")]
            [Validation(Required=false)]
            public string StageIndex { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("incidentMemberId")]
        [Validation(Required=false)]
        public string IncidentMemberId { get; set; }

        [NameInMap("scheduleGroup")]
        [Validation(Required=false)]
        public IncidentMemberStructScheduleGroup ScheduleGroup { get; set; }
        public class IncidentMemberStructScheduleGroup : TeaModel {
            [NameInMap("contactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}

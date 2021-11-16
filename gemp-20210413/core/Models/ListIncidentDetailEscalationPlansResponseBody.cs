// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentDetailEscalationPlansResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListIncidentDetailEscalationPlansResponseBodyData Data { get; set; }
        public class ListIncidentDetailEscalationPlansResponseBodyData : TeaModel {
            [NameInMap("escalationPlanId")]
            [Validation(Required=false)]
            public long? EscalationPlanId { get; set; }
            [NameInMap("escalationPlanName")]
            [Validation(Required=false)]
            public string EscalationPlanName { get; set; }
            [NameInMap("nuAcknowledgeEscalationPlan")]
            [Validation(Required=false)]
            public List<ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlan> NuAcknowledgeEscalationPlan { get; set; }
            public class ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlan : TeaModel {
                public string EscalationPlanType { get; set; }
                public List<string> NoticeChannels { get; set; }
                public List<ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanNoticeObjectList> NoticeObjectList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanNoticeObjectList : TeaModel {
                    public long? NoticeObjectId { get; set; }
                    public string NoticeObjectName { get; set; }
                    public string NoticeObjectPhone { get; set; }
                }
                public long? NoticeTime { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("unFinishEscalationPlan")]
            [Validation(Required=false)]
            public List<ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlan> UnFinishEscalationPlan { get; set; }
            public class ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlan : TeaModel {
                public string EscalationPlanType { get; set; }
                public List<string> NoticeChannels { get; set; }
                public List<ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanNoticeObjectList> NoticeObjectList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanNoticeObjectList : TeaModel {
                    public long? NoticeObjectId { get; set; }
                    public string NoticeObjectName { get; set; }
                    public string NoticeObjectPhone { get; set; }
                }
                public int? NoticeTime { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

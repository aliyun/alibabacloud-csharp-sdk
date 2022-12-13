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
            [NameInMap("convergenceEscalationPlan")]
            [Validation(Required=false)]
            public List<ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlan> ConvergenceEscalationPlan { get; set; }
            public class ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlan : TeaModel {
                [NameInMap("escalationPlanType")]
                [Validation(Required=false)]
                public string EscalationPlanType { get; set; }

                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                [NameInMap("noticeObjectList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlanNoticeObjectList> NoticeObjectList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlanNoticeObjectList : TeaModel {
                    [NameInMap("noticeObjectId")]
                    [Validation(Required=false)]
                    public long? NoticeObjectId { get; set; }

                    [NameInMap("noticeObjectName")]
                    [Validation(Required=false)]
                    public string NoticeObjectName { get; set; }

                    [NameInMap("noticeObjectPhone")]
                    [Validation(Required=false)]
                    public string NoticeObjectPhone { get; set; }

                }

                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public long? NoticeTime { get; set; }

                [NameInMap("serviceGroupList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlanServiceGroupList> ServiceGroupList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataConvergenceEscalationPlanServiceGroupList : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

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
                [NameInMap("escalationPlanType")]
                [Validation(Required=false)]
                public string EscalationPlanType { get; set; }

                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                [NameInMap("noticeObjectList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanNoticeObjectList> NoticeObjectList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanNoticeObjectList : TeaModel {
                    [NameInMap("noticeObjectId")]
                    [Validation(Required=false)]
                    public long? NoticeObjectId { get; set; }

                    [NameInMap("noticeObjectName")]
                    [Validation(Required=false)]
                    public string NoticeObjectName { get; set; }

                    [NameInMap("noticeObjectPhone")]
                    [Validation(Required=false)]
                    public string NoticeObjectPhone { get; set; }

                }

                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public long? NoticeTime { get; set; }

                [NameInMap("serviceGroupList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanServiceGroupList> ServiceGroupList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataNuAcknowledgeEscalationPlanServiceGroupList : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("unFinishEscalationPlan")]
            [Validation(Required=false)]
            public List<ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlan> UnFinishEscalationPlan { get; set; }
            public class ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlan : TeaModel {
                [NameInMap("escalationPlanType")]
                [Validation(Required=false)]
                public string EscalationPlanType { get; set; }

                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                [NameInMap("noticeObjectList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanNoticeObjectList> NoticeObjectList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanNoticeObjectList : TeaModel {
                    [NameInMap("noticeObjectId")]
                    [Validation(Required=false)]
                    public long? NoticeObjectId { get; set; }

                    [NameInMap("noticeObjectName")]
                    [Validation(Required=false)]
                    public string NoticeObjectName { get; set; }

                    [NameInMap("noticeObjectPhone")]
                    [Validation(Required=false)]
                    public string NoticeObjectPhone { get; set; }

                }

                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public int? NoticeTime { get; set; }

                [NameInMap("serviceGroupList")]
                [Validation(Required=false)]
                public List<ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanServiceGroupList> ServiceGroupList { get; set; }
                public class ListIncidentDetailEscalationPlansResponseBodyDataUnFinishEscalationPlanServiceGroupList : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class BillingStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BillingStatisticsResponseBodyData Data { get; set; }
        public class BillingStatisticsResponseBodyData : TeaModel {
            [NameInMap("appUserCount")]
            [Validation(Required=false)]
            public long? AppUserCount { get; set; }

            [NameInMap("appUserCountFree")]
            [Validation(Required=false)]
            public long? AppUserCountFree { get; set; }

            [NameInMap("emailSend")]
            [Validation(Required=false)]
            public long? EmailSend { get; set; }

            [NameInMap("emailSendFree")]
            [Validation(Required=false)]
            public long? EmailSendFree { get; set; }

            [NameInMap("escalationPlanCount")]
            [Validation(Required=false)]
            public long? EscalationPlanCount { get; set; }

            [NameInMap("escalationPlanCountFree")]
            [Validation(Required=false)]
            public long? EscalationPlanCountFree { get; set; }

            [NameInMap("eventReportApi")]
            [Validation(Required=false)]
            public long? EventReportApi { get; set; }

            [NameInMap("eventReportApiFree")]
            [Validation(Required=false)]
            public long? EventReportApiFree { get; set; }

            [NameInMap("hasScheduleServiceGroupCount")]
            [Validation(Required=false)]
            public long? HasScheduleServiceGroupCount { get; set; }

            [NameInMap("hasScheduleServiceGroupCountFree")]
            [Validation(Required=false)]
            public long? HasScheduleServiceGroupCountFree { get; set; }

            [NameInMap("imMsgSend")]
            [Validation(Required=false)]
            public long? ImMsgSend { get; set; }

            [NameInMap("imMsgSendFree")]
            [Validation(Required=false)]
            public long? ImMsgSendFree { get; set; }

            [NameInMap("ruleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

            [NameInMap("ruleCountFree")]
            [Validation(Required=false)]
            public long? RuleCountFree { get; set; }

            [NameInMap("smsSend")]
            [Validation(Required=false)]
            public long? SmsSend { get; set; }

            [NameInMap("smsSendFree")]
            [Validation(Required=false)]
            public long? SmsSendFree { get; set; }

            [NameInMap("subscriptionNotifyCount")]
            [Validation(Required=false)]
            public long? SubscriptionNotifyCount { get; set; }

            [NameInMap("subscriptionNotifyCountFree")]
            [Validation(Required=false)]
            public long? SubscriptionNotifyCountFree { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public bool? Type { get; set; }

            [NameInMap("voiceSend")]
            [Validation(Required=false)]
            public long? VoiceSend { get; set; }

            [NameInMap("voiceSendFree")]
            [Validation(Required=false)]
            public long? VoiceSendFree { get; set; }

        }

    }

}

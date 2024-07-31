// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineResponseBodyData Data { get; set; }
        public class GetBaselineResponseBodyData : TeaModel {
            [NameInMap("AlertEnabled")]
            [Validation(Required=false)]
            public bool? AlertEnabled { get; set; }

            [NameInMap("AlertMarginThreshold")]
            [Validation(Required=false)]
            public int? AlertMarginThreshold { get; set; }

            /// <summary>
            /// The alert settings.
            /// </summary>
            [NameInMap("AlertSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataAlertSettings> AlertSettings { get; set; }
            public class GetBaselineResponseBodyDataAlertSettings : TeaModel {
                /// <summary>
                /// The interval at which an event alert notification is sent. Unit: seconds.
                /// </summary>
                [NameInMap("AlertInterval")]
                [Validation(Required=false)]
                public int? AlertInterval { get; set; }

                /// <summary>
                /// The maximum number of times an event alert notification is sent.
                /// </summary>
                [NameInMap("AlertMaximum")]
                [Validation(Required=false)]
                public int? AlertMaximum { get; set; }

                /// <summary>
                /// The alert notification methods.
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// The details of the alert recipient.
                /// 
                /// *   If the value of AlertRecipientType is OWNER, this parameter is left empty.
                /// *   If the value of AlertRecipientType is SHIFT_SCHEDULE, the value of this parameter is the ID of a shift schedule.
                /// *   If the value of AlertRecipientType is OTHER, the value of this parameter is the UIDs of specified personnel. Multiple UIDs are separated by commas (,).
                /// </summary>
                [NameInMap("AlertRecipient")]
                [Validation(Required=false)]
                public string AlertRecipient { get; set; }

                /// <summary>
                /// The type of the alert recipient. Valid values:
                /// 
                /// *   OWNER: indicates the node owner.
                /// *   OTHER: indicates specified personnel.
                /// *   SHIFT_SCHEDULE: indicates personnel in a shift schedule.
                /// </summary>
                [NameInMap("AlertRecipientType")]
                [Validation(Required=false)]
                public string AlertRecipientType { get; set; }

                /// <summary>
                /// The type of the alert. Valid values:
                /// 
                /// *   BASELINE: indicates a baseline alert.
                /// *   TOPIC: indicates an event alert.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// Indicates whether the baseline alerting feature is enabled. The feature is specific to baselines. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("BaselineAlertEnabled")]
                [Validation(Required=false)]
                public bool? BaselineAlertEnabled { get; set; }

                /// <summary>
                /// The DingTalk chatbots.
                /// </summary>
                [NameInMap("DingRobots")]
                [Validation(Required=false)]
                public List<GetBaselineResponseBodyDataAlertSettingsDingRobots> DingRobots { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsDingRobots : TeaModel {
                    /// <summary>
                    /// Indicates whether all members were reminded by using the at sign (@).
                    /// </summary>
                    [NameInMap("AtAll")]
                    [Validation(Required=false)]
                    public bool? AtAll { get; set; }

                    /// <summary>
                    /// The webhook URL of the DingTalk chatbot.
                    /// </summary>
                    [NameInMap("WebUrl")]
                    [Validation(Required=false)]
                    public string WebUrl { get; set; }

                }

                /// <summary>
                /// The end of the time range for silence. The time is in the HH:mm:ss format.
                /// </summary>
                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                /// <summary>
                /// The beginning of the time range for silence. The time is in the HH:mm:ss format.
                /// </summary>
                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

                /// <summary>
                /// The types of event alerts, which are event-specific configurations.
                /// </summary>
                [NameInMap("TopicTypes")]
                [Validation(Required=false)]
                public List<string> TopicTypes { get; set; }

                /// <summary>
                /// The webhook URLs.
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public List<string> Webhooks { get; set; }

            }

            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<long?> NodeIds { get; set; }

            [NameInMap("OverTimeSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataOverTimeSettings> OverTimeSettings { get; set; }
            public class GetBaselineResponseBodyDataOverTimeSettings : TeaModel {
                /// <summary>
                /// The cycle that corresponds to the committed completion time. For a day-level baseline, the value of this parameter is 1. For an hour-level baseline, the value of this parameter cannot exceed 24.
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public int? Cycle { get; set; }

                /// <summary>
                /// The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

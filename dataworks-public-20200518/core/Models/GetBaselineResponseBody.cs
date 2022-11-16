// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineResponseBody : TeaModel {
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

            [NameInMap("AlertSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataAlertSettings> AlertSettings { get; set; }
            public class GetBaselineResponseBodyDataAlertSettings : TeaModel {
                [NameInMap("AlertInterval")]
                [Validation(Required=false)]
                public int? AlertInterval { get; set; }

                [NameInMap("AlertMaximum")]
                [Validation(Required=false)]
                public int? AlertMaximum { get; set; }

                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                [NameInMap("AlertRecipient")]
                [Validation(Required=false)]
                public string AlertRecipient { get; set; }

                [NameInMap("AlertRecipientType")]
                [Validation(Required=false)]
                public string AlertRecipientType { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("BaselineAlertEnabled")]
                [Validation(Required=false)]
                public bool? BaselineAlertEnabled { get; set; }

                [NameInMap("DingRobots")]
                [Validation(Required=false)]
                public List<GetBaselineResponseBodyDataAlertSettingsDingRobots> DingRobots { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsDingRobots : TeaModel {
                    [NameInMap("AtAll")]
                    [Validation(Required=false)]
                    public bool? AtAll { get; set; }

                    [NameInMap("WebUrl")]
                    [Validation(Required=false)]
                    public string WebUrl { get; set; }

                }

                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

                [NameInMap("TopicTypes")]
                [Validation(Required=false)]
                public List<string> TopicTypes { get; set; }

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

            [NameInMap("OverTimeSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataOverTimeSettings> OverTimeSettings { get; set; }
            public class GetBaselineResponseBodyDataOverTimeSettings : TeaModel {
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public int? Cycle { get; set; }

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

            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

        }

        [NameInMap("DynamicErrorCode")]
        [Validation(Required=false)]
        public string DynamicErrorCode { get; set; }

        [NameInMap("DynamicErrorMessage")]
        [Validation(Required=false)]
        public string DynamicErrorMessage { get; set; }

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

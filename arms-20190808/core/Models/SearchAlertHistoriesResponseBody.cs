// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertHistoriesResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertHistoriesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertHistoriesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The information about alert records.
            /// </summary>
            [NameInMap("AlarmHistories")]
            [Validation(Required=false)]
            public List<SearchAlertHistoriesResponseBodyPageBeanAlarmHistories> AlarmHistories { get; set; }
            public class SearchAlertHistoriesResponseBodyPageBeanAlarmHistories : TeaModel {
                /// <summary>
                /// The content of the alert notification.
                /// </summary>
                [NameInMap("AlarmContent")]
                [Validation(Required=false)]
                public string AlarmContent { get; set; }

                /// <summary>
                /// The response code returned after the alert notification was sent.
                /// </summary>
                [NameInMap("AlarmResponseCode")]
                [Validation(Required=false)]
                public int? AlarmResponseCode { get; set; }

                /// <summary>
                /// The webhook URL, such as the webhook URL of a DingTalk chatbot.
                /// </summary>
                [NameInMap("AlarmSources")]
                [Validation(Required=false)]
                public string AlarmSources { get; set; }

                /// <summary>
                /// The time when the alert notification was sent.
                /// </summary>
                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public long? AlarmTime { get; set; }

                /// <summary>
                /// The type of the alert rule. Default value: 4. Valid values:
                /// 
                /// *   `1`: a custom alert rule that is used to monitor drill-down data sets
                /// *   `3`: a custom alert rule that is used to monitor tiled data sets
                /// *   `4`: an alert rule that is used to monitor web pages, including the default alert rule for browser monitoring
                /// *   `5`: an alert rule that is used to monitor applications, including the default alert rule for application monitoring
                /// *   `6`: the default alert rule for browser monitoring
                /// *   `7`: the default alert rule for application monitoring
                /// *   `8`: a Tracing Analysis alert rule
                /// *   `101`: a Prometheus alert rule
                /// </summary>
                [NameInMap("AlarmType")]
                [Validation(Required=false)]
                public int? AlarmType { get; set; }

                /// <summary>
                /// The email address of the alert contact.
                /// </summary>
                [NameInMap("Emails")]
                [Validation(Required=false)]
                public string Emails { get; set; }

                /// <summary>
                /// The ID of the alert notification.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The mobile phone number of the alert contact.
                /// </summary>
                [NameInMap("Phones")]
                [Validation(Required=false)]
                public string Phones { get; set; }

                /// <summary>
                /// The internal fields.
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// The internal fields.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

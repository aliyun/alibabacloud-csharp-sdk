// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateIMRobotResponseBody : TeaModel {
        /// <summary>
        /// The information about the IM chatbot.
        /// </summary>
        [NameInMap("AlertRobot")]
        [Validation(Required=false)]
        public CreateOrUpdateIMRobotResponseBodyAlertRobot AlertRobot { get; set; }
        public class CreateOrUpdateIMRobotResponseBodyAlertRobot : TeaModel {
            /// <summary>
            /// The configurations of the alert card template.
            /// </summary>
            [NameInMap("CardTemplate")]
            [Validation(Required=false)]
            public string CardTemplate { get; set; }

            /// <summary>
            /// Indicates whether daily statistics are sent. Valid values:
            /// 
            /// *   `false` (default): Daily statistics are not sent.
            /// *   `true`: Daily statistics are sent.
            /// </summary>
            [NameInMap("DailyNoc")]
            [Validation(Required=false)]
            public bool? DailyNoc { get; set; }

            /// <summary>
            /// The point in time at which the daily statistics are sent. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.
            /// </summary>
            [NameInMap("DailyNocTime")]
            [Validation(Required=false)]
            public string DailyNocTime { get; set; }

            /// <summary>
            /// Indicates whether the Outgoing feature is enabled.
            /// </summary>
            [NameInMap("EnableOutgoing")]
            [Validation(Required=false)]
            public bool? EnableOutgoing { get; set; }

            /// <summary>
            /// The webhook URL of the IM chatbot.
            /// </summary>
            [NameInMap("RobotAddress")]
            [Validation(Required=false)]
            public string RobotAddress { get; set; }

            /// <summary>
            /// The ID of the IM chatbot.
            /// </summary>
            [NameInMap("RobotId")]
            [Validation(Required=false)]
            public float? RobotId { get; set; }

            /// <summary>
            /// The name of the IM chatbot.
            /// </summary>
            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            /// <summary>
            /// The token required to enable the Outgoing feature.
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// The type of the IM chatbot. Valid values:
            /// 
            /// *   `dingding`: DingTalk chatbot
            /// *   `wechat`: WeCom chatbot
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

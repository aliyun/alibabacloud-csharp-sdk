// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateIMRobotRequest : TeaModel {
        /// <summary>
        /// The configurations of the alert card template. For more information about the parameters in the template, see the following section.
        /// </summary>
        [NameInMap("CardTemplate")]
        [Validation(Required=false)]
        public string CardTemplate { get; set; }

        /// <summary>
        /// Specifies whether to send daily statistics. Valid values:
        /// 
        /// *   `false` (default): Daily statistics are not sent.
        /// *   `true`: Daily statistics are sent. If you set the value to `true`, the **DailyNocTime** parameter is required.
        /// </summary>
        [NameInMap("DailyNoc")]
        [Validation(Required=false)]
        public bool? DailyNoc { get; set; }

        /// <summary>
        /// The points in time at which the daily statistics are sent. Separate multiple points in time with commas (,). The points in time are in the HH:SS format. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.
        /// </summary>
        [NameInMap("DailyNocTime")]
        [Validation(Required=false)]
        public string DailyNocTime { get; set; }

        /// <summary>
        /// The signature key of DingTalk. If you specify a signature key, DingTalk authentication is performed by using the signature key. If you do not specify a signature key, a whitelist is used for authentication by default. The keyword of the whitelist is **Alert**.
        /// </summary>
        [NameInMap("DingSignKey")]
        [Validation(Required=false)]
        public string DingSignKey { get; set; }

        /// <summary>
        /// Specifies whether to enable the Outgoing feature.
        /// </summary>
        [NameInMap("EnableOutgoing")]
        [Validation(Required=false)]
        public bool? EnableOutgoing { get; set; }

        /// <summary>
        /// The webhook URL of the IM chatbot.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RobotAddress")]
        [Validation(Required=false)]
        public string RobotAddress { get; set; }

        /// <summary>
        /// The ID of the IM chatbot.
        /// > If you do not specify the parameter, a new IM chatbot is created.
        /// </summary>
        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public long? RobotId { get; set; }

        /// <summary>
        /// The name of the IM chatbot.
        /// 
        /// This parameter is required.
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
        /// *   `feishu`: Lark chatbot.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

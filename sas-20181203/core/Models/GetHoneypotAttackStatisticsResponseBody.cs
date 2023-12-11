// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The status code that is returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The statistics.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotAttackStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotAttackStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of entries on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The statistics details.
            /// </summary>
            [NameInMap("HoneypotAttackStatistics")]
            [Validation(Required=false)]
            public List<GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics> HoneypotAttackStatistics { get; set; }
            public class GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics : TeaModel {
                /// <summary>
                /// The number of times the value is counted.
                /// </summary>
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                /// <summary>
                /// The statistical value.
                /// </summary>
                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            /// <summary>
            /// The type of the attack source statistics. Valid values:
            /// 
            /// *   **TOP_ATTACKED_AGENT**: the top five probes that are attacked the most frequently.
            /// *   **TOP_ATTACKED_IP**: the top five IP addresses that are attacked the most frequently.
            /// *   **ATTACK_EVENT_TYPE**: the type of the intrusion event.
            /// *   **ATTACK_HONEYPOT_TYPE**: the type of the attacked honeypot.
            /// </summary>
            [NameInMap("StatisticsType")]
            [Validation(Required=false)]
            public string StatisticsType { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

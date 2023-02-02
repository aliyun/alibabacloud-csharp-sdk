// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTrendTopicInputTpsResponseBody : TeaModel {
        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTrendTopicInputTpsResponseBodyData Data { get; set; }
        public class OnsTrendTopicInputTpsResponseBodyData : TeaModel {
            /// <summary>
            /// The data set that is returned based on each sampling period.
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public OnsTrendTopicInputTpsResponseBodyDataRecords Records { get; set; }
            public class OnsTrendTopicInputTpsResponseBodyDataRecords : TeaModel {
                [NameInMap("StatsDataDo")]
                [Validation(Required=false)]
                public List<OnsTrendTopicInputTpsResponseBodyDataRecordsStatsDataDo> StatsDataDo { get; set; }
                public class OnsTrendTopicInputTpsResponseBodyDataRecordsStatsDataDo : TeaModel {
                    /// <summary>
                    /// Indicates the timestamp. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// Indicates the TPS for message publishing or the number of messages that are published to the topic.
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

            }

            /// <summary>
            /// The name of the table that stores the data.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The unit of the timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("XUnit")]
            [Validation(Required=false)]
            public string XUnit { get; set; }

            /// <summary>
            /// The unit of the value of the Y parameter.
            /// </summary>
            [NameInMap("YUnit")]
            [Validation(Required=false)]
            public string YUnit { get; set; }

        }

        /// <summary>
        /// The ID of the request. The system generates a unique ID for each request. You can troubleshoot issues based on the request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

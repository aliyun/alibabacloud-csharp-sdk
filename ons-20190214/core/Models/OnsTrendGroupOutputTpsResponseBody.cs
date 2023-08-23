// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTrendGroupOutputTpsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTrendGroupOutputTpsResponseBodyData Data { get; set; }
        public class OnsTrendGroupOutputTpsResponseBodyData : TeaModel {
            /// <summary>
            /// The data set returned based on sampling period.
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public OnsTrendGroupOutputTpsResponseBodyDataRecords Records { get; set; }
            public class OnsTrendGroupOutputTpsResponseBodyDataRecords : TeaModel {
                [NameInMap("StatsDataDo")]
                [Validation(Required=false)]
                public List<OnsTrendGroupOutputTpsResponseBodyDataRecordsStatsDataDo> StatsDataDo { get; set; }
                public class OnsTrendGroupOutputTpsResponseBodyDataRecordsStatsDataDo : TeaModel {
                    /// <summary>
                    /// The X axis. The value of this parameter is a UNIX timestamp in milliseconds.
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// The Y axis. This parameter indicates the TPS for message consumption or the number of messages that are consumed.
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

            }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The unit of the timestamp.
            /// </summary>
            [NameInMap("XUnit")]
            [Validation(Required=false)]
            public string XUnit { get; set; }

            /// <summary>
            /// The total number of messages.
            /// </summary>
            [NameInMap("YUnit")]
            [Validation(Required=false)]
            public string YUnit { get; set; }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

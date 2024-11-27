// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTrendTopicInputTpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTrendTopicInputTpsResponseBodyData Data { get; set; }
        public class OnsTrendTopicInputTpsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data set returned based on sampling period.</para>
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
                    /// <para>The X axis. The value of this parameter is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570852800000</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <para>The Y axis. This parameter indicates the TPS for message publishing or the number of messages that are published.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public float? Y { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MQ_INST_111111111111_DOxxxxxx%test trend of received messages</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The unit of the timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>time</para>
            /// </summary>
            [NameInMap("XUnit")]
            [Validation(Required=false)]
            public string XUnit { get; set; }

            /// <summary>
            /// <para>The unit of the Y axis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg</para>
            /// </summary>
            [NameInMap("YUnit")]
            [Validation(Required=false)]
            public string YUnit { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E213AD8A-0730-4B3D-A35A-340DA47D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

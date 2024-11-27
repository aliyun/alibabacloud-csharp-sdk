// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTrendGroupOutputTpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsTrendGroupOutputTpsResponseBodyData Data { get; set; }
        public class OnsTrendGroupOutputTpsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data set returned based on sampling period.</para>
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
                    /// <para>The X axis. The value of this parameter is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1570867800000</para>
                    /// </summary>
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <para>The Y axis. This parameter indicates the TPS for message consumption or the number of messages that are consumed.</para>
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
            /// <para>MQ_INST_111111111111_DOxxxxxx%test@MQ_INST_111111111111_DOxxxxxx%GID_test trend chart of delivered messages</para>
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
            /// <para>The total number of messages.</para>
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
        /// <para>CE57AEDC-8FD2-43ED-8E3B-1F878077****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

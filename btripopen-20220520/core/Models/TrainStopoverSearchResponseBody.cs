// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStopoverSearchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<TrainStopoverSearchResponseBodyModule> Module { get; set; }
        public class TrainStopoverSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("arr_time")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("station_name")]
            [Validation(Required=false)]
            public string StationName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("station_no")]
            [Validation(Required=false)]
            public string StationNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("station_type")]
            [Validation(Required=false)]
            public string StationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("stop_over_time")]
            [Validation(Required=false)]
            public string StopOverTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

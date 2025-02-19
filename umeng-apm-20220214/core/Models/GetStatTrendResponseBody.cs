// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetStatTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetStatTrendResponseBodyData> Data { get; set; }
        public class GetStatTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>52</para>
            /// </summary>
            [NameInMap("affectedUserCount")]
            [Validation(Required=false)]
            public long? AffectedUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.3</para>
            /// </summary>
            [NameInMap("affectedUserRate")]
            [Validation(Required=false)]
            public double? AffectedUserRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25.6</para>
            /// </summary>
            [NameInMap("errorRate")]
            [Validation(Required=false)]
            public double? ErrorRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-06-01</para>
            /// </summary>
            [NameInMap("timePoint")]
            [Validation(Required=false)]
            public string TimePoint { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>succeed in handling request</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

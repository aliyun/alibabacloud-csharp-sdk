// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetNetworkMinuteTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNetworkMinuteTrendResponseBodyData> Data { get; set; }
        public class GetNetworkMinuteTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("requestCount")]
            [Validation(Required=false)]
            public long? RequestCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-20 09:08</para>
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

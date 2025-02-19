// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetNativePageTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNativePageTrendResponseBodyData> Data { get; set; }
        public class GetNativePageTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>75.9</para>
            /// </summary>
            [NameInMap("avgLoadDuration")]
            [Validation(Required=false)]
            public double? AvgLoadDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>37.317</para>
            /// </summary>
            [NameInMap("crashRate")]
            [Validation(Required=false)]
            public double? CrashRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2460</para>
            /// </summary>
            [NameInMap("loadCnt")]
            [Validation(Required=false)]
            public long? LoadCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99.837</para>
            /// </summary>
            [NameInMap("slowLoadRate")]
            [Validation(Required=false)]
            public double? SlowLoadRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-20</para>
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

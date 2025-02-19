// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetLaunchTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetLaunchTrendResponseBodyData> Data { get; set; }
        public class GetLaunchTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2495</para>
            /// </summary>
            [NameInMap("coldLaunchCount")]
            [Validation(Required=false)]
            public long? ColdLaunchCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3784.5</para>
            /// </summary>
            [NameInMap("coldLaunchDuration")]
            [Validation(Required=false)]
            public double? ColdLaunchDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2495</para>
            /// </summary>
            [NameInMap("firstLaunchCount")]
            [Validation(Required=false)]
            public long? FirstLaunchCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3740.5</para>
            /// </summary>
            [NameInMap("firstLaunchDuration")]
            [Validation(Required=false)]
            public double? FirstLaunchDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2495</para>
            /// </summary>
            [NameInMap("hotLaunchCount")]
            [Validation(Required=false)]
            public long? HotLaunchCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1400.5</para>
            /// </summary>
            [NameInMap("hotLaunchDuration")]
            [Validation(Required=false)]
            public double? HotLaunchDuration { get; set; }

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

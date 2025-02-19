// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetNetworkTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNetworkTrendResponseBodyData> Data { get; set; }
        public class GetNetworkTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4402.8</para>
            /// </summary>
            [NameInMap("avgCost")]
            [Validation(Required=false)]
            public double? AvgCost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1654.51</para>
            /// </summary>
            [NameInMap("avgResponseTime")]
            [Validation(Required=false)]
            public double? AvgResponseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3299.43</para>
            /// </summary>
            [NameInMap("avgTransformBytes")]
            [Validation(Required=false)]
            public double? AvgTransformBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.61</para>
            /// </summary>
            [NameInMap("requestPerMinute")]
            [Validation(Required=false)]
            public double? RequestPerMinute { get; set; }

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
